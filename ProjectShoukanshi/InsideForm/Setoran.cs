using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectShoukanshi.InsideForm
{
    public partial class Setoran : Form
    {
        public Setoran()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
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
            string constring = @"Data Source=DESKTOP-NTD0N2N\PROJECTAIDEN01;Initial Catalog=DataShoukan;Integrated Security=True";
            string Query = "insert into Tabungan (id_siswa, tanggal, setoran) values('" + this.textID.Text + "', '" + dateTanggal.Value.Date.ToString("yyyyMMdd") + "' , '"+ this.textSetoran.Text +"');  ";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
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

    }
}
