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
using CrystalDecisions.CrystalReports.Engine;

using SIATO.Classes;
using SIATO.CrystalReport;

namespace SIATO
{
    public partial class PrintView : Form
    {
        public string api_key;

        private ReportClass report;
        private string report_code;
        private string id;

        public PrintView(string code, string id)
        {
            InitializeComponent();
            this.id = id;
            report_code = code;

            switch(code)
            {
                case "SP":
                    report = new SuratPemesanan();
                    break;
            }
        }

        private void PrintView_Load(object sender, EventArgs e)
        {
            switch(report_code)
            {
                case "SP":
                    SuratPemesanan();
                    break;
            }

            crystalReportViewer.ReportSource = report;
        }

        private void SuratPemesanan()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/transaksi/pengadaan/detail/" + id, Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<DetailPengadaanBarang>>> (request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                List<Classes.Special.SuratPemesanan> data = new List<Classes.Special.SuratPemesanan>();
                foreach(DetailPengadaanBarang detail in apiResponse.data)
                {
                    data.Add(new Classes.Special.SuratPemesanan() {
                        nama_barang = detail.spareparts.nama,
                        merk = detail.spareparts.merk,
                        tipe_barang = detail.spareparts.tipe,
                        satuan = "",
                        jumlah = detail.jumlah_pesan
                    });
                }

                report.Database.Tables["surat_pemesanan"].SetDataSource(data);
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
