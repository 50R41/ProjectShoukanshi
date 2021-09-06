using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectShoukanshi.InsideForm
{
    public partial class DetailTabungan : Form
    {
        public DetailTabungan()
        {
            InitializeComponent();
            Fillcombo();
            load_table();
        }
        void Fillcombo()
        {
            string cons = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "SELECT nama FROM siswa ;";
            MySqlConnection con = new MySqlConnection(cons);
            MySqlCommand cmda = new MySqlCommand(Query, con);
            MySqlDataReader myRead;
            try
            {
                con.Open();
                myRead = cmda.ExecuteReader();

                while (myRead.Read())
                {
                    string nama = myRead.GetString("nama");
                    comboBox1.Items.Add(nama);

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        void load_table()
        {
            string cons = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "Select nama, tanggal, setoran, penarikan, SUM(saldo) as jumlah_saldo FROM tabungan GROUP BY nama";
            MySqlConnection con = new MySqlConnection(cons);
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            BindingSource bs = new BindingSource();

            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            sda.Update(dt);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cons = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "SELECT * FROM siswa WHERE nama='" + comboBox1.Text + "' ;";
            MySqlConnection con = new MySqlConnection(cons);
            MySqlCommand cmda = new MySqlCommand(Query, con);
            MySqlDataReader myRead;
            try
            {
                con.Open();
                myRead = cmda.ExecuteReader();

                while (myRead.Read())
                {
                    
                    string nm = myRead.GetString("nama");
                    string alm = myRead.GetString("alamat_lengkap");
                    textNama.Text = nm;
                    textAlamat.Text = alm;
                }

            }
            catch (Exception )
            {
                MessageBox.Show("eror");

            }
        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textkelas_TextChanged(object sender, EventArgs e)
        {
            string constring = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan.tabungan";
            string Query = "SELECT * FROM tabungan";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmda = new MySqlCommand(Query, con);
            DataTable dt = new DataTable();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("kelas LIKE '%{0}%'", textkelas.Text);
            dataGridView1.DataSource = dv;
        }
    }
}
