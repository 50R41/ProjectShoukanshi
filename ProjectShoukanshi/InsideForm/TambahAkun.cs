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
    public partial class TambahAkun : Form
    {
        public TambahAkun()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            Fillcombo();
        }
        void Fillcombo()
        {
            string cons = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "SELECT id_siswa FROM siswa ;";
            MySqlConnection con = new MySqlConnection(cons);
            MySqlCommand cmda = new MySqlCommand(Query, con);
            MySqlDataReader myRead;
            try
            {
                con.Open();
                myRead = cmda.ExecuteReader();

                while (myRead.Read())
                {
                    string dsa = myRead.GetString("id_siswa");
                    comboBox1.Items.Add(dsa);

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelStrTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cons = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "SELECT * FROM siswa WHERE id_siswa='"+comboBox1.Text+"' ;";
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
                    textID.Text = Sid;
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "insert into login (id_siswa, username, password, Usertype) values ('"+ textID.Text +"' , '"+ textUser.Text +"' , '"+ textPass.Text +"' , '"+ comboBox2.Text +"' );  ";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih namanya dulu !");
                return;
            } 
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih Usertypenya !");
                return;
            }
            try
            {
                conDatabase.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Data Berhasil Di Simpan");
                while (myReader.Read())
                {


                }

            }
            catch (Exception)
            {

                MessageBox.Show("Tolong pilih Username atau Password yang lain dan 1 User hanya bisa memiliki 1 akun !");
            }
        }

    }
}
