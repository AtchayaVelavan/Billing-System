using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace billing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-S9M63N0\\SQLEXPRESS;Database=BillingSystem;integrated security=true";
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("fail");
            }
            SqlCommand comm = new SqlCommand();
            comm.Connection = con;
            comm.CommandText = "select passcode from Emp where Empid='" + textBox1.Text + "'";
            string passcode = (string)comm.ExecuteScalar();
            if (passcode == textBox2.Text)
            {
                Update c = new Update();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pls enter corect password");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
