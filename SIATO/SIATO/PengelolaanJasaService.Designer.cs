namespace SIATO
{
    partial class PengelolaanJasaService
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
            this.dataGridViewJasaService = new System.Windows.Forms.DataGridView();
            this.tbJasaServiceNama = new System.Windows.Forms.TextBox();
            this.tbJasaServiceHargaJual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHapusJasaService = new System.Windows.Forms.Button();
            this.tbCariJasaService = new System.Windows.Forms.TextBox();
            this.btnSimpanJasaService = new System.Windows.Forms.Button();
            this.btnBatalJasaService = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJasaService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJasaService
            // 
            this.dataGridViewJasaService.AllowUserToAddRows = false;
            this.dataGridViewJasaService.AllowUserToDeleteRows = false;
            this.dataGridViewJasaService.AllowUserToResizeRows = false;
            this.dataGridViewJasaService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJasaService.Location = new System.Drawing.Point(255, 38);
            this.dataGridViewJasaService.MultiSelect = false;
            this.dataGridViewJasaService.Name = "dataGridViewJasaService";
            this.dataGridViewJasaService.ReadOnly = true;
            this.dataGridViewJasaService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJasaService.Size = new System.Drawing.Size(359, 264);
            this.dataGridViewJasaService.TabIndex = 0;
            this.dataGridViewJasaService.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewJasaService_RowHeaderMouseDoubleClick);
            // 
            // tbJasaServiceNama
            // 
            this.tbJasaServiceNama.Location = new System.Drawing.Point(73, 38);
            this.tbJasaServiceNama.Name = "tbJasaServiceNama";
            this.tbJasaServiceNama.Size = new System.Drawing.Size(176, 20);
            this.tbJasaServiceNama.TabIndex = 1;
            // 
            // tbJasaServiceHargaJual
            // 
            this.tbJasaServiceHargaJual.Location = new System.Drawing.Point(73, 64);
            this.tbJasaServiceHargaJual.Name = "tbJasaServiceHargaJual";
            this.tbJasaServiceHargaJual.Size = new System.Drawing.Size(176, 20);
            this.tbJasaServiceHargaJual.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harga Jual";
            // 
            // btnHapusJasaService
            // 
            this.btnHapusJasaService.Location = new System.Drawing.Point(93, 100);
            this.btnHapusJasaService.Name = "btnHapusJasaService";
            this.btnHapusJasaService.Size = new System.Drawing.Size(75, 23);
            this.btnHapusJasaService.TabIndex = 7;
            this.btnHapusJasaService.Text = "Hapus";
            this.btnHapusJasaService.UseVisualStyleBackColor = true;
            this.btnHapusJasaService.Click += new System.EventHandler(this.btnHapusJasaService_Click);
            // 
            // tbCariJasaService
            // 
            this.tbCariJasaService.Location = new System.Drawing.Point(457, 12);
            this.tbCariJasaService.Name = "tbCariJasaService";
            this.tbCariJasaService.Size = new System.Drawing.Size(157, 20);
            this.tbCariJasaService.TabIndex = 8;
            this.tbCariJasaService.TextChanged += new System.EventHandler(this.tbCariJasaService_TextChanged);
            // 
            // btnSimpanJasaService
            // 
            this.btnSimpanJasaService.Location = new System.Drawing.Point(12, 100);
            this.btnSimpanJasaService.Name = "btnSimpanJasaService";
            this.btnSimpanJasaService.Size = new System.Drawing.Size(75, 23);
            this.btnSimpanJasaService.TabIndex = 10;
            this.btnSimpanJasaService.Text = "Tambah";
            this.btnSimpanJasaService.UseVisualStyleBackColor = true;
            this.btnSimpanJasaService.Click += new System.EventHandler(this.btnSimpanJasaService_Click);
            // 
            // btnBatalJasaService
            // 
            this.btnBatalJasaService.Location = new System.Drawing.Point(174, 100);
            this.btnBatalJasaService.Name = "btnBatalJasaService";
            this.btnBatalJasaService.Size = new System.Drawing.Size(75, 23);
            this.btnBatalJasaService.TabIndex = 11;
            this.btnBatalJasaService.Text = "Batal";
            this.btnBatalJasaService.UseVisualStyleBackColor = true;
            this.btnBatalJasaService.Click += new System.EventHandler(this.btnBatalJasaService_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cari:";
            // 
            // PengelolaanJasaService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBatalJasaService);
            this.Controls.Add(this.btnSimpanJasaService);
            this.Controls.Add(this.tbCariJasaService);
            this.Controls.Add(this.btnHapusJasaService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbJasaServiceHargaJual);
            this.Controls.Add(this.tbJasaServiceNama);
            this.Controls.Add(this.dataGridViewJasaService);
            this.Name = "PengelolaanJasaService";
            this.Text = "SIATO - Pengelolaan Data Jasa Service";
            this.Load += new System.EventHandler(this.PengelolaanJasaService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJasaService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJasaService;
        private System.Windows.Forms.TextBox tbJasaServiceNama;
        private System.Windows.Forms.TextBox tbJasaServiceHargaJual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHapusJasaService;
        private System.Windows.Forms.TextBox tbCariJasaService;
        private System.Windows.Forms.Button btnSimpanJasaService;
        private System.Windows.Forms.Button btnBatalJasaService;
        private System.Windows.Forms.Label label3;
    }
}