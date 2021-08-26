﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectShoukanshi
{
    public partial class Main : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        
        //Constructor
        public Main()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.Colorlist.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.Colorlist.Count);
            }
            tempIndex = index;
            string color = ThemeColor.Colorlist[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.2);
                }
            }

        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnAnggota_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnTRN_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnLPR_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm mn = new LoginForm();
            mn.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

      

    }
}
