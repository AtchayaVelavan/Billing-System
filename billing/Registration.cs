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
    public partial class Registration : Form
    {
        public Registration()
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
            SqlCommand com = new SqlCommand();
            com.Connection = con;
             com.CommandText = "select * from customer where id='" +textBox1.Text+ "'";
            string id = (string)com.ExecuteScalar();
            if (id == textBox1.Text)
            {
                MessageBox.Show("Id is Already Register Pls Enter Another id");

               
            }
            else
            {
                com.CommandText = "insert into customer values('" + textBox1.Text + "','" + textBox2.Text + "')";
                com.ExecuteNonQuery();


                MessageBox.Show("insert succesfully");
                Customer c = new Customer();
                c.ShowDialog();
            }

        }
    }
}
 