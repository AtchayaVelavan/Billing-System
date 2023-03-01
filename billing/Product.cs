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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        int totalamountforpen = 0;
        int totalamountforpencil = 0;
        int totalamountforeraser = 0;

        private void Product_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-S9M63N0\\SQLEXPRESS;database=BillingSystem;integrated security=true;";
            try
            {
                con.Open();
                // MessageBox.Show("sss");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no");
            }
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "select rate from stationary2 where items='" + label1.Text + "'";
            string pcrate = (string)cm.ExecuteScalar();
            label9.Text = pcrate;
            cm.CommandText = "select rate from stationary2 where items='" + label2.Text + "'";
            string pnrate = (string)cm.ExecuteScalar();
            label10.Text = pnrate;
            cm.CommandText = "select rate from stationary2 where items='" + label3.Text + "'";
            string errate = (string)cm.ExecuteScalar();
            label11.Text = errate;
            
            cm.CommandText = "select id from customer where id='" + Customer.id + "'";

            string id = (string)cm.ExecuteScalar();
            listBox1.Items.Add("                   Stationary Shop         ");
            listBox1.Items.Add("Name:       "+Customer.customname);
            listBox1.Items.Add("MobileNo:" + Customer.mobileno);
            listBox1.Items.Add("Mailid:      " + Customer.Emailid);
            listBox1.Items.Add("items        Quantity     Rate");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

             int total = totalamountforpen+ totalamountforpencil + totalamountforeraser;
            listBox1.Items.Add("                       total         " + total);
             
      

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             totalamountforpen = int.Parse(label10.Text) * Convert.ToInt32(numericUpDown2.Value);

            listBox1.Items.Add("Pen               " + numericUpDown2.Value + "                " + totalamountforpen);
                
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          

        }

        private void bu_Click(object sender, EventArgs e)
        {
                totalamountforpencil = int.Parse(label9.Text) * Convert.ToInt32(numericUpDown1.Value);
                    listBox1.Items.Add("Pencil           "+numericUpDown1.Value+"               " +totalamountforpencil);

                    //int a = int.Parse(label4.Text);
                    //int c = Convert.ToInt32(numericUpDown1.Value);
                    //int b = a - c;
                    //string str = Convert.ToString(b);
                    //label4.Text = str;            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            totalamountforeraser = int.Parse(label11.Text) * Convert.ToInt32(numericUpDown3.Value);
            listBox1.Items.Add("Eraser          " + numericUpDown3.Value + "               " + totalamountforeraser);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

    }
}
