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
   
    public partial class change : Form
    {
     
       
        public change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string id1 = textBox1.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-S9M63N0\\SQLEXPRESS;database=BillingSystem;integrated security=true;";
            try
            {
                con.Open();
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("no");
            }
            SqlCommand comm = new SqlCommand();
           
            comm.Connection = con;
            comm.CommandText = "update stationary2 SET rate='" + textBox1.Text +"' where items='"+ comboBox1.SelectedItem.ToString()+"'";
            
            comm.ExecuteNonQuery();
            MessageBox.Show("change successfully");




        }

        private void change_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
        }
    }
}
