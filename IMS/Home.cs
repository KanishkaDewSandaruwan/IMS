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

namespace IMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Visible = true;
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserManage userManage = new UserManage();   
            this.Visible = false;
            userManage.Visible = true;  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Visible = true;
            this.Visible=false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Visible = true;
            this.Visible = false ;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Visible = true;
            this.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OrderList orderList = new OrderList();  
            orderList.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

            try
            {
                int sum = 0;
                SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");
                con.Open();
                String query = "SELECT * FROM OrderTb";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    sum = sum + int.Parse(sdr.GetValue(2).ToString());
                }

                sumLabel.Text = sum.ToString();
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
     
                SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");
                con.Open();
                String query = "SELECT COUNT(fullname) FROM CustomerTb";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    coustomerCount.Text = sdr.GetValue(0).ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
