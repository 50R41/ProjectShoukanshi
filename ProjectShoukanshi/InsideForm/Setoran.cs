using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProjectShoukanshi.InsideForm
{
    public partial class Setoran : Form
    {
        public Setoran()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            Fillcombo();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelStrTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string constring ="Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "insert into tabungan(id_siswa, nama, tanggal, setoran, saldo) values ('"+ textID.Text +"' ,'"+ textNama.Text +"' , '"+ dateTanggal.Value.Date.ToString("yyyyMMdd") +"' , '"+ textSetoran.Text +"' , '"+ textSetoran.Text +"')";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil Di Input");
                while (myReader.Read())
                {


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Setoran_Load(object sender, EventArgs e)
        {

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
                    string Sid = myRead.GetInt32("id_siswa").ToString();
                    string Snama = myRead.GetString("nama");
                    textID.Text = Sid;
                    textNama.Text = Snama;

                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }

    }
}
