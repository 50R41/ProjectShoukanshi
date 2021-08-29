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
using System.Data.SqlClient;
using System.Configuration;

namespace ProjectShoukanshi.InsideForm
{
    public partial class FormTambah : Form
    {
        public FormTambah()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
       string JenisKelamin;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTmbhTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-NTD0N2N\PROJECTAIDEN01;Initial Catalog=DataShoukan;Integrated Security=True";
            string Query = "insert into Siswa (NIK, nama, kelas, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat_lengkap) values('" + this.textNIK.Text + "' , '" + this.textNama.Text + "' , '" + this.textKelas.Text + "' , '" + JenisKelamin + "' , '" + this.textTempat.Text + "' , '" + dateTanggal.Value.Date.ToString("yyyyMMdd") + "' , '" + this.textAlamat.Text + "');  ";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
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

        private void radioLaki_CheckedChanged(object sender, EventArgs e)
        {
         JenisKelamin="Laki-laki";
        }

        private void radioPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            JenisKelamin="Perempuan";
        }
    }
}
