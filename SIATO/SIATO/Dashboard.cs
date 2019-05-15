using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIATO
{
    public partial class Dashboard : Form
    {
        private LoginForm _LoginForm;
        private Pegawai logged_in_user;

        public Dashboard(LoginForm _LoginForm, Pegawai logged_in_user)
        {
            InitializeComponent();
            this._LoginForm = _LoginForm;
            this.logged_in_user = logged_in_user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            _LoginForm.Show();
        }

        private void btnGoToJasaService_Click(object sender, EventArgs e)
        {
            PengelolaanJasaService pengelolaanJasaService = new PengelolaanJasaService(logged_in_user.api_key);
            pengelolaanJasaService.Show();
        }

        private void btnGoToPembayaran_Click(object sender, EventArgs e)
        {
            PembayaranForm pembayaran = new PembayaranForm(logged_in_user.api_key);
            pembayaran.Show();
        }

   
        private void btnGoToLaporanSparepartsTerlaris_Click(object sender, EventArgs e)
        {
            LaporanView laporanView = new LaporanView(1, Convert.ToInt32(textBox1.Text));
            laporanView.Show();
        }

        private void btnGoToLaporanPendapatanBulanan_Click(object sender, EventArgs e)
        {
            LaporanView laporanView = new LaporanView(2, Convert.ToInt32(textBox1.Text));
            laporanView.Show();
        }

        private void btnGoToLaporanPendapatanTahunan_Click(object sender, EventArgs e)
        {
            LaporanView laporanView = new LaporanView(3, Convert.ToInt32(textBox1.Text));
            laporanView.Show();
        }

        private void btnGoToLaporanPengeluaranBulanan_Click(object sender, EventArgs e)
        {
            LaporanView laporanView = new LaporanView(4, Convert.ToInt32(textBox1.Text));
            laporanView.Show();
        }

        private void btnGoToLaporanPenjualanJasa_Click(object sender, EventArgs e)
        {
            LaporanView laporanView = new LaporanView(5, Convert.ToInt32(textBox1.Text));
            laporanView.Show();
        }

        private void btnGoToLaporanSisaStok_Click(object sender, EventArgs e)
        {
            LaporanView laporanView = new LaporanView(6, Convert.ToInt32(textBox1.Text));
            laporanView.Show();
        }

        private void btnGoToPegawai_Click(object sender, EventArgs e)
        {
            PengelolaanDataPegawai pengelolaanDataPegawai = new PengelolaanDataPegawai(logged_in_user.api_key);
            pengelolaanDataPegawai.Show();
        }
    }
}
