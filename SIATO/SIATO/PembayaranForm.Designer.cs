namespace SIATO
{
    partial class PembayaranForm
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
            this.dataGridViewPembayaranIndex = new System.Windows.Forms.DataGridView();
            this.btnGetDetailPembayaran = new System.Windows.Forms.Button();
            this.dataGridViewPembayaranDetailSpareparts = new System.Windows.Forms.DataGridView();
            this.dataGridViewPembayaranDetailJasaService = new System.Windows.Forms.DataGridView();
            this.btnBayar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranDetailSpareparts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranDetailJasaService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPembayaranIndex
            // 
            this.dataGridViewPembayaranIndex.AllowUserToAddRows = false;
            this.dataGridViewPembayaranIndex.AllowUserToDeleteRows = false;
            this.dataGridViewPembayaranIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPembayaranIndex.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewPembayaranIndex.Name = "dataGridViewPembayaranIndex";
            this.dataGridViewPembayaranIndex.ReadOnly = true;
            this.dataGridViewPembayaranIndex.Size = new System.Drawing.Size(776, 72);
            this.dataGridViewPembayaranIndex.TabIndex = 0;
            // 
            // btnGetDetailPembayaran
            // 
            this.btnGetDetailPembayaran.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGetDetailPembayaran.Location = new System.Drawing.Point(713, 138);
            this.btnGetDetailPembayaran.Name = "btnGetDetailPembayaran";
            this.btnGetDetailPembayaran.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGetDetailPembayaran.Size = new System.Drawing.Size(75, 23);
            this.btnGetDetailPembayaran.TabIndex = 1;
            this.btnGetDetailPembayaran.Text = "Detail";
            this.btnGetDetailPembayaran.UseVisualStyleBackColor = false;
            this.btnGetDetailPembayaran.Click += new System.EventHandler(this.btnGetDetailPembayaran_Click);
            // 
            // dataGridViewPembayaranDetailSpareparts
            // 
            this.dataGridViewPembayaranDetailSpareparts.AllowUserToAddRows = false;
            this.dataGridViewPembayaranDetailSpareparts.AllowUserToDeleteRows = false;
            this.dataGridViewPembayaranDetailSpareparts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPembayaranDetailSpareparts.Location = new System.Drawing.Point(36, 197);
            this.dataGridViewPembayaranDetailSpareparts.Name = "dataGridViewPembayaranDetailSpareparts";
            this.dataGridViewPembayaranDetailSpareparts.ReadOnly = true;
            this.dataGridViewPembayaranDetailSpareparts.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPembayaranDetailSpareparts.TabIndex = 2;
            // 
            // dataGridViewPembayaranDetailJasaService
            // 
            this.dataGridViewPembayaranDetailJasaService.AllowUserToAddRows = false;
            this.dataGridViewPembayaranDetailJasaService.AllowUserToDeleteRows = false;
            this.dataGridViewPembayaranDetailJasaService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPembayaranDetailJasaService.Location = new System.Drawing.Point(472, 197);
            this.dataGridViewPembayaranDetailJasaService.Name = "dataGridViewPembayaranDetailJasaService";
            this.dataGridViewPembayaranDetailJasaService.ReadOnly = true;
            this.dataGridViewPembayaranDetailJasaService.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPembayaranDetailJasaService.TabIndex = 3;
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.Lime;
            this.btnBayar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBayar.Location = new System.Drawing.Point(472, 366);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(75, 23);
            this.btnBayar.TabIndex = 4;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Spareparts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jasa Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "PEMBAYARAN";
            // 
            // PembayaranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.dataGridViewPembayaranDetailJasaService);
            this.Controls.Add(this.dataGridViewPembayaranDetailSpareparts);
            this.Controls.Add(this.btnGetDetailPembayaran);
            this.Controls.Add(this.dataGridViewPembayaranIndex);
            this.Name = "PembayaranForm";
            this.Text = "PembayaranForm";
            this.Load += new System.EventHandler(this.PembayaranForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranDetailSpareparts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembayaranDetailJasaService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPembayaranIndex;
        private System.Windows.Forms.Button btnGetDetailPembayaran;
        private System.Windows.Forms.DataGridView dataGridViewPembayaranDetailSpareparts;
        private System.Windows.Forms.DataGridView dataGridViewPembayaranDetailJasaService;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}