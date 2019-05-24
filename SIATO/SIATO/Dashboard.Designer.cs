namespace SIATO
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGoToJasaService = new System.Windows.Forms.Button();
            this.btnGoToPembayaran = new System.Windows.Forms.Button();
            this.btnGoToPegawai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGoToSpareparts = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGoToPengadaanBarang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbLaporan = new System.Windows.Forms.GroupBox();
            this.rbLaporanSparepartsTerlaris = new System.Windows.Forms.RadioButton();
            this.rbLaporanPendapatanBulanan = new System.Windows.Forms.RadioButton();
            this.rbLaporanPendapatanTahunan = new System.Windows.Forms.RadioButton();
            this.rbLaporanPengeluaranBulanan = new System.Windows.Forms.RadioButton();
            this.rbLaporanPenjualanJasa = new System.Windows.Forms.RadioButton();
            this.rbLaporanSisaStok = new System.Windows.Forms.RadioButton();
            this.btnPrintLaporan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLaporanTahun = new System.Windows.Forms.ComboBox();
            this.cbLaporanBulan = new System.Windows.Forms.ComboBox();
            this.cbLaporanTipeBarang = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbLaporan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoToJasaService
            // 
            this.btnGoToJasaService.Location = new System.Drawing.Point(6, 77);
            this.btnGoToJasaService.Name = "btnGoToJasaService";
            this.btnGoToJasaService.Size = new System.Drawing.Size(129, 23);
            this.btnGoToJasaService.TabIndex = 1;
            this.btnGoToJasaService.Text = "Jasa Service";
            this.btnGoToJasaService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToJasaService.UseVisualStyleBackColor = true;
            this.btnGoToJasaService.Click += new System.EventHandler(this.btnGoToJasaService_Click);
            // 
            // btnGoToPembayaran
            // 
            this.btnGoToPembayaran.Location = new System.Drawing.Point(6, 48);
            this.btnGoToPembayaran.Name = "btnGoToPembayaran";
            this.btnGoToPembayaran.Size = new System.Drawing.Size(129, 23);
            this.btnGoToPembayaran.TabIndex = 5;
            this.btnGoToPembayaran.Text = "Pembayaran";
            this.btnGoToPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToPembayaran.UseVisualStyleBackColor = true;
            this.btnGoToPembayaran.Click += new System.EventHandler(this.btnGoToPembayaran_Click);
            // 
            // btnGoToPegawai
            // 
            this.btnGoToPegawai.Location = new System.Drawing.Point(6, 19);
            this.btnGoToPegawai.Name = "btnGoToPegawai";
            this.btnGoToPegawai.Size = new System.Drawing.Size(129, 23);
            this.btnGoToPegawai.TabIndex = 6;
            this.btnGoToPegawai.Text = "Pegawai";
            this.btnGoToPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToPegawai.UseVisualStyleBackColor = true;
            this.btnGoToPegawai.Click += new System.EventHandler(this.btnGoToPegawai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGoToJasaService);
            this.groupBox2.Controls.Add(this.btnGoToPegawai);
            this.groupBox2.Controls.Add(this.btnGoToSpareparts);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 106);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pengelolaan Data";
            // 
            // btnGoToSpareparts
            // 
            this.btnGoToSpareparts.Location = new System.Drawing.Point(6, 48);
            this.btnGoToSpareparts.Name = "btnGoToSpareparts";
            this.btnGoToSpareparts.Size = new System.Drawing.Size(129, 23);
            this.btnGoToSpareparts.TabIndex = 7;
            this.btnGoToSpareparts.Text = "Spareparts";
            this.btnGoToSpareparts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToSpareparts.UseVisualStyleBackColor = true;
            this.btnGoToSpareparts.Click += new System.EventHandler(this.btnGoToSpareparts_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGoToPengadaanBarang);
            this.groupBox3.Controls.Add(this.btnGoToPembayaran);
            this.groupBox3.Location = new System.Drawing.Point(12, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 78);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaksi";
            // 
            // btnGoToPengadaanBarang
            // 
            this.btnGoToPengadaanBarang.Location = new System.Drawing.Point(6, 19);
            this.btnGoToPengadaanBarang.Name = "btnGoToPengadaanBarang";
            this.btnGoToPengadaanBarang.Size = new System.Drawing.Size(129, 23);
            this.btnGoToPengadaanBarang.TabIndex = 12;
            this.btnGoToPengadaanBarang.Text = "Pengadaan Barang";
            this.btnGoToPengadaanBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToPengadaanBarang.UseVisualStyleBackColor = true;
            this.btnGoToPengadaanBarang.Click += new System.EventHandler(this.btnGoToPengadaanBarang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tahun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bulan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipe Barang";
            // 
            // gbLaporan
            // 
            this.gbLaporan.Controls.Add(this.cbLaporanTipeBarang);
            this.gbLaporan.Controls.Add(this.cbLaporanBulan);
            this.gbLaporan.Controls.Add(this.cbLaporanTahun);
            this.gbLaporan.Controls.Add(this.label4);
            this.gbLaporan.Controls.Add(this.btnPrintLaporan);
            this.gbLaporan.Controls.Add(this.rbLaporanSisaStok);
            this.gbLaporan.Controls.Add(this.label3);
            this.gbLaporan.Controls.Add(this.rbLaporanPenjualanJasa);
            this.gbLaporan.Controls.Add(this.label2);
            this.gbLaporan.Controls.Add(this.rbLaporanPengeluaranBulanan);
            this.gbLaporan.Controls.Add(this.label1);
            this.gbLaporan.Controls.Add(this.rbLaporanPendapatanTahunan);
            this.gbLaporan.Controls.Add(this.rbLaporanPendapatanBulanan);
            this.gbLaporan.Controls.Add(this.rbLaporanSparepartsTerlaris);
            this.gbLaporan.Location = new System.Drawing.Point(12, 211);
            this.gbLaporan.Name = "gbLaporan";
            this.gbLaporan.Size = new System.Drawing.Size(347, 185);
            this.gbLaporan.TabIndex = 17;
            this.gbLaporan.TabStop = false;
            this.gbLaporan.Text = "Laporan";
            // 
            // rbLaporanSparepartsTerlaris
            // 
            this.rbLaporanSparepartsTerlaris.AutoSize = true;
            this.rbLaporanSparepartsTerlaris.Location = new System.Drawing.Point(6, 42);
            this.rbLaporanSparepartsTerlaris.Name = "rbLaporanSparepartsTerlaris";
            this.rbLaporanSparepartsTerlaris.Size = new System.Drawing.Size(113, 17);
            this.rbLaporanSparepartsTerlaris.TabIndex = 0;
            this.rbLaporanSparepartsTerlaris.TabStop = true;
            this.rbLaporanSparepartsTerlaris.Text = "Spareparts Terlaris";
            this.rbLaporanSparepartsTerlaris.UseVisualStyleBackColor = true;
            this.rbLaporanSparepartsTerlaris.CheckedChanged += new System.EventHandler(this.rbLaporanSparepartsTerlaris_CheckedChanged);
            // 
            // rbLaporanPendapatanBulanan
            // 
            this.rbLaporanPendapatanBulanan.AutoSize = true;
            this.rbLaporanPendapatanBulanan.Location = new System.Drawing.Point(6, 65);
            this.rbLaporanPendapatanBulanan.Name = "rbLaporanPendapatanBulanan";
            this.rbLaporanPendapatanBulanan.Size = new System.Drawing.Size(125, 17);
            this.rbLaporanPendapatanBulanan.TabIndex = 1;
            this.rbLaporanPendapatanBulanan.TabStop = true;
            this.rbLaporanPendapatanBulanan.Text = "Pendapatan Bulanan";
            this.rbLaporanPendapatanBulanan.UseVisualStyleBackColor = true;
            this.rbLaporanPendapatanBulanan.CheckedChanged += new System.EventHandler(this.rbLaporanPendapatanBulanan_CheckedChanged);
            // 
            // rbLaporanPendapatanTahunan
            // 
            this.rbLaporanPendapatanTahunan.AutoSize = true;
            this.rbLaporanPendapatanTahunan.Location = new System.Drawing.Point(6, 88);
            this.rbLaporanPendapatanTahunan.Name = "rbLaporanPendapatanTahunan";
            this.rbLaporanPendapatanTahunan.Size = new System.Drawing.Size(129, 17);
            this.rbLaporanPendapatanTahunan.TabIndex = 2;
            this.rbLaporanPendapatanTahunan.TabStop = true;
            this.rbLaporanPendapatanTahunan.Text = "Pendapatan Tahunan";
            this.rbLaporanPendapatanTahunan.UseVisualStyleBackColor = true;
            this.rbLaporanPendapatanTahunan.CheckedChanged += new System.EventHandler(this.rbLaporanPendapatanTahunan_CheckedChanged);
            // 
            // rbLaporanPengeluaranBulanan
            // 
            this.rbLaporanPengeluaranBulanan.AutoSize = true;
            this.rbLaporanPengeluaranBulanan.Location = new System.Drawing.Point(6, 111);
            this.rbLaporanPengeluaranBulanan.Name = "rbLaporanPengeluaranBulanan";
            this.rbLaporanPengeluaranBulanan.Size = new System.Drawing.Size(127, 17);
            this.rbLaporanPengeluaranBulanan.TabIndex = 3;
            this.rbLaporanPengeluaranBulanan.TabStop = true;
            this.rbLaporanPengeluaranBulanan.Text = "Pengeluaran Bulanan";
            this.rbLaporanPengeluaranBulanan.UseVisualStyleBackColor = true;
            this.rbLaporanPengeluaranBulanan.CheckedChanged += new System.EventHandler(this.rbLaporanPengeluaranBulanan_CheckedChanged);
            // 
            // rbLaporanPenjualanJasa
            // 
            this.rbLaporanPenjualanJasa.AutoSize = true;
            this.rbLaporanPenjualanJasa.Location = new System.Drawing.Point(6, 134);
            this.rbLaporanPenjualanJasa.Name = "rbLaporanPenjualanJasa";
            this.rbLaporanPenjualanJasa.Size = new System.Drawing.Size(97, 17);
            this.rbLaporanPenjualanJasa.TabIndex = 4;
            this.rbLaporanPenjualanJasa.TabStop = true;
            this.rbLaporanPenjualanJasa.Text = "Penjualan Jasa";
            this.rbLaporanPenjualanJasa.UseVisualStyleBackColor = true;
            this.rbLaporanPenjualanJasa.CheckedChanged += new System.EventHandler(this.rbLaporanPenjualanJasa_CheckedChanged);
            // 
            // rbLaporanSisaStok
            // 
            this.rbLaporanSisaStok.AutoSize = true;
            this.rbLaporanSisaStok.Location = new System.Drawing.Point(6, 157);
            this.rbLaporanSisaStok.Name = "rbLaporanSisaStok";
            this.rbLaporanSisaStok.Size = new System.Drawing.Size(70, 17);
            this.rbLaporanSisaStok.TabIndex = 5;
            this.rbLaporanSisaStok.TabStop = true;
            this.rbLaporanSisaStok.Text = "Sisa Stok";
            this.rbLaporanSisaStok.UseVisualStyleBackColor = true;
            this.rbLaporanSisaStok.CheckedChanged += new System.EventHandler(this.rbLaporanSisaStok_CheckedChanged);
            // 
            // btnPrintLaporan
            // 
            this.btnPrintLaporan.Location = new System.Drawing.Point(264, 154);
            this.btnPrintLaporan.Name = "btnPrintLaporan";
            this.btnPrintLaporan.Size = new System.Drawing.Size(75, 23);
            this.btnPrintLaporan.TabIndex = 17;
            this.btnPrintLaporan.Text = "Print";
            this.btnPrintLaporan.UseVisualStyleBackColor = true;
            this.btnPrintLaporan.Click += new System.EventHandler(this.btnPrintLaporan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pilih laporan:";
            // 
            // cbLaporanTahun
            // 
            this.cbLaporanTahun.FormattingEnabled = true;
            this.cbLaporanTahun.Location = new System.Drawing.Point(239, 18);
            this.cbLaporanTahun.Name = "cbLaporanTahun";
            this.cbLaporanTahun.Size = new System.Drawing.Size(100, 21);
            this.cbLaporanTahun.TabIndex = 18;
            // 
            // cbLaporanBulan
            // 
            this.cbLaporanBulan.FormattingEnabled = true;
            this.cbLaporanBulan.Location = new System.Drawing.Point(239, 46);
            this.cbLaporanBulan.Name = "cbLaporanBulan";
            this.cbLaporanBulan.Size = new System.Drawing.Size(100, 21);
            this.cbLaporanBulan.TabIndex = 18;
            // 
            // cbLaporanTipeBarang
            // 
            this.cbLaporanTipeBarang.FormattingEnabled = true;
            this.cbLaporanTipeBarang.Location = new System.Drawing.Point(239, 75);
            this.cbLaporanTipeBarang.Name = "cbLaporanTipeBarang";
            this.cbLaporanTipeBarang.Size = new System.Drawing.Size(100, 21);
            this.cbLaporanTipeBarang.TabIndex = 18;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.gbLaporan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbLaporan.ResumeLayout(false);
            this.gbLaporan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGoToJasaService;
        private System.Windows.Forms.Button btnGoToPembayaran;
        private System.Windows.Forms.Button btnGoToPegawai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGoToSpareparts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGoToPengadaanBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbLaporan;
        private System.Windows.Forms.RadioButton rbLaporanPendapatanBulanan;
        private System.Windows.Forms.RadioButton rbLaporanSparepartsTerlaris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrintLaporan;
        private System.Windows.Forms.RadioButton rbLaporanSisaStok;
        private System.Windows.Forms.RadioButton rbLaporanPenjualanJasa;
        private System.Windows.Forms.RadioButton rbLaporanPengeluaranBulanan;
        private System.Windows.Forms.RadioButton rbLaporanPendapatanTahunan;
        private System.Windows.Forms.ComboBox cbLaporanTahun;
        private System.Windows.Forms.ComboBox cbLaporanBulan;
        private System.Windows.Forms.ComboBox cbLaporanTipeBarang;
    }
}