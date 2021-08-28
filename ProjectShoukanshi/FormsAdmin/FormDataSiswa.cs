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
    public partial class FormDataAnggota : Form
    {
   
        public FormDataAnggota()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormTambah tmbh = new FormTambah();
            tmbh.ShowDialog();

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

        private void FormDataAnggota_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
