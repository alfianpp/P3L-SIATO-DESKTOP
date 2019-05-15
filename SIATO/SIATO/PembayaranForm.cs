using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SIATO.Classes;

namespace SIATO
{
    public partial class PembayaranForm : Form
    {
        private string url = "http://127.0.0.1:8000/api/";
        private string api_key;

        public PembayaranForm(string api_key)
        {
            InitializeComponent();
            this.api_key = api_key;
        }

        private void PembayaranForm_Load(object sender, EventArgs e)
        {
            reloadTable();
        }

        private void reloadTable()
        {
            var client = new RestClient(url);
            var request = new RestRequest("transaksi/pembayaran/index", Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<Penjualan>>>(request);
            if (!response.Data.error)
            {
                dataGridViewPembayaranIndex.DataSource = response.Data.data;
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetDetailPembayaran_Click(object sender, EventArgs e)
        {
            int index = dataGridViewPembayaranIndex.CurrentCell.RowIndex;
            var client = new RestClient(url);
            var request = new RestRequest("transaksi/pembayaran/detail/" + dataGridViewPembayaranIndex[0, index].Value.ToString(), Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<Pembayaran>>(request);
            if (!response.Data.error)
            {
                dataGridViewPembayaranDetailSpareparts.DataSource = response.Data.data.spareparts;
                dataGridViewPembayaranDetailJasaService.DataSource = response.Data.data.jasa_service;
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            var client = new RestClient(url);
            var request = new RestRequest("transaksi/pembayaran/detail/", Method.PUT);
            request.AddParameter("diskon", api_key);
            request.AddParameter("uang_diterima", api_key);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<Penjualan>>>(request);
            if (!response.Data.error)
            {
                MessageBox.Show(response.Data.message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
