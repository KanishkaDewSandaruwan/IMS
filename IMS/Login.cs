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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = loginUsername.Text;
            String password = loginPassword.Text;   

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");
                con.Open();

                String query = "SELECT * FROM UserTb WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@username", username);
                cmd.Parameters.Add("@password", password);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    if(sdr.GetValue(0).ToString() == "")
                    {
                        MessageBox.Show("Username or Password is Wrong");
                    }
                    else
                    {
                        Home home = new Home();
                        home.Visible = true;
                        this.Visible = false;
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                 MessageBox.Show("Username or Password is Wrong");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginUsername.Select();
        }
    }
}
