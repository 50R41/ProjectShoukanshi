namespace ProjectShoukanshi.InsideForm
{
    partial class FormTambah
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
            this.panelTmbhTitle = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.textNIK = new System.Windows.Forms.TextBox();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textKelas = new System.Windows.Forms.TextBox();
            this.dateTanggal = new System.Windows.Forms.DateTimePicker();
            this.radioLaki = new System.Windows.Forms.RadioButton();
            this.radioPerempuan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTempat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textAlamat = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTmbhTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTmbhTitle
            // 
            this.panelTmbhTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panelTmbhTitle.Controls.Add(this.btnMinimize);
            this.panelTmbhTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTmbhTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panelTmbhTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTmbhTitle.Name = "panelTmbhTitle";
            this.panelTmbhTitle.Size = new System.Drawing.Size(611, 41);
            this.panelTmbhTitle.TabIndex = 0;
            this.panelTmbhTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTmbhTitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(591, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 29);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // textNIK
            // 
            this.textNIK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNIK.Location = new System.Drawing.Point(0, 72);
            this.textNIK.Multiline = true;
            this.textNIK.Name = "textNIK";
            this.textNIK.Size = new System.Drawing.Size(611, 27);
            this.textNIK.TabIndex = 1;
            // 
            // textNama
            // 
            this.textNama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNama.Location = new System.Drawing.Point(0, 127);
            this.textNama.Multiline = true;
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(611, 27);
            this.textNama.TabIndex = 2;
            // 
            // textKelas
            // 
            this.textKelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textKelas.Location = new System.Drawing.Point(0, 180);
            this.textKelas.Multiline = true;
            this.textKelas.Name = "textKelas";
            this.textKelas.Size = new System.Drawing.Size(611, 27);
            this.textKelas.TabIndex = 3;
            // 
            // dateTanggal
            // 
            this.dateTanggal.Location = new System.Drawing.Point(90, 386);
            this.dateTanggal.Name = "dateTanggal";
            this.dateTanggal.Size = new System.Drawing.Size(120, 20);
            this.dateTanggal.TabIndex = 4;
            // 
            // radioLaki
            // 
            this.radioLaki.AutoSize = true;
            this.radioLaki.Location = new System.Drawing.Point(12, 257);
            this.radioLaki.Name = "radioLaki";
            this.radioLaki.Size = new System.Drawing.Size(64, 17);
            this.radioLaki.TabIndex = 5;
            this.radioLaki.TabStop = true;
            this.radioLaki.Text = "Laki-laki";
            this.radioLaki.UseVisualStyleBackColor = true;
            this.radioLaki.CheckedChanged += new System.EventHandler(this.radioLaki_CheckedChanged);
            // 
            // radioPerempuan
            // 
            this.radioPerempuan.AutoSize = true;
            this.radioPerempuan.Location = new System.Drawing.Point(12, 280);
            this.radioPerempuan.Name = "radioPerempuan";
            this.radioPerempuan.Size = new System.Drawing.Size(79, 17);
            this.radioPerempuan.TabIndex = 6;
            this.radioPerempuan.TabStop = true;
            this.radioPerempuan.Text = "Perempuan";
            this.radioPerempuan.UseVisualStyleBackColor = true;
            this.radioPerempuan.CheckedChanged += new System.EventHandler(this.radioPerempuan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NIK :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kelas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jenis Kelamin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tempat Lahir :";
            // 
            // textTempat
            // 
            this.textTempat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTempat.Location = new System.Drawing.Point(0, 336);
            this.textTempat.Multiline = true;
            this.textTempat.Name = "textTempat";
            this.textTempat.Size = new System.Drawing.Size(611, 27);
            this.textTempat.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Alamat Lengkap :";
            // 
            // textAlamat
            // 
            this.textAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAlamat.Location = new System.Drawing.Point(0, 437);
            this.textAlamat.Multiline = true;
            this.textAlamat.Name = "textAlamat";
            this.textAlamat.Size = new System.Drawing.Size(611, 55);
            this.textAlamat.TabIndex = 13;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(537, 504);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(64, 30);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(479, 504);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(52, 30);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tanggal Lahir :";
            // 
            // FormTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 546);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textAlamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTempat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioPerempuan);
            this.Controls.Add(this.radioLaki);
            this.Controls.Add(this.dateTanggal);
            this.Controls.Add(this.textKelas);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.textNIK);
            this.Controls.Add(this.panelTmbhTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTambah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahSiswa";
            this.panelTmbhTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTmbhTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TextBox textNIK;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.TextBox textKelas;
        private System.Windows.Forms.DateTimePicker dateTanggal;
        private System.Windows.Forms.RadioButton radioLaki;
        private System.Windows.Forms.RadioButton radioPerempuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTempat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAlamat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label7;

    }
}