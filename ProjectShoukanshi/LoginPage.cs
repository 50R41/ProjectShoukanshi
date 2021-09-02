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
using System.Configuration;

namespace ProjectShoukanshi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
           
        }     
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = "Data Source=localhost;port=3306;username=root;password=;database=db_tabungan";
            string Query = "Select * From login where username='" + txtUSER.Text + "' and password='" + txtPASS.Text + "' and Usertype='"+ comboBox1.Text +"'";
            MySqlConnection con = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select usertype");
                return;
            }
           
            if (dt.Rows.Count > 0)
            {
                 MessageBox.Show("you are login as " + comboBox1.Text );
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Main ss = new Main();
                            ss.Show();
                            this.Hide();
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            MainUser sc = new MainUser();
                            sc.Show();
                            this.Hide();
                        }
                    else
                        MessageBox.Show("Invalid username or password");
                }
            
            else
                MessageBox.Show("Invalid username or password");
        }

        private void txtUSER_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
