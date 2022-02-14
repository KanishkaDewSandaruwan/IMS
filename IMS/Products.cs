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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventrydbDataSet4.ProductTb' table. You can move, or remove it, as needed.
            this.productTbTableAdapter1.Fill(this.inventrydbDataSet4.ProductTb);
            fillCategory();
            loadCatId();
            populate();
        }

        void loadCatId()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");
                con.Open();
                String query = "SELECT pid FROM ProductTb";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        pID.Text = (int.Parse(sdr.GetValue(0).ToString()) + 1).ToString();
                    }

                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        void fillCategory()
        {
            try
            {
                con.Open();
                String query = "SELECT * FROM CatTb";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(String));
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                pCategory.ValueMember = "CatName";
                pCategory.DataSource = dt;

                Catsearch.ValueMember = "CatName";
                Catsearch.DataSource = dt;
                con.Close();    

            }
            catch 
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = pID.Text;
            String productName = pName.Text;
            String productPrice = pPrice.Text;
            String productQty = pQty.Text;
            String productDescription = pDescription.Text;
            String productCategory = pCategory.Text;

            try
            {

                if (String.IsNullOrEmpty(productName))
                {
                    MessageBox.Show("Please Enter Product Name");
                }
                else if (String.IsNullOrEmpty(productPrice))
                {
                    MessageBox.Show("Please Enter Price");
                }
                else if (String.IsNullOrEmpty(productQty))
                {
                    MessageBox.Show("Please Enter Product Qty");
                }
                else if (String.IsNullOrEmpty(productDescription))
                {
                    MessageBox.Show("Please Enter Description");
                }
                else
                {
                    con.Open();
                    String query = "insert into ProductTb(pid,product_name,product_price,product_qty, product_description, product_category) values(@pid, @pname, @pprice, @pqty, @pdescription, @pcategory)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@pid", id);
                    cmd.Parameters.Add("@pname", productName);
                    cmd.Parameters.Add("@pprice", productPrice);
                    cmd.Parameters.Add("@pqty", productQty);
                    cmd.Parameters.Add("@pdescription", productDescription);
                    cmd.Parameters.Add("@pcategory", productCategory);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Adding Success");

                    pID.Clear();
                    pName.Clear();
                    pPrice.Clear();
                    pQty.Clear();
                    pDescription.Clear();

                    con.Close();
                    fillCategory();
                    loadCatId();
                    populate();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                pID.Clear();
                pName.Clear();
                pPrice.Clear();
                pQty.Clear();
                pDescription.Clear();

                fillCategory();
                loadCatId();
            }
        }

        void populate()
        {
            try
            {
                con.Open();
                String selectallquery = "SELECT * FROM ProductTb";
                SqlDataAdapter adapter = new SqlDataAdapter(selectallquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView4.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pID.Clear();
            pName.Clear();
            pPrice.Clear();
            pQty.Clear();
            pDescription.Clear();

            fillCategory();
            loadCatId();
            populate();
        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pID.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            pName.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            pPrice.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
            pQty.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
            pDescription.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
            pCategory.Text = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String pids = pID.Text;


            try
            {
                if (String.IsNullOrEmpty(pids))
                {
                    MessageBox.Show("You need to Select User to Delete");
                }
                else
                {
                    con.Open();
                    String deletequery = "DELETE FROM ProductTb WHERE pid = @pid";
                    SqlCommand cmd = new SqlCommand(deletequery, con);
                    cmd.Parameters.Add("@pid", pids);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Delete Success");

                    pID.Clear();
                    pName.Clear();
                    pPrice.Clear();
                    pQty.Clear();
                    pDescription.Clear();

                    con.Close();

                    fillCategory();
                    loadCatId();
                    populate();


                }

            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String id = pID.Text;
            String productName = pName.Text;
            String productPrice = pPrice.Text;
            String productQty = pQty.Text;
            String productDescription = pDescription.Text;
            String productCategory = pCategory.Text;

            try
            {

                if (String.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please Select Product");
                }
                else
                {
                    con.Open();
                    String query = "UPDATE ProductTb SET product_name = @pname, product_price = @pprice ,product_qty = @pqty, product_description = @pdescription, product_category = @pcategory WHERE pid = @pid";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@pid", id);
                    cmd.Parameters.Add("@pname", productName);
                    cmd.Parameters.Add("@pprice", productPrice);
                    cmd.Parameters.Add("@pqty", productQty);
                    cmd.Parameters.Add("@pdescription", productDescription);
                    cmd.Parameters.Add("@pcategory", productCategory);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Edit Success");

                    pID.Clear();
                    pName.Clear();
                    pPrice.Clear();
                    pQty.Clear();
                    pDescription.Clear();

                    con.Close();
                    fillCategory();
                    loadCatId();
                    populate();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                pID.Clear();
                pName.Clear();
                pPrice.Clear();
                pQty.Clear();
                pDescription.Clear();

                fillCategory();
                loadCatId();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String searchCat = Catsearch.Text;

            try
            {
                con.Open();
                String filterquery = "SELECT * FROM ProductTb WHERE product_category = @searchCat ";
                SqlCommand cmd = new SqlCommand(filterquery, con);
                cmd.Parameters.Add("@searchCat", searchCat);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView4.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }
    }
}
