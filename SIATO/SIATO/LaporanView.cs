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
    public partial class LaporanView : Form
    {
        public string api_key;

        private ReportClass report;
        private int report_code;
        private string title;
        public int tahun;
        public int bulan;
        public string tipe_barang;
        
        public LaporanView(int code)
        {
            InitializeComponent();
            report_code = code;

            switch (code)
            {
                case 1:
                    report = new SparepartsTerlaris();
                    title = "Spareparts Terlaris";
                    break;

                case 2:
                    report = new PendapatanBulanan();
                    title = "Pendapatan Bulanan";
                    break;

                case 3:
                    report = new PendapatanTahunan();
                    title = "Pendapatan Tahunan";
                    break;

                case 4:
                    report = new PengeluaranBulanan();
                    title = "Pendapatan Bulanan";
                    break;

                case 5:
                    report = new PenjualanJasa();
                    title = "Penjualan Jasa";
                    break;

                case 6:
                    report = new SisaStok();
                    title = "Sisa Stok";
                    break;
            }

            Text = "SIATO - " + title;
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            switch (report_code)
            {
                case 1:
                    LaporanSparepartsTerlaris(tahun);
                    break;

                case 2:
                    LaporanPendapatanBulanan(tahun);
                    break;

                case 3:
                    LaporanPendapatanTahunan();
                    break;

                case 4:
                    LaporanPengeluaranBulanan(tahun);
                    break;

                case 5:
                    LaporanPenjualanJasa(tahun, bulan);
                    break;

                case 6:
                    LaporanSisaStok(tahun, tipe_barang);
                    break;
            }

            if (report_code != 3)
            {
                report.SetParameterValue("TahunParameter", tahun);
            }

            if (report_code == 5)
            {
                report.SetParameterValue("BulanParameter", getMonthName(bulan));
            }

            if (report_code == 6)
            {
                report.SetParameterValue("TipeBarangParameter", tipe_barang);
            }

            crystalReportViewer.ReportSource = report;
        }

        private void LaporanSparepartsTerlaris(int tahun)
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/laporan/spareparts_terlaris", Method.POST);
            request.AddParameter("tahun", tahun);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<LaporanSparepartsTerlaris>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                for (int i = 0; i < apiResponse.data.Count; i++)
                {
                    apiResponse.data[i].bulan = getMonthName(Convert.ToInt32(apiResponse.data[i].bulan));
                }
                report.Database.Tables["spareparts_terlaris"].SetDataSource(apiResponse.data);
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LaporanPendapatanBulanan(int tahun)
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/laporan/pendapatan_bulanan", Method.POST);
            request.AddParameter("tahun", tahun);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<LaporanPendapatanBulanan>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                for (int i=0; i<apiResponse.data.Count; i++)
                {
                    apiResponse.data[i].bulan = getMonthName(Convert.ToInt32(apiResponse.data[i].bulan));
                }
                report.Database.Tables["pendapatan_bulanan"].SetDataSource(apiResponse.data);
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LaporanPendapatanTahunan()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/laporan/pendapatan_tahunan", Method.POST);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<LaporanPendapatanTahunan>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                report.Database.Tables["pendapatan_tahunan"].SetDataSource(apiResponse.data);
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LaporanPengeluaranBulanan(int tahun)
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/laporan/pengeluaran_bulanan", Method.POST);
            request.AddParameter("tahun", tahun);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<LaporanPengeluaranBulanan>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                for (int i = 0; i < apiResponse.data.Count; i++)
                {
                    apiResponse.data[i].bulan = getMonthName(Convert.ToInt32(apiResponse.data[i].bulan));
                }
                report.Database.Tables["pengeluaran_bulanan"].SetDataSource(apiResponse.data);
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LaporanPenjualanJasa(int tahun, int bulan)
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/laporan/penjualan_jasa", Method.POST);
            request.AddParameter("tahun", tahun);
            request.AddParameter("bulan", bulan);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<LaporanPenjualanJasa>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                report.Database.Tables["penjualan_jasa"].SetDataSource(apiResponse.data);
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LaporanSisaStok(int tahun, string tipe_barang)
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/laporan/sisa_stok", Method.POST);
            request.AddParameter("tahun", tahun);
            request.AddParameter("tipe_barang", tipe_barang);
            request.AddParameter("api_key", api_key);
            var response = client.Execute<APIResponse<List<LaporanSisaStok>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                for (int i = 0; i < apiResponse.data.Count; i++)
                {
                    apiResponse.data[i].bulan = getMonthName(Convert.ToInt32(apiResponse.data[i].bulan));
                }
                report.Database.Tables["sisa_stok"].SetDataSource(apiResponse.data);
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string getMonthName(int number)
        {
            switch (number)
            {
                case 1:
                    return "Januari";

                case 2:
                    return "Februari";

                case 3:
                    return "Maret";

                case 4:
                    return "April";

                case 5:
                    return "Mei";

                case 6:
                    return "Juni";

                case 7:
                    return "Juli";

                case 8:
                    return "Agustus";

                case 9:
                    return "September";

                case 10:
                    return "Oktober";

                case 11:
                    return "November";

                case 12:
                    return "Desember";

                default:
                    return null;
            }
        }
    }
}
