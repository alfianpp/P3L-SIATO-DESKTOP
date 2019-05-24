namespace SIATO
{
    partial class TransaksiPengadaanBarang
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
            this.dataGridViewPengadaanBarang = new System.Windows.Forms.DataGridView();
            this.btnPrintSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPengadaanBarangSupplier = new System.Windows.Forms.Label();
            this.lblPengadaanBarangTanggalTransaksi = new System.Windows.Forms.Label();
            this.lblPengadaanBarangStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengadaanBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPengadaanBarang
            // 
            this.dataGridViewPengadaanBarang.AllowUserToAddRows = false;
            this.dataGridViewPengadaanBarang.AllowUserToDeleteRows = false;
            this.dataGridViewPengadaanBarang.AllowUserToResizeRows = false;
            this.dataGridViewPengadaanBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengadaanBarang.Location = new System.Drawing.Point(255, 38);
            this.dataGridViewPengadaanBarang.MultiSelect = false;
            this.dataGridViewPengadaanBarang.Name = "dataGridViewPengadaanBarang";
            this.dataGridViewPengadaanBarang.ReadOnly = true;
            this.dataGridViewPengadaanBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPengadaanBarang.Size = new System.Drawing.Size(359, 264);
            this.dataGridViewPengadaanBarang.TabIndex = 0;
            this.dataGridViewPengadaanBarang.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPengadaanBarang_RowHeaderMouseDoubleClick);
            // 
            // btnPrintSP
            // 
            this.btnPrintSP.Location = new System.Drawing.Point(12, 130);
            this.btnPrintSP.Name = "btnPrintSP";
            this.btnPrintSP.Size = new System.Drawing.Size(75, 23);
            this.btnPrintSP.TabIndex = 1;
            this.btnPrintSP.Text = "Print";
            this.btnPrintSP.UseVisualStyleBackColor = true;
            this.btnPrintSP.Click += new System.EventHandler(this.btnPrintSP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // lblPengadaanBarangSupplier
            // 
            this.lblPengadaanBarangSupplier.AutoSize = true;
            this.lblPengadaanBarangSupplier.Location = new System.Drawing.Point(110, 38);
            this.lblPengadaanBarangSupplier.Name = "lblPengadaanBarangSupplier";
            this.lblPengadaanBarangSupplier.Size = new System.Drawing.Size(80, 13);
            this.lblPengadaanBarangSupplier.TabIndex = 5;
            this.lblPengadaanBarangSupplier.Text = "{supplier.nama}";
            // 
            // lblPengadaanBarangTanggalTransaksi
            // 
            this.lblPengadaanBarangTanggalTransaksi.AutoSize = true;
            this.lblPengadaanBarangTanggalTransaksi.Location = new System.Drawing.Point(110, 66);
            this.lblPengadaanBarangTanggalTransaksi.Name = "lblPengadaanBarangTanggalTransaksi";
            this.lblPengadaanBarangTanggalTransaksi.Size = new System.Drawing.Size(74, 13);
            this.lblPengadaanBarangTanggalTransaksi.TabIndex = 6;
            this.lblPengadaanBarangTanggalTransaksi.Text = "{tgl_transaksi}";
            // 
            // lblPengadaanBarangStatus
            // 
            this.lblPengadaanBarangStatus.AutoSize = true;
            this.lblPengadaanBarangStatus.Location = new System.Drawing.Point(110, 94);
            this.lblPengadaanBarangStatus.Name = "lblPengadaanBarangStatus";
            this.lblPengadaanBarangStatus.Size = new System.Drawing.Size(43, 13);
            this.lblPengadaanBarangStatus.TabIndex = 7;
            this.lblPengadaanBarangStatus.Text = "{status}";
            // 
            // TransaksiPengadaanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 314);
            this.Controls.Add(this.lblPengadaanBarangStatus);
            this.Controls.Add(this.lblPengadaanBarangTanggalTransaksi);
            this.Controls.Add(this.lblPengadaanBarangSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintSP);
            this.Controls.Add(this.dataGridViewPengadaanBarang);
            this.Name = "TransaksiPengadaanBarang";
            this.Text = "SIATO - Pengadaan Barang";
            this.Load += new System.EventHandler(this.TransaksiPengadaanBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengadaanBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengadaanBarang;
        private System.Windows.Forms.Button btnPrintSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPengadaanBarangSupplier;
        private System.Windows.Forms.Label lblPengadaanBarangTanggalTransaksi;
        private System.Windows.Forms.Label lblPengadaanBarangStatus;
    }
}