using ProjectShoukanshi.InsideForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectShoukanshi.Forms
{
    public partial class FormLaporanTransaksi : Form
    {
        public FormLaporanTransaksi()
        {
            InitializeComponent();
        }

        private void btnPenarikan_Click(object sender, EventArgs e)
        {
            Penarikan pnk = new Penarikan();
            pnk.ShowDialog();
        }

        private void btnSetoran_Click(object sender, EventArgs e)
        {
            Setoran snt = new Setoran();
            snt.ShowDialog();
        }

        private void FormLaporanTransaksi_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
    }
}
