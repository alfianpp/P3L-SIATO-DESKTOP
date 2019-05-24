namespace SIATO
{
    partial class TransaksiPembayaran
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
            this.dataGridViewPembayaran = new System.Windows.Forms.DataGridView();
            this.dataGridViewPembayaranDetailSpareparts = new System.Windows.Forms.DataGridView();
            this.dataGridViewPembayaranDetailJasaService = new System.Windows.Forms.DataGridView();
            this.tbPembayaranDiskon = new System.Windows.Forms.TextBox();
            this.tbPembayaranUangDiterima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPembayaranSubtotal = new System.Windows.Forms.Label();
            this.lblPembayaranTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCariPenjualan = new System.Windows.Forms.TextBox();
            this.btnBatalPembayaran = new System.Windows.Forms.Button();
            this.btnBayarPembayaran = new System.Windows.Forms.Button();
            this.btnPrintNotaLunas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranDetailSpareparts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranDetailJasaService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPembayaran
            // 
            this.dataGridViewPembayaran.AllowUserToAddRows = false;
            this.dataGridViewPembayaran.AllowUserToDeleteRows = false;
            this.dataGridViewPembayaran.AllowUserToResizeRows = false;
            this.dataGridViewPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPembayaran.Location = new System.Drawing.Point(393, 38);
            this.dataGridViewPembayaran.MultiSelect = false;
            this.dataGridViewPembayaran.Name = "dataGridViewPembayaran";
            this.dataGridViewPembayaran.ReadOnly = true;
            this.dataGridViewPembayaran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPembayaran.Size = new System.Drawing.Size(425, 483);
            this.dataGridViewPembayaran.TabIndex = 0;
            this.dataGridViewPembayaran.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPembayaran_RowHeaderMouseDoubleClick);
            // 
            // dataGridViewPembayaranDetailSpareparts
            // 
            this.dataGridViewPembayaranDetailSpareparts.AllowUserToAddRows = false;
            this.dataGridViewPembayaranDetailSpareparts.AllowUserToDeleteRows = false;
            this.dataGridViewPembayaranDetailSpareparts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPembayaranDetailSpareparts.Location = new System.Drawing.Point(12, 228);
            this.dataGridViewPembayaranDetailSpareparts.Name = "dataGridViewPembayaranDetailSpareparts";
            this.dataGridViewPembayaranDetailSpareparts.ReadOnly = true;
            this.dataGridViewPembayaranDetailSpareparts.Size = new System.Drawing.Size(375, 128);
            this.dataGridViewPembayaranDetailSpareparts.TabIndex = 2;
            // 
            // dataGridViewPembayaranDetailJasaService
            // 
            this.dataGridViewPembayaranDetailJasaService.AllowUserToAddRows = false;
            this.dataGridViewPembayaranDetailJasaService.AllowUserToDeleteRows = false;
            this.dataGridViewPembayaranDetailJasaService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPembayaranDetailJasaService.Location = new System.Drawing.Point(12, 393);
            this.dataGridViewPembayaranDetailJasaService.Name = "dataGridViewPembayaranDetailJasaService";
            this.dataGridViewPembayaranDetailJasaService.ReadOnly = true;
            this.dataGridViewPembayaranDetailJasaService.Size = new System.Drawing.Size(375, 128);
            this.dataGridViewPembayaranDetailJasaService.TabIndex = 3;
            // 
            // tbPembayaranDiskon
            // 
            this.tbPembayaranDiskon.Location = new System.Drawing.Point(171, 59);
            this.tbPembayaranDiskon.Name = "tbPembayaranDiskon";
            this.tbPembayaranDiskon.Size = new System.Drawing.Size(216, 20);
            this.tbPembayaranDiskon.TabIndex = 8;
            this.tbPembayaranDiskon.TextChanged += new System.EventHandler(this.tbPembayaranDiskon_TextChanged);
            // 
            // tbPembayaranUangDiterima
            // 
            this.tbPembayaranUangDiterima.Location = new System.Drawing.Point(171, 108);
            this.tbPembayaranUangDiterima.Name = "tbPembayaranUangDiterima";
            this.tbPembayaranUangDiterima.Size = new System.Drawing.Size(216, 20);
            this.tbPembayaranUangDiterima.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Diskon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Uang diterima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Detail Pembelian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Spareparts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Jasa Service";
            // 
            // lblPembayaranSubtotal
            // 
            this.lblPembayaranSubtotal.AutoSize = true;
            this.lblPembayaranSubtotal.Location = new System.Drawing.Point(168, 38);
            this.lblPembayaranSubtotal.Name = "lblPembayaranSubtotal";
            this.lblPembayaranSubtotal.Size = new System.Drawing.Size(52, 13);
            this.lblPembayaranSubtotal.TabIndex = 15;
            this.lblPembayaranSubtotal.Text = "{subtotal}";
            // 
            // lblPembayaranTotal
            // 
            this.lblPembayaranTotal.AutoSize = true;
            this.lblPembayaranTotal.Location = new System.Drawing.Point(168, 87);
            this.lblPembayaranTotal.Name = "lblPembayaranTotal";
            this.lblPembayaranTotal.Size = new System.Drawing.Size(35, 13);
            this.lblPembayaranTotal.TabIndex = 16;
            this.lblPembayaranTotal.Text = "{total}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Jumlah yang harus dibayarkan:";
            // 
            // tbCariPenjualan
            // 
            this.tbCariPenjualan.Location = new System.Drawing.Point(718, 12);
            this.tbCariPenjualan.Name = "tbCariPenjualan";
            this.tbCariPenjualan.Size = new System.Drawing.Size(100, 20);
            this.tbCariPenjualan.TabIndex = 19;
            // 
            // btnBatalPembayaran
            // 
            this.btnBatalPembayaran.Location = new System.Drawing.Point(252, 144);
            this.btnBatalPembayaran.Name = "btnBatalPembayaran";
            this.btnBatalPembayaran.Size = new System.Drawing.Size(75, 23);
            this.btnBatalPembayaran.TabIndex = 20;
            this.btnBatalPembayaran.Text = "Batal";
            this.btnBatalPembayaran.UseVisualStyleBackColor = true;
            this.btnBatalPembayaran.Click += new System.EventHandler(this.btnBatalPembayaran_Click);
            // 
            // btnBayarPembayaran
            // 
            this.btnBayarPembayaran.Location = new System.Drawing.Point(171, 144);
            this.btnBayarPembayaran.Name = "btnBayarPembayaran";
            this.btnBayarPembayaran.Size = new System.Drawing.Size(75, 23);
            this.btnBayarPembayaran.TabIndex = 21;
            this.btnBayarPembayaran.Text = "Bayar";
            this.btnBayarPembayaran.UseVisualStyleBackColor = true;
            this.btnBayarPembayaran.Click += new System.EventHandler(this.btnBayarPembayaran_Click);
            // 
            // btnPrintNotaLunas
            // 
            this.btnPrintNotaLunas.Location = new System.Drawing.Point(312, 179);
            this.btnPrintNotaLunas.Name = "btnPrintNotaLunas";
            this.btnPrintNotaLunas.Size = new System.Drawing.Size(75, 23);
            this.btnPrintNotaLunas.TabIndex = 22;
            this.btnPrintNotaLunas.Text = "Print";
            this.btnPrintNotaLunas.UseVisualStyleBackColor = true;
            this.btnPrintNotaLunas.Click += new System.EventHandler(this.btnPrintNotaLunas_Click);
            // 
            // TransaksiPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 533);
            this.Controls.Add(this.btnPrintNotaLunas);
            this.Controls.Add(this.btnBayarPembayaran);
            this.Controls.Add(this.btnBatalPembayaran);
            this.Controls.Add(this.tbCariPenjualan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPembayaranTotal);
            this.Controls.Add(this.lblPembayaranSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPembayaranUangDiterima);
            this.Controls.Add(this.tbPembayaranDiskon);
            this.Controls.Add(this.dataGridViewPembayaranDetailJasaService);
            this.Controls.Add(this.dataGridViewPembayaranDetailSpareparts);
            this.Controls.Add(this.dataGridViewPembayaran);
            this.Name = "TransaksiPembayaran";
            this.Text = "SIATO - Pembayaran";
            this.Load += new System.EventHandler(this.TransaksiPembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranDetailSpareparts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranDetailJasaService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPembayaran;
        private System.Windows.Forms.DataGridView dataGridViewPembayaranDetailSpareparts;
        private System.Windows.Forms.DataGridView dataGridViewPembayaranDetailJasaService;
        private System.Windows.Forms.TextBox tbPembayaranDiskon;
        private System.Windows.Forms.TextBox tbPembayaranUangDiterima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPembayaranSubtotal;
        private System.Windows.Forms.Label lblPembayaranTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCariPenjualan;
        private System.Windows.Forms.Button btnBatalPembayaran;
        private System.Windows.Forms.Button btnBayarPembayaran;
        private System.Windows.Forms.Button btnPrintNotaLunas;
    }
}