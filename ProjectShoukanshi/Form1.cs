﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectShoukanshi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NTD0N2N\PROJECTAIDEN01;Initial Catalog=DataShoukan;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * From Login where username='" + txtUSER.Text+"' and password='"+ txtPASS.Text +"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue=comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i =0; i<dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["UserType"].ToString() == cmbItemValue)
                    {
                       MessageBox.Show("you are login as " + dt.Rows[i][2]);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Main ss = new Main();
                            ss.ShowDialog();
                           
                        }
                        else if(comboBox1.SelectedIndex == 1)
                        {
                            MainUser sc = new MainUser();
                            sc.ShowDialog();
                          
                        }
                        
                    }
                }
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
            this.Close();
        }
    }
}
