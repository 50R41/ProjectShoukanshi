namespace ProjectShoukanshi.InsideForm
{
    partial class Penarikan
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.panelPnkTitle = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.dateTanggal = new System.Windows.Forms.DateTimePicker();
            this.textPenarikan = new System.Windows.Forms.TextBox();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelPnkTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(440, 257);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(64, 30);
            this.btnSimpan.TabIndex = 27;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // panelPnkTitle
            // 
            this.panelPnkTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panelPnkTitle.Controls.Add(this.btnMinimize);
            this.panelPnkTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPnkTitle.Location = new System.Drawing.Point(0, 0);
            this.panelPnkTitle.Name = "panelPnkTitle";
            this.panelPnkTitle.Size = new System.Drawing.Size(527, 40);
            this.panelPnkTitle.TabIndex = 26;
            this.panelPnkTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPnkTitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(507, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 29);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // dateTanggal
            // 
            this.dateTanggal.Location = new System.Drawing.Point(116, 175);
            this.dateTanggal.Name = "dateTanggal";
            this.dateTanggal.Size = new System.Drawing.Size(140, 20);
            this.dateTanggal.TabIndex = 25;
            // 
            // textPenarikan
            // 
            this.textPenarikan.Location = new System.Drawing.Point(116, 217);
            this.textPenarikan.Multiline = true;
            this.textPenarikan.Name = "textPenarikan";
            this.textPenarikan.Size = new System.Drawing.Size(411, 27);
            this.textPenarikan.TabIndex = 24;
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(116, 134);
            this.textNama.Multiline = true;
            this.textNama.Name = "textNama";
            this.textNama.ReadOnly = true;
            this.textNama.Size = new System.Drawing.Size(411, 27);
            this.textNama.TabIndex = 23;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(116, 98);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(411, 27);
            this.textID.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Jumlah Penarikan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nama Siswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id Siswa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(206, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pilih";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "nama";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Penarikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 309);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.panelPnkTitle);
            this.Controls.Add(this.dateTanggal);
            this.Controls.Add(this.textPenarikan);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Penarikan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penarikan";
            this.panelPnkTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Panel panelPnkTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.DateTimePicker dateTanggal;
        private System.Windows.Forms.TextBox textPenarikan;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}