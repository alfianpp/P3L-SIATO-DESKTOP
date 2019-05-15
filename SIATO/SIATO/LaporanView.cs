using RestSharp;
using CrystalDecisions.CrystalReports.Engine;
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
using SIATO.CrystalReport;

namespace SIATO
{
    public partial class LaporanView : Form
    {
        private string url = "http://127.0.0.1:8000/api/";
        private int type;
        private int tahun;
        private int bulan = 5;
        private string tipe_barang = "Roda";

        private ReportClass laporan;
        private string judul;

        public LaporanView(int type, int tahun)
        {
            InitializeComponent();
            this.type = type;
            this.tahun = tahun;

            switch (type)
            {
                case 1:
                    laporan = new SparepartsTerlaris();
                    judul = "Spareparts Terlaris";
                    break;

                case 2:
                    laporan = new PendapatanBulanan();
                    judul = "Pendapatan Bulanan";
                    break;

                case 3:
                    laporan = new PendapatanTahunan();
                    judul = "Pendapatan Tahunan";
                    break;

                case 4:
                    laporan = new PengeluaranBulanan();
                    judul = "Pendapatan Bulanan";
                    break;

                case 5:
                    laporan = new PenjualanJasa();
                    judul = "Penjualan Jasa";
                    break;

                case 6:
                    laporan = new SisaStok();
                    judul = "Sisa Stok";
                    break;
            }

            this.Text = "SIATO - Laporan " + judul;
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case 1:
                    getLaporanSparepartsTerlaris(tahun);
                    break;

                case 2:
                    getLaporanPendapatanBulanan(tahun);
                    break;

                case 3:
                    getLaporanPendapatanTahunan();
                    break;

                case 4:
                    getLaporanPengeluaranBulanan(tahun);
                    break;

                case 5:
                    getLaporanPenjualanJasa(tahun, bulan);
                    break;

                case 6:
                    getLaporanSisaStok(tahun, tipe_barang);
                    break;
            }

            if (type != 3)
            {
                laporan.SetParameterValue("TahunParameter", tahun);
            }

            if (type == 5)
            {
                laporan.SetParameterValue("BulanParameter", getMonthName(5));
            }

            if (type == 6)
            {
                laporan.SetParameterValue("TipeBarangParameter", "Roda");
            }

            crystalReportViewer.ReportSource = laporan;
        }

        private void getLaporanSparepartsTerlaris(int tahun)
        {
            var client = new RestClient(url);
            var request = new RestRequest("laporan/spareparts_terlaris", Method.POST);
            request.AddParameter("tahun", tahun);
            var response = client.Execute<APIResponse<List<LaporanSparepartsTerlaris>>>(request);
            if (!response.Data.error)
            {
                for (int i = 0; i < response.Data.data.Count; i++)
                {
                    response.Data.data[i].bulan = getMonthName(Convert.ToInt32(response.Data.data[i].bulan));
                }
                laporan.Database.Tables["spareparts_terlaris"].SetDataSource(response.Data.data);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void getLaporanPendapatanBulanan(int tahun)
        {
            var client = new RestClient(url);
            var request = new RestRequest("laporan/pendapatan_bulanan", Method.POST);
            request.AddParameter("tahun", tahun);
            var response = client.Execute<APIResponse<List<LaporanPendapatanBulanan>>>(request);
            if (!response.Data.error)
            {
                for (int i=0; i<response.Data.data.Count; i++)
                {
                    response.Data.data[i].bulan = getMonthName(Convert.ToInt32(response.Data.data[i].bulan));
                }
                laporan.Database.Tables["pendapatan_bulanan"].SetDataSource(response.Data.data);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void getLaporanPendapatanTahunan()
        {
            var client = new RestClient(url);
            var request = new RestRequest("laporan/pendapatan_tahunan", Method.POST);
            var response = client.Execute<APIResponse<List<LaporanPendapatanTahunan>>>(request);
            if (!response.Data.error)
            {
                laporan.Database.Tables["pendapatan_tahunan"].SetDataSource(response.Data.data);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void getLaporanPengeluaranBulanan(int tahun)
        {
            var client = new RestClient(url);
            var request = new RestRequest("laporan/pengeluaran_bulanan", Method.POST);
            request.AddParameter("tahun", tahun);
            var response = client.Execute<APIResponse<List<LaporanPengeluaranBulanan>>>(request);
            if (!response.Data.error)
            {
                for (int i = 0; i < response.Data.data.Count; i++)
                {
                    response.Data.data[i].bulan = getMonthName(Convert.ToInt32(response.Data.data[i].bulan));
                }
                laporan.Database.Tables["pengeluaran_bulanan"].SetDataSource(response.Data.data);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void getLaporanPenjualanJasa(int tahun, int bulan)
        {
            var client = new RestClient(url);
            var request = new RestRequest("laporan/penjualan_jasa", Method.POST);
            request.AddParameter("tahun", tahun);
            request.AddParameter("bulan", bulan);
            var response = client.Execute<APIResponse<List<LaporanPenjualanJasa>>>(request);
            if (!response.Data.error)
            {
                laporan.Database.Tables["penjualan_jasa"].SetDataSource(response.Data.data);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void getLaporanSisaStok(int tahun, string tipe_barang)
        {
            var client = new RestClient(url);
            var request = new RestRequest("laporan/sisa_stok", Method.POST);
            request.AddParameter("tahun", tahun);
            request.AddParameter("tipe_barang", tipe_barang);
            var response = client.Execute<APIResponse<List<LaporanSisaStok>>>(request);
            if (!response.Data.error)
            {
                for (int i = 0; i < response.Data.data.Count; i++)
                {
                    response.Data.data[i].bulan = getMonthName(Convert.ToInt32(response.Data.data[i].bulan));
                }
                laporan.Database.Tables["sisa_stok"].SetDataSource(response.Data.data);
            }
            else
            {
                MessageBox.Show(response.Data.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string getMonthName(int number)
        {
            string name = "";

            switch (number)
            {
                case 1:
                    name = "Januari";
                    break;

                case 2:
                    name = "Februari";
                    break;

                case 3:
                    name = "Maret";
                    break;

                case 4:
                    name = "April";
                    break;

                case 5:
                    name = "Mei";
                    break;

                case 6:
                    name = "Juni";
                    break;

                case 7:
                    name = "Juli";
                    break;

                case 8:
                    name = "Agustus";
                    break;

                case 9:
                    name = "September";
                    break;

                case 10:
                    name = "Oktober";
                    break;

                case 11:
                    name = "November";
                    break;

                case 12:
                    name = "Desember";
                    break;
            }

            return name;
        }
    }
}
