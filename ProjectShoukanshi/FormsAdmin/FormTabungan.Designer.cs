namespace ProjectShoukanshi.Forms
{
    partial class FormLaporanTransaksi
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
            this.btnSetoran = new System.Windows.Forms.Button();
            this.btnPenarikan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetoran
            // 
            this.btnSetoran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetoran.Location = new System.Drawing.Point(12, 60);
            this.btnSetoran.Name = "btnSetoran";
            this.btnSetoran.Size = new System.Drawing.Size(76, 30);
            this.btnSetoran.TabIndex = 0;
            this.btnSetoran.Text = "Setoran";
            this.btnSetoran.UseVisualStyleBackColor = true;
            this.btnSetoran.Click += new System.EventHandler(this.btnSetoran_Click);
            // 
            // btnPenarikan
            // 
            this.btnPenarikan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenarikan.Location = new System.Drawing.Point(94, 60);
            this.btnPenarikan.Name = "btnPenarikan";
            this.btnPenarikan.Size = new System.Drawing.Size(75, 30);
            this.btnPenarikan.TabIndex = 1;
            this.btnPenarikan.Text = "Penarikan";
            this.btnPenarikan.UseVisualStyleBackColor = true;
            this.btnPenarikan.Click += new System.EventHandler(this.btnPenarikan_Click);
            // 
            // FormLaporanTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 313);
            this.Controls.Add(this.btnPenarikan);
            this.Controls.Add(this.btnSetoran);
            this.Name = "FormLaporanTransaksi";
            this.Text = "Tabungan";
            this.Load += new System.EventHandler(this.FormLaporanTransaksi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetoran;
        private System.Windows.Forms.Button btnPenarikan;

    }
}