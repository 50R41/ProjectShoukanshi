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
    public partial class EditSiswa : Form
    {
        public EditSiswa()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            Fillcombo();
        }
        
        string JenisKelamin;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); 

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
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "UPDATE siswa SET id_siswa='" + textID.Text + "' , NIK ='" + this.textNIK.Text + "' , nama ='" + this.textNama.Text + "' , kelas ='" + this.textKelas.Text + "' , jenis_kelamin = '" + JenisKelamin + "' , tempat_lahir = '" + this.textTempat.Text + "' , tanggal_lahir = '" + dateTanggal.Value.Date.ToString("yyyyMMdd") + "' , alamat_lengkap = '" + this.textAlamat.Text + "' WHERE id_siswa='" + textID.Text + "'; ";
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
                    string NIK = myRead.GetString("NIK");
                    string Snama = myRead.GetString("nama");
                    string kls = myRead.GetString("kelas");
                    string tempt = myRead.GetString("tempat_lahir");
                    string tgl = myRead.GetString("tanggal_lahir");
                    string almt = myRead.GetString("alamat_lengkap");
                    textID.Text = Sid;
                    textNIK.Text = NIK;
                    textNama.Text = Snama;
                    textKelas.Text = kls;
                    textTempat.Text = tempt;
                    dateTanggal.Text = tgl;
                    textAlamat.Text = almt;

                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }

        private void radioLaki_CheckedChanged(object sender, EventArgs e)
        {
            JenisKelamin = "Laki-laki";
        }

        private void radioPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            JenisKelamin = "Perempuan";
        }

        private void EditSiswa_Load(object sender, EventArgs e)
        {

        }

        private void panelTmbhTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string cons = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "DELETE FROM siswa WHERE id_siswa = '" + this.textID.Text + "'";
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
    }
}
