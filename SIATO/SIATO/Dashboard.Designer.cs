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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGoToJasaService = new System.Windows.Forms.Button();
            this.btnGoToLaporanPendapatanBulanan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoToLaporanSisaStok = new System.Windows.Forms.Button();
            this.btnGoToLaporanPenjualanJasa = new System.Windows.Forms.Button();
            this.btnGoToLaporanPengeluaranBulanan = new System.Windows.Forms.Button();
            this.btnGoToLaporanPendapatanTahunan = new System.Windows.Forms.Button();
            this.btnGoToLaporanSparepartsTerlaris = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGoToPembayaran = new System.Windows.Forms.Button();
            this.btnGoToPegawai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(713, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGoToJasaService
            // 
            this.btnGoToJasaService.Location = new System.Drawing.Point(35, 79);
            this.btnGoToJasaService.Name = "btnGoToJasaService";
            this.btnGoToJasaService.Size = new System.Drawing.Size(91, 23);
            this.btnGoToJasaService.TabIndex = 1;
            this.btnGoToJasaService.Text = "Jasa Service";
            this.btnGoToJasaService.UseVisualStyleBackColor = true;
            this.btnGoToJasaService.Click += new System.EventHandler(this.btnGoToJasaService_Click);
            // 
            // btnGoToLaporanPendapatanBulanan
            // 
            this.btnGoToLaporanPendapatanBulanan.Location = new System.Drawing.Point(6, 48);
            this.btnGoToLaporanPendapatanBulanan.Name = "btnGoToLaporanPendapatanBulanan";
            this.btnGoToLaporanPendapatanBulanan.Size = new System.Drawing.Size(134, 23);
            this.btnGoToLaporanPendapatanBulanan.TabIndex = 2;
            this.btnGoToLaporanPendapatanBulanan.Text = "Pendapatan Bulanan";
            this.btnGoToLaporanPendapatanBulanan.UseVisualStyleBackColor = true;
            this.btnGoToLaporanPendapatanBulanan.Click += new System.EventHandler(this.btnGoToLaporanPendapatanBulanan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGoToLaporanSisaStok);
            this.groupBox1.Controls.Add(this.btnGoToLaporanPenjualanJasa);
            this.groupBox1.Controls.Add(this.btnGoToLaporanPengeluaranBulanan);
            this.groupBox1.Controls.Add(this.btnGoToLaporanPendapatanTahunan);
            this.groupBox1.Controls.Add(this.btnGoToLaporanSparepartsTerlaris);
            this.groupBox1.Controls.Add(this.btnGoToLaporanPendapatanBulanan);
            this.groupBox1.Location = new System.Drawing.Point(493, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laporan";
            // 
            // btnGoToLaporanSisaStok
            // 
            this.btnGoToLaporanSisaStok.Location = new System.Drawing.Point(6, 164);
            this.btnGoToLaporanSisaStok.Name = "btnGoToLaporanSisaStok";
            this.btnGoToLaporanSisaStok.Size = new System.Drawing.Size(134, 23);
            this.btnGoToLaporanSisaStok.TabIndex = 7;
            this.btnGoToLaporanSisaStok.Text = "Sisa Stok";
            this.btnGoToLaporanSisaStok.UseVisualStyleBackColor = true;
            this.btnGoToLaporanSisaStok.Click += new System.EventHandler(this.btnGoToLaporanSisaStok_Click);
            // 
            // btnGoToLaporanPenjualanJasa
            // 
            this.btnGoToLaporanPenjualanJasa.Location = new System.Drawing.Point(6, 135);
            this.btnGoToLaporanPenjualanJasa.Name = "btnGoToLaporanPenjualanJasa";
            this.btnGoToLaporanPenjualanJasa.Size = new System.Drawing.Size(134, 23);
            this.btnGoToLaporanPenjualanJasa.TabIndex = 6;
            this.btnGoToLaporanPenjualanJasa.Text = "Penjualan Jasa";
            this.btnGoToLaporanPenjualanJasa.UseVisualStyleBackColor = true;
            this.btnGoToLaporanPenjualanJasa.Click += new System.EventHandler(this.btnGoToLaporanPenjualanJasa_Click);
            // 
            // btnGoToLaporanPengeluaranBulanan
            // 
            this.btnGoToLaporanPengeluaranBulanan.Location = new System.Drawing.Point(6, 106);
            this.btnGoToLaporanPengeluaranBulanan.Name = "btnGoToLaporanPengeluaranBulanan";
            this.btnGoToLaporanPengeluaranBulanan.Size = new System.Drawing.Size(134, 23);
            this.btnGoToLaporanPengeluaranBulanan.TabIndex = 5;
            this.btnGoToLaporanPengeluaranBulanan.Text = "Pengeluaran Bulanan";
            this.btnGoToLaporanPengeluaranBulanan.UseVisualStyleBackColor = true;
            this.btnGoToLaporanPengeluaranBulanan.Click += new System.EventHandler(this.btnGoToLaporanPengeluaranBulanan_Click);
            // 
            // btnGoToLaporanPendapatanTahunan
            // 
            this.btnGoToLaporanPendapatanTahunan.Location = new System.Drawing.Point(6, 77);
            this.btnGoToLaporanPendapatanTahunan.Name = "btnGoToLaporanPendapatanTahunan";
            this.btnGoToLaporanPendapatanTahunan.Size = new System.Drawing.Size(134, 23);
            this.btnGoToLaporanPendapatanTahunan.TabIndex = 4;
            this.btnGoToLaporanPendapatanTahunan.Text = "Pendapatan Tahunan";
            this.btnGoToLaporanPendapatanTahunan.UseVisualStyleBackColor = true;
            this.btnGoToLaporanPendapatanTahunan.Click += new System.EventHandler(this.btnGoToLaporanPendapatanTahunan_Click);
            // 
            // btnGoToLaporanSparepartsTerlaris
            // 
            this.btnGoToLaporanSparepartsTerlaris.Location = new System.Drawing.Point(6, 19);
            this.btnGoToLaporanSparepartsTerlaris.Name = "btnGoToLaporanSparepartsTerlaris";
            this.btnGoToLaporanSparepartsTerlaris.Size = new System.Drawing.Size(134, 23);
            this.btnGoToLaporanSparepartsTerlaris.TabIndex = 3;
            this.btnGoToLaporanSparepartsTerlaris.Text = "Spareparts Terlaris";
            this.btnGoToLaporanSparepartsTerlaris.UseVisualStyleBackColor = true;
            this.btnGoToLaporanSparepartsTerlaris.Click += new System.EventHandler(this.btnGoToLaporanSparepartsTerlaris_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnGoToPembayaran
            // 
            this.btnGoToPembayaran.Location = new System.Drawing.Point(35, 202);
            this.btnGoToPembayaran.Name = "btnGoToPembayaran";
            this.btnGoToPembayaran.Size = new System.Drawing.Size(91, 23);
            this.btnGoToPembayaran.TabIndex = 5;
            this.btnGoToPembayaran.Text = "Pembayaran";
            this.btnGoToPembayaran.UseVisualStyleBackColor = true;
            this.btnGoToPembayaran.Click += new System.EventHandler(this.btnGoToPembayaran_Click);
            // 
            // btnGoToPegawai
            // 
            this.btnGoToPegawai.Location = new System.Drawing.Point(35, 116);
            this.btnGoToPegawai.Name = "btnGoToPegawai";
            this.btnGoToPegawai.Size = new System.Drawing.Size(91, 23);
            this.btnGoToPegawai.TabIndex = 6;
            this.btnGoToPegawai.Text = "Pegawai";
            this.btnGoToPegawai.UseVisualStyleBackColor = true;
            this.btnGoToPegawai.Click += new System.EventHandler(this.btnGoToPegawai_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToPegawai);
            this.Controls.Add(this.btnGoToPembayaran);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGoToJasaService);
            this.Controls.Add(this.btnLogout);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGoToJasaService;
        private System.Windows.Forms.Button btnGoToLaporanPendapatanBulanan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGoToLaporanSisaStok;
        private System.Windows.Forms.Button btnGoToLaporanPenjualanJasa;
        private System.Windows.Forms.Button btnGoToLaporanPengeluaranBulanan;
        private System.Windows.Forms.Button btnGoToLaporanPendapatanTahunan;
        private System.Windows.Forms.Button btnGoToLaporanSparepartsTerlaris;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGoToPembayaran;
        private System.Windows.Forms.Button btnGoToPegawai;
    }
}