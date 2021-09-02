using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace ProjectShoukanshi.InsideForm
{
    public partial class EditAkun : Form
    {
        public EditAkun()
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string cons = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "DELETE FROM login WHERE id_siswa = '" + this.textID.Text + "'";
            MySqlConnection con = new MySqlConnection(cons);
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataReader myread;
            try
            {
                con.Open();
                myread = cmd.ExecuteReader();
                MessageBox.Show("Terhapus !");
                while (myread.Read())
                {



                }
            }
            catch (Exception xe)
            {
                MessageBox.Show(xe.Message);
            }
        }

        private void panelStrTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "UPDATE login SET id_siswa='" + textID.Text + "' , username= '" + this.textUser.Text + "' , password=  '" + this.textPass.Text + "' , Usertype= '" + comboBox2.Text + "' WHERE id_siswa='" + textID.Text + "';";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Data Berhasil Di Simpan");
                while (myReader.Read())
                {


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cons = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "SELECT * FROM login WHERE id_siswa='" + comboBox1.Text + "' ;";
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
                    string Suser = myRead.GetString("username");
                    string Upass = myRead.GetString("password");
                    string Utype = myRead.GetString("Usertype");
                    textID.Text = Sid;
                    textUser.Text = Suser;
                    textPass.Text = Upass;
                    comboBox2.Text = Utype;
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }


    }
}
