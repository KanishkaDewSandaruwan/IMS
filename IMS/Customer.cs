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
using System.Text.RegularExpressions;

namespace IMS
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            String fullname = customerFullName.Text;
            String phone = customerPhone.Text;
            String email = customerEmail.Text;
            String address = customerAddress.Text;

            try
            {

                if (String.IsNullOrEmpty(fullname))
                {
                    MessageBox.Show("Please Enter Full Name");
                }
                else if (String.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Please Enter Phone Number");
                }
                else if (String.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please Enter Email Address");
                }
                else if (String.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please Enter Address");
                }
                else if (IsValidEmail(email))
                {
                    if (IsValidPhoneNumber(phone))
                    {
                        con.Open();
                        String query = "insert into Customertb(fullname,phone,email,address) values(@fullname, @phone, @email, @address)";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.Add("@fullname", fullname);
                        cmd.Parameters.Add("@phone", phone);
                        cmd.Parameters.Add("@email", email);
                        cmd.Parameters.Add("@address", address);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Adding Success");

                        customerAddress.Clear();
                        customerEmail.Clear();
                        customerFullName.Clear();
                        customerPhone.Clear();

                        con.Close();
                        populate();

                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Phone Number");
                    }
                }
                else 
                {
                    MessageBox.Show("Enter Valid Email Address");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                customerAddress.Clear();
                customerEmail.Clear();
                customerFullName.Clear();
                customerPhone.Clear();            }

        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.Match(phoneNumber,@"^([\+]?61[-]?|[0])?[1-9][0-9]{8}$").Success;
        }


        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventrydbDataSet1.CustomerTb' table. You can move, or remove it, as needed.
            this.customerTbTableAdapter.Fill(this.inventrydbDataSet1.CustomerTb);
            populate();

        }

        void populate()
        {
            try
            {
                con.Open();
                String selectallquery = "SELECT * FROM CustomerTb";
                SqlDataAdapter adapter = new SqlDataAdapter(selectallquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerFullName.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            customerPhone.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            customerEmail.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            customerAddress.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String phone = customerPhone.Text;

            try
            {
                if (String.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("You need to enter Phone NUmber to delete User");
                }
                else
                {
                    con.Open();
                    String deletequery = "DELETE FROM CustomerTb WHERE phone = @phone";
                    SqlCommand cmd = new SqlCommand(deletequery, con);
                    cmd.Parameters.Add("@phone", phone);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Delete Success");

                    customerPhone.Clear();
                    customerFullName.Clear();
                    customerEmail.Clear();
                    customerAddress.Clear();

                    con.Close();
                    populate();
                }

            }
            catch
            {
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customerAddress.Clear();
            customerEmail.Clear();
            customerFullName.Clear();
            customerPhone.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fullname = customerFullName.Text;
            String phone = customerPhone.Text;
            String email = customerEmail.Text;
            String address = customerAddress.Text;

            try
            {
                if (String.IsNullOrEmpty(fullname))
                {
                    MessageBox.Show("Please Enter Full Name");
                }
                else if (String.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Please Enter Phone Number");
                }
                else if (String.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please Enter Email Address");
                }
                else if (String.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please Enter Address");
                }
                else
                {
                    con.Open();
                    String query = "UPDATE CustomerTb SET fullname = @fullname, phone = @phone, email = @email, address = @address WHERE phone = @phone";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@fullname", fullname);
                    cmd.Parameters.Add("@phone", phone);
                    cmd.Parameters.Add("@email", email);
                    cmd.Parameters.Add("@address", address);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Editing Successfully");

                    customerAddress.Clear();
                    customerEmail.Clear();
                    customerFullName.Clear();
                    customerPhone.Clear();

                    con.Close();
                    populate();

                }
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Visible = true;
            this.Visible = false;
        }
    }
}
