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
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }
           SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            String username = userUsername.Text;    
            String password = userPassword.Text;
            String fullname = userFullName.Text;
            String phone = userPhone.Text;
            String email = userEmail.Text;
            String address = userAddress.Text;

            try
            {

                if(String.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter Username");
                }
                else if(String.IsNullOrEmpty(fullname))
                {
                    MessageBox.Show("Please Enter Full Name");
                }
                else if(String.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Please Enter Phone Number");
                }
                else if (String.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please Enter Email Address");
                }   
                else if(String.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please Enter Address");
                }
                else if(String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please Enter Password");
                }
                else if (String.IsNullOrEmpty(userConfPassword.Text))
                {
                    MessageBox.Show("Please Enter Confirm-Password");
                }
                else if (userPassword.Text.Equals(userConfPassword.Text))
                {
                    if (IsValidEmail(email))
                    {
                        if (IsValidPhoneNumber(phone))
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");
                            con.Open();
                            String query = "insert into UserTb(username, fullname, phone, email, address, password) values(@username, @fullname, @phone, @email, @address, @password)";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.Add("@username", username);
                            cmd.Parameters.Add("@fullname", fullname);
                            cmd.Parameters.Add("@phone", phone);
                            cmd.Parameters.Add("@email", email);
                            cmd.Parameters.Add("@address", address);
                            cmd.Parameters.Add("@password", password);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User Adding Success");

                            userPassword.Clear();
                            userConfPassword.Clear();
                            userUsername.Clear();
                            userFullName.Clear();
                            userPhone.Clear();
                            userEmail.Clear();
                            userAddress.Clear();

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
                else
                {
                    MessageBox.Show("Password is Not Match");
                    userConfPassword.Clear();
                    userPassword.Clear();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                userPassword.Clear();
                userConfPassword.Clear();
                userUsername.Clear();
                userFullName.Clear();
                userPhone.Clear();
                userEmail.Clear();
                userAddress.Clear();
                MessageBox.Show("Your Phone Number already Here");
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.Match(phoneNumber, @"^([\+]?61[-]?|[0])?[1-9][0-9]{8}$").Success;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imsdbDataSet.UserTb' table. You can move, or remove it, as needed.
            this.userTbTableAdapter.Fill(this.imsdbDataSet.UserTb);
            populate();
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void populate()
        {
            try
            {
                con.Open();
                String selectallquery = "SELECT * FROM UserTb";
                SqlDataAdapter adapter = new SqlDataAdapter(selectallquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String phone = userPhone.Text;

            try
            {
                if (String.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("You need to enter Phone NUmber to delete User");
                }
                else
                {
                    con.Open();
                    String deletequery = "DELETE FROM UserTb WHERE phone = @phone";
                    SqlCommand cmd = new SqlCommand(deletequery, con);
                    cmd.Parameters.Add("@phone", phone);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Delete Success");

                    userPassword.Clear();
                    userConfPassword.Clear();
                    userUsername.Clear();
                    userFullName.Clear();
                    userPhone.Clear();
                    userEmail.Clear();
                    userAddress.Clear();

                    con.Close();
                    populate();
                } 

            }
            catch 
            {
;
        }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userUsername.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            userFullName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            userPhone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            userEmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            userAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            userConfPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String username = userUsername.Text;
            String password = userPassword.Text;
            String fullname = userFullName.Text;
            String phone = userPhone.Text;
            String email = userEmail.Text;
            String address = userAddress.Text;

            try
            {

                if (String.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter Username");
                }
                else if (String.IsNullOrEmpty(fullname))
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
                    String query = "UPDATE UserTb SET username = @username, fullname = @fullname, phone = @phone, email = @email, address = @address, password = @password WHERE phone = @phone";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@username", username);
                    cmd.Parameters.Add("@fullname", fullname);
                    cmd.Parameters.Add("@phone", phone);
                    cmd.Parameters.Add("@email", email);
                    cmd.Parameters.Add("@address", address);
                    cmd.Parameters.Add("@password", password);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Editing Successfully");

                    userPassword.Clear();
                    userConfPassword.Clear();
                    userUsername.Clear();
                    userFullName.Clear();
                    userPhone.Clear();
                    userEmail.Clear();
                    userAddress.Clear();

                    con.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                userPassword.Clear();
                userConfPassword.Clear();
                userUsername.Clear();
                userFullName.Clear();
                userPhone.Clear();
                userEmail.Clear();
                userAddress.Clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            this.Visible = false;
            home.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userPassword.Clear();
            userConfPassword.Clear();
            userUsername.Clear();
            userFullName.Clear();
            userPhone.Clear();
            userEmail.Clear();
            userAddress.Clear();
        }
    }
}
