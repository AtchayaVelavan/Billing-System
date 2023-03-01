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
    public partial class Customer : Form
    {
        public static string id = "";
        public static string customname = "";
        public static string mobileno = "";
        public static string Emailid = "";
        public Customer()
        {
            InitializeComponent();
        }
        Update chang = new Update();


        private void Customer_Load(object sender, EventArgs e)
        {

           
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            customname = textBox2.Text;
            mobileno = textBox3.Text;
            Emailid = textBox4.Text;

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
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText="select id from customer where id='"+textBox1.Text+"'";

            string id= (string)cm.ExecuteScalar();
            
            if (id == textBox1.Text)
            {
                Product p = new Product();
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pls Register");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.ShowDialog();
            
            

        }
    }
}
