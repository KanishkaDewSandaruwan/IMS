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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            loadCatId();
        }

        SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String catid = catIDS.Text;
            String catname = catName.Text;

            try
            {
                if (String.IsNullOrEmpty(catname))
                {
                    MessageBox.Show("Please Enter Category Name");
                }
                else
                {
                    con.Open();
                    String query = "insert into CatTb(catid,catname) values(@catid, @catname)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@catid", catid);
                    cmd.Parameters.Add("@catname", catname);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Adding Success");

                    catIDS.Clear();
                    catName.Clear();
                    loadCatId();

                    con.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                catIDS.Clear();
                catName.Clear();
            }
        }
        void populate()
        {
            try
            {
                con.Open();
                String selectallquery = "SELECT * FROM CatTb";
                SqlDataAdapter adapter = new SqlDataAdapter(selectallquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventrydbDataSet2.CatTb' table. You can move, or remove it, as needed.
            this.catTbTableAdapter.Fill(this.inventrydbDataSet2.CatTb);
            loadCatId();
            populate();
        }

        void loadCatId()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");
                con.Open();
                String query = "SELECT catid FROM CatTb";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    catIDS.Text = (int.Parse(sdr.GetValue(0).ToString()) + 1).ToString();
                }
                con.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            catIDS.Clear();
            catName.Clear();
            loadCatId();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String catids = catIDS.Text;

            try
            {
                if (String.IsNullOrEmpty(catids))
                {
                    MessageBox.Show("You need to Select Category to Delete");
                }
                else
                {
                    con.Open();
                    String deletequery = "DELETE FROM CatTb WHERE catid = @catid";
                    SqlCommand cmd = new SqlCommand(deletequery, con);
                    cmd.Parameters.Add("@catid", catids);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Delete Success");

                    catIDS.Clear();
                    catName.Clear();

                    con.Close();
                    populate();
                    loadCatId();
                }

            }
            catch
            {

            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            catIDS.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            catName.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String catids = catIDS.Text;
            String catname = catName.Text;

            try
            {
                if (String.IsNullOrEmpty(catname))
                {
                    MessageBox.Show("Please Enter Category Name");
                }
                else
                {
                    con.Open();
                    String query = "UPDATE CatTb SET catname = @catname WHERE catid = @catid";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@catname", catname);
                    cmd.Parameters.Add("@catid", catids);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Editing Successfully");

                    catIDS.Clear();
                    catName.Clear();

                    con.Close();
                    populate();
                    loadCatId();

                }
            }
            catch
            {

            }
        }
    }
}
