using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectShoukanshi.InsideForm;
using MySql.Data.MySqlClient;

namespace ProjectShoukanshi.Forms
{
    public partial class FormDataAkun : Form
    {
        static String constring = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
        MySqlConnection con = new MySqlConnection(constring);
        DataTable dt = new DataTable();

        public FormDataAkun()
        {
            InitializeComponent();
            load_table();
            
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
        void load_table()
        {
            string Query = "SELECT id_siswa, username, password, Usertype FROM login";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            BindingSource bs = new BindingSource();

            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            sda.Update(dt);

        }

        private void FormDataAkun_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahAkun ta = new TambahAkun();
            ta.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAkun ea = new EditAkun();
            ea.ShowDialog();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("CONVERT(id_siswa, System.String) LIKE '%{0}%'", textSearch.Text);
            dataGridView1.DataSource = dv;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string Query = "SELECT id_siswa, username, password, Usertype FROM login";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dta = new DataTable();
                sda.Fill(dta);
                BindingSource bs = new BindingSource();

                bs.DataSource = dta;
                dataGridView1.DataSource = bs;
                sda.Update(dta);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
