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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetoran
            // 
            this.btnSetoran.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetoran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetoran.Location = new System.Drawing.Point(18, 75);
            this.btnSetoran.Name = "btnSetoran";
            this.btnSetoran.Size = new System.Drawing.Size(54, 30);
            this.btnSetoran.TabIndex = 0;
            this.btnSetoran.Text = "Setoran";
            this.btnSetoran.UseVisualStyleBackColor = false;
            this.btnSetoran.Click += new System.EventHandler(this.btnSetoran_Click);
            // 
            // btnPenarikan
            // 
            this.btnPenarikan.BackColor = System.Drawing.SystemColors.Control;
            this.btnPenarikan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenarikan.Location = new System.Drawing.Point(18, 37);
            this.btnPenarikan.Name = "btnPenarikan";
            this.btnPenarikan.Size = new System.Drawing.Size(68, 30);
            this.btnPenarikan.TabIndex = 1;
            this.btnPenarikan.Text = "Penarikan";
            this.btnPenarikan.UseVisualStyleBackColor = false;
            this.btnPenarikan.Click += new System.EventHandler(this.btnPenarikan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 219);
            this.dataGridView1.TabIndex = 2;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(353, 80);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(128, 20);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cari : ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(78, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 32);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormLaporanTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 334);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPenarikan);
            this.Controls.Add(this.btnSetoran);
            this.Name = "FormLaporanTransaksi";
            this.Text = "Tabungan";
            this.Load += new System.EventHandler(this.FormLaporanTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetoran;
        private System.Windows.Forms.Button btnPenarikan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;

    }
}