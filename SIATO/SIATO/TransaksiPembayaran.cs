using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestSharp;

using SIATO.Classes;

namespace SIATO
{
    public partial class TransaksiPembayaran : Form
    {
        public string api_key;

        private int selectedPembayaranID = -1;
        private List<Penjualan> listPenjualan;
        private List<Penjualan> listPenjualanFiltered;

        public TransaksiPembayaran()
        {
            InitializeComponent();
        }

        private void TransaksiPembayaran_Load(object sender, EventArgs e)
        {
            clear();
            refreshTable();
        }

        private void btnBayarPembayaran_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btnBatalPembayaran_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnPrintNotaLunas_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tbPembayaranDiskon_TextChanged(object sender, EventArgs e)
        {
            lblPembayaranTotal.Text = (Convert.ToDouble(lblPembayaranSubtotal.Text) - Convert.ToDouble(tbPembayaranDiskon.Text)).ToString();
        }

        private void dataGridViewPembayaran_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            show();
        }

        private void setTablePembayaran()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("No. Transaksi");
            dt.Columns.Add("Konsumen");
            dt.Columns.Add("Telepon");
            dt.Columns.Add("Subtotal");
            dt.Columns.Add("Tanggal Transaksi");
            dt.Columns.Add("Status");

            foreach (Penjualan penjualan in listPenjualanFiltered)
            {
                DataRow row = dt.NewRow();
                row[0] = "";
                row[1] = penjualan.konsumen.nama;
                row[2] = penjualan.konsumen.nomor_telepon;
                row[3] = penjualan.subtotal;
                row[4] = penjualan.tgl_transaksi;
                row[5] = penjualan.status;
                dt.Rows.Add(row);
            }

            DataView dv = new DataView(dt);
            dataGridViewPembayaran.DataSource = dv;
            dataGridViewPembayaran.ClearSelection();
        }

        private void setTableDetailSpareparts(List<DetailPenjualanSpareparts> listDetailPenjualanSpareparts)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Kode");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Merk");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Jumlah");
            dt.Columns.Add("Subtotal");

            foreach (DetailPenjualanSpareparts detail in listDetailPenjualanSpareparts)
            {
                DataRow row = dt.NewRow();
                row[0] = detail.spareparts.kode;
                row[1] = detail.spareparts.nama;
                row[2] = detail.spareparts.merk;
                row[3] = detail.harga;
                row[4] = detail.jumlah;
                row[5] = detail.jumlah * detail.harga;
                dt.Rows.Add(row);
            }

            DataView dv = new DataView(dt);
            dataGridViewPembayaranDetailSpareparts.DataSource = dv;
            dataGridViewPembayaranDetailSpareparts.ClearSelection();
        }

        private void setTableDetailJasaService(List<DetailPenjualanJasaService> listDetailPenjualanJasaService)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nama");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Jumlah");
            dt.Columns.Add("Subtotal");

            foreach (DetailPenjualanJasaService detail in listDetailPenjualanJasaService)
            {
                DataRow row = dt.NewRow();
                row[0] = detail.jasa_service.nama;
                row[1] = detail.harga;
                row[2] = detail.jumlah;
                row[3] = detail.jumlah * detail.harga;
                dt.Rows.Add(row);
            }

            DataView dv = new DataView(dt);
            dataGridViewPembayaranDetailJasaService.DataSource = dv;
            dataGridViewPembayaranDetailJasaService.ClearSelection();
        }

        private void index()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/transaksi/pembayaran/index", Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<Penjualan>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                listPenjualan = apiResponse.data;
                listPenjualanFiltered = apiResponse.data;
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void show()
        {
            int index = dataGridViewPembayaran.CurrentCell.RowIndex;
            selectedPembayaranID = listPenjualanFiltered[index].id;

            if(listPenjualanFiltered[index].status == 2)
            {
                lblPembayaranSubtotal.Text = listPenjualanFiltered[index].subtotal.ToString();
                tbPembayaranDiskon.Enabled = true;
                lblPembayaranTotal.Text = listPenjualanFiltered[index].subtotal.ToString();
                tbPembayaranUangDiterima.Enabled = true;
                btnBayarPembayaran.Enabled = true;
                btnBatalPembayaran.Enabled = true;
            }
            else
            {
                btnPrintNotaLunas.Enabled = true;
            }

            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/transaksi/pembayaran/detail/" + selectedPembayaranID.ToString(), Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<Pembayaran>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                setTableDetailSpareparts(apiResponse.data.spareparts);
                setTableDetailJasaService(apiResponse.data.jasa_service);
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void update()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/transaksi/pembayaran/detail/" + selectedPembayaranID.ToString(), Method.PUT);
            request.AddParameter("diskon", tbPembayaranDiskon.Text);
            request.AddParameter("uang_diterima", tbPembayaranUangDiterima.Text);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<Classes.Error.Penjualan>>(request);

            var apiResponse = response.Data;
            if(!apiResponse.error)
            {
                MessageBox.Show(apiResponse.message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                refreshTable();
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void refreshTable()
        {
            index();
            setTablePembayaran();
        }

        private void clear()
        {
            lblPembayaranSubtotal.Text = "";
            tbPembayaranDiskon.Text = "";
            tbPembayaranDiskon.Enabled = false;
            lblPembayaranTotal.Text = "";
            tbPembayaranUangDiterima.Text = "";
            tbPembayaranUangDiterima.Enabled = false;
            btnBayarPembayaran.Enabled = false;
            btnBatalPembayaran.Enabled = false;
            btnPrintNotaLunas.Enabled = false;
            dataGridViewPembayaranDetailSpareparts.DataSource = null;
            dataGridViewPembayaranDetailJasaService.DataSource = null;
        }
    }
}
