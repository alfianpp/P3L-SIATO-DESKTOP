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
    public partial class TransaksiPengadaanBarang : Form
    {
        public string api_key;

        private int selectedPengadaanBarangID = -1;
        private List<PengadaanBarang> listPengadaanBarang;
        private List<PengadaanBarang> listPengadaanBarangFiltered;

        public TransaksiPengadaanBarang()
        {
            InitializeComponent();
        }

        private void TransaksiPengadaanBarang_Load(object sender, EventArgs e)
        {
            clear();
            refreshTable();
        }

        private void btnPrintSP_Click(object sender, EventArgs e)
        {
            PrintView printView = new PrintView("SP", selectedPengadaanBarangID.ToString());
            printView.Show();
        }

        private void dataGridViewPengadaanBarang_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            show();
            btnPrintSP.Enabled = true;
        }

        private void setTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Supplier");
            dt.Columns.Add("Total");
            dt.Columns.Add("Tanggal Transaksi");
            dt.Columns.Add("Status");

            foreach (PengadaanBarang pengadaan_barang in listPengadaanBarangFiltered)
            {
                DataRow row = dt.NewRow();
                row[0] = pengadaan_barang.supplier.nama;
                row[1] = pengadaan_barang.total;
                row[2] = pengadaan_barang.tgl_transaksi;
                row[3] = pengadaan_barang.status;
                dt.Rows.Add(row);
            }

            DataView dv = new DataView(dt);
            dataGridViewPengadaanBarang.DataSource = dv;
            dataGridViewPengadaanBarang.ClearSelection();
        }

        private void index()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/transaksi/pengadaan/index", Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<PengadaanBarang>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                listPengadaanBarang = apiResponse.data;
                listPengadaanBarangFiltered = apiResponse.data;
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void show()
        {
            int index = dataGridViewPengadaanBarang.CurrentCell.RowIndex;
            selectedPengadaanBarangID = listPengadaanBarangFiltered[index].id;
            lblPengadaanBarangSupplier.Text = listPengadaanBarangFiltered[index].supplier.nama.ToString();
            lblPengadaanBarangTanggalTransaksi.Text = listPengadaanBarangFiltered[index].tgl_transaksi.ToString();
            lblPengadaanBarangStatus.Text = listPengadaanBarangFiltered[index].status.ToString();
        }

        private void refreshTable()
        {
            index();
            setTable();
        }

        private void clear()
        {
            lblPengadaanBarangSupplier.Text = "";
            lblPengadaanBarangTanggalTransaksi.Text = "";
            lblPengadaanBarangStatus.Text = "";
            btnPrintSP.Enabled = false;
        }
    }
}
