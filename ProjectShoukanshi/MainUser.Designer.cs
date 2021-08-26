namespace ProjectShoukanshi
{
    partial class MainUser
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLPR = new System.Windows.Forms.Button();
            this.btnAnggota = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnLPR);
            this.panelMenu.Controls.Add(this.btnAnggota);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(158, 500);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = global::ProjectShoukanshi.Properties.Resources.Tak_berjudul27_20210825201208_24x24;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 188);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(158, 60);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLPR
            // 
            this.btnLPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLPR.FlatAppearance.BorderSize = 0;
            this.btnLPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPR.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLPR.Image = global::ProjectShoukanshi.Properties.Resources.Laporan_Transaksi_24x24;
            this.btnLPR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLPR.Location = new System.Drawing.Point(0, 128);
            this.btnLPR.Name = "btnLPR";
            this.btnLPR.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLPR.Size = new System.Drawing.Size(158, 60);
            this.btnLPR.TabIndex = 4;
            this.btnLPR.Text = "  Laporan Transaksi";
            this.btnLPR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLPR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLPR.UseVisualStyleBackColor = true;
            this.btnLPR.Click += new System.EventHandler(this.btnLPR_Click);
            // 
            // btnAnggota
            // 
            this.btnAnggota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnggota.FlatAppearance.BorderSize = 0;
            this.btnAnggota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnggota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnggota.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnggota.Image = global::ProjectShoukanshi.Properties.Resources.Data_Anggota_24x24;
            this.btnAnggota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnggota.Location = new System.Drawing.Point(0, 68);
            this.btnAnggota.Name = "btnAnggota";
            this.btnAnggota.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAnggota.Size = new System.Drawing.Size(158, 60);
            this.btnAnggota.TabIndex = 2;
            this.btnAnggota.Text = "  Data Anggota";
            this.btnAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnggota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnggota.UseVisualStyleBackColor = true;
            this.btnAnggota.Click += new System.EventHandler(this.btnAnggota_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(158, 68);
            this.panelLogo.TabIndex = 0;
            // 
            // MainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 500);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainUser";
            this.Text = "MainUser";
            this.Load += new System.EventHandler(this.MainUser_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLPR;
        private System.Windows.Forms.Button btnAnggota;
        private System.Windows.Forms.Panel panelLogo;

    }
}