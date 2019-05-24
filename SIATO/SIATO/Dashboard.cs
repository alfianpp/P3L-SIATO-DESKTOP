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
    public partial class Dashboard : Form
    {
        private LoginForm _LoginForm;
        private Pegawai logged_in_user = null;

        public Dashboard(LoginForm _LoginForm, Pegawai logged_in_user)
        {
            InitializeComponent();
            this._LoginForm = _LoginForm;
            this.logged_in_user = logged_in_user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            clear_laporan();
            setAvailableTahunAndBulan();
            setAvailableTipeBarang();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            logout();
        }

        private void btnGoToPegawai_Click(object sender, EventArgs e)
        {
            PengelolaanDataPegawai pengelolaanDataPegawai = new PengelolaanDataPegawai();
            pengelolaanDataPegawai.api_key = logged_in_user.api_key;
            pengelolaanDataPegawai.Show();
        }

        private void btnGoToSpareparts_Click(object sender, EventArgs e)
        {
            PengelolaanDataSpareparts pengelolaanDataSpareparts = new PengelolaanDataSpareparts();
            pengelolaanDataSpareparts.api_key = logged_in_user.api_key;
            pengelolaanDataSpareparts.Show();
        }

        private void btnGoToJasaService_Click(object sender, EventArgs e)
        {
            PengelolaanJasaService pengelolaanJasaService = new PengelolaanJasaService();
            pengelolaanJasaService.api_key = logged_in_user.api_key;
            pengelolaanJasaService.Show();
        }

        private void btnGoToPengadaanBarang_Click(object sender, EventArgs e)
        {
            TransaksiPengadaanBarang transaksiPengadaanBarang = new TransaksiPengadaanBarang();
            transaksiPengadaanBarang.api_key = logged_in_user.api_key;
            transaksiPengadaanBarang.Show();
        }

        private void btnGoToPembayaran_Click(object sender, EventArgs e)
        {
            TransaksiPembayaran transaksiPembayaran = new TransaksiPembayaran();
            transaksiPembayaran.api_key = logged_in_user.api_key;
            transaksiPembayaran.Show();
        }

        private void rbLaporanSparepartsTerlaris_CheckedChanged(object sender, EventArgs e)
        {
            clear_laporan();
            cbLaporanTahun.Enabled = true;
            btnPrintLaporan.Enabled = true;
        }

        private void rbLaporanPendapatanBulanan_CheckedChanged(object sender, EventArgs e)
        {
            clear_laporan();
            cbLaporanTahun.Enabled = true;
            btnPrintLaporan.Enabled = true;
        }

        private void rbLaporanPendapatanTahunan_CheckedChanged(object sender, EventArgs e)
        {
            clear_laporan();
            btnPrintLaporan.Enabled = true;
        }

        private void rbLaporanPengeluaranBulanan_CheckedChanged(object sender, EventArgs e)
        {
            clear_laporan();
            cbLaporanTahun.Enabled = true;
            btnPrintLaporan.Enabled = true;
        }

        private void rbLaporanPenjualanJasa_CheckedChanged(object sender, EventArgs e)
        {
            clear_laporan();
            cbLaporanTahun.Enabled = true;
            cbLaporanBulan.Enabled = true;
            btnPrintLaporan.Enabled = true;
        }

        private void rbLaporanSisaStok_CheckedChanged(object sender, EventArgs e)
        {
            clear_laporan();
            cbLaporanTahun.Enabled = true;
            cbLaporanTipeBarang.Enabled = true;
            btnPrintLaporan.Enabled = true;
        }

        private void btnPrintLaporan_Click(object sender, EventArgs e)
        {
            if(rbLaporanSparepartsTerlaris.Checked)
            {
                LaporanView laporanView = new LaporanView(1);
                laporanView.tahun = Convert.ToInt32(cbLaporanTahun.GetItemText(cbLaporanTahun.SelectedItem));
                laporanView.api_key = logged_in_user.api_key;
                laporanView.Show();
            }
            else if(rbLaporanPendapatanBulanan.Checked)
            {
                LaporanView laporanView = new LaporanView(2);
                laporanView.tahun = Convert.ToInt32(cbLaporanTahun.GetItemText(cbLaporanTahun.SelectedItem));
                laporanView.api_key = logged_in_user.api_key;
                laporanView.Show();
            }
            else if (rbLaporanPendapatanTahunan.Checked)
            {
                LaporanView laporanView = new LaporanView(3);
                laporanView.api_key = logged_in_user.api_key;
                laporanView.Show();
            }
            else if (rbLaporanPengeluaranBulanan.Checked)
            {
                LaporanView laporanView = new LaporanView(4);
                laporanView.tahun = Convert.ToInt32(cbLaporanTahun.GetItemText(cbLaporanTahun.SelectedItem));
                laporanView.api_key = logged_in_user.api_key;
                laporanView.Show();
            }
            else if (rbLaporanPenjualanJasa.Checked)
            {
                LaporanView laporanView = new LaporanView(5);
                laporanView.tahun = Convert.ToInt32(cbLaporanTahun.GetItemText(cbLaporanTahun.SelectedItem));
                laporanView.bulan = Convert.ToInt32(cbLaporanBulan.SelectedValue.ToString());
                laporanView.api_key = logged_in_user.api_key;
                laporanView.Show();
            }
            else if (rbLaporanSisaStok.Checked)
            {
                LaporanView laporanView = new LaporanView(6);
                laporanView.tahun = Convert.ToInt32(cbLaporanTahun.GetItemText(cbLaporanTahun.SelectedItem));
                laporanView.tipe_barang = cbLaporanTipeBarang.GetItemText(cbLaporanTipeBarang.SelectedItem);
                laporanView.api_key = logged_in_user.api_key;
                laporanView.Show();
            }
        }

        private void logout()
        {
            logged_in_user = null;
            _LoginForm.Show();
        }

        private void clear_laporan()
        {
            cbLaporanTahun.Enabled = false;
            cbLaporanBulan.Enabled = false;
            cbLaporanTipeBarang.Enabled = false;
            btnPrintLaporan.Enabled = false;
        }

        private void setAvailableTahunAndBulan()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/transaksi/penjualan/index/tgl_transaksi", Method.GET);
            var response = client.Execute<APIResponse<List<string>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                List<string> availableTahun = new List<string>();
                List<object> availableBulan = new List<object>();

                foreach(string tgl_transaksi in apiResponse.data)
                {
                    DateTime dt = Convert.ToDateTime(tgl_transaksi);

                    if(!availableTahun.Contains(dt.Year.ToString()))
                    {
                        availableTahun.Add(dt.Year.ToString());
                    }

                    if(!availableBulan.Contains(dt.ToString("MMMM")))
                    {
                        availableBulan.Add(new {
                            Text = dt.ToString("MMMM"),
                            Value = dt.Month
                        });
                    }
                }

                cbLaporanTahun.DataSource = availableTahun;

                cbLaporanBulan.DisplayMember = "Text";
                cbLaporanBulan.ValueMember = "Value";
                cbLaporanBulan.DataSource = availableBulan;
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void setAvailableTipeBarang()
        {
            var client = new RestClient(Settings.URL);
            var request = new RestRequest("api/data/spareparts/index/tipe", Method.GET);
            var response = client.Execute<APIResponse<List<string>>>(request);

            var apiResponse = response.Data;
            if (!apiResponse.error)
            {
                cbLaporanTipeBarang.DataSource = apiResponse.data;
            }
            else
            {
                MessageBox.Show(apiResponse.message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
