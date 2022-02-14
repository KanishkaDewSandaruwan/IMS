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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            this.Visible = false;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            populateCustomer();
            populateProduct();
            loadCatId();

        }

        int price, num = 0, pid, productqty;
        String product;
        int sum = 0;
        int check = 0;

        private void dataGridView5_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pid = int.Parse(dataGridView5.SelectedRows[0].Cells[0].Value.ToString());
            price = int.Parse(dataGridView5.SelectedRows[0].Cells[2].Value.ToString());
            productqty = int.Parse(dataGridView5.SelectedRows[0].Cells[3].Value.ToString());
            product = dataGridView5.SelectedRows[0].Cells[1].Value.ToString();
            check = 1;
        }



        private void Ltotal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView6_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderCustomerID.Text = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (String.IsNullOrEmpty(quentity.Text))
            {
                MessageBox.Show("Please Enter Quentity in Product");
            }
            else if(check == 0)
            {
                MessageBox.Show("Please Select Product");
            }
            else
            {
                int qty = int.Parse(quentity.Text);
                total = qty * price;
                num = num + 1;

                int n = dataGridView7.Rows.Add();
                dataGridView7.Rows[n].Cells[0].Value = num;
                dataGridView7.Rows[n].Cells[1].Value = product;
                dataGridView7.Rows[n].Cells[2].Value = qty;
                dataGridView7.Rows[n].Cells[3].Value = price;
                dataGridView7.Rows[n].Cells[4].Value = total;
                check = 0;

                try
                {
      
                        con.Open();
                        String query = "UPDATE ProductTb SET product_qty = @product_qty WHERE pid = @pid";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add("@product_qty", productqty - 1);
                        cmd.Parameters.Add("@pid", pid);

                        cmd.ExecuteNonQuery();

                        con.Close();
                        populateProduct();
                        populateCustomer();

                    
                }
                catch
                {

                }
            }

            sum = sum + total;
            total_Label.Visible = true;
            Ltotal.Text = sum.ToString();
            orderTotal.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String orderId = orderID.Text;
            String customer = orderCustomerID.Text;
            String total = orderTotal.Text;
            String orderdate = orderDate.Text.ToString();

            try
            {
                if (String.IsNullOrEmpty(customer))
                {
                    MessageBox.Show("Please Select Customer");
                }
                else if (String.IsNullOrEmpty(total))
                {
                    MessageBox.Show("Please Select Products");
                }
                else
                {
                    con.Open();
                    String query = "insert into OrderTb(orderid,customer,total,orderdate) values(@orderid, @customer, @total, @orderdate)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@orderid", orderId);
                    cmd.Parameters.Add("@customer", customer);
                    cmd.Parameters.Add("@total", total);
                    cmd.Parameters.Add("@orderdate", orderdate);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Adding Success");

                    orderID.Clear();
                    orderCustomerID.Clear();
                    orderTotal.Clear();

                    con.Close();

                    loadCatId();
                    populateProduct();
                    populateCustomer();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                orderID.Clear();
                orderCustomerID.Clear();
                orderTotal.Clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            orderID.Clear();
            orderCustomerID.Clear();
            orderTotal.Clear();
            quentity.Clear();
            dataGridView7.Rows.Clear();

            loadCatId();
            populateProduct();
            populateCustomer();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView7.SelectedRows)
            {
                dataGridView7.Rows.RemoveAt(item.Index);

                String productId = dataGridView7.SelectedRows[1].Cells[0].Value.ToString();
                int productIds = int.Parse(productId);
                int productqtys = 0;

                try
                {

                    con.Open();
                    String query = "SELECT product_qty FROM ProductTb WHERE pid = @pid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@pid", productIds);
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        productqtys = int.Parse(sdr.GetValue(3).ToString());   
                    }
                    con.Close();

                }
                catch
                {

                }

                try
                {

                    con.Open();
                    String query = "UPDATE ProductTb SET product_qty = @product_qty WHERE pid = @pid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@product_qty", productqtys + 1);
                    cmd.Parameters.Add("@pid", item.Index);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    populateProduct();
                    populateCustomer();


                }
                catch
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderList orderList = new OrderList();  
            orderList.Visible = true;
            this.Visible = false;
        }

        void populateProduct()
        {
            try
            {
                con.Open();
                String selectallquery = "SELECT * FROM ProductTb";
                SqlDataAdapter adapter = new SqlDataAdapter(selectallquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView5.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        void loadCatId()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=KANIYA\SQLEXPRESS;Initial Catalog=inventrydb;Integrated Security=True");
                con.Open();
                String query = "SELECT orderid FROM OrderTb";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    if(sdr.GetValue(0).ToString() == null)
                    {
                        orderID.Text = "1";
                    }
                    else
                    {
                        orderID.Text = (int.Parse(sdr.GetValue(0).ToString()) + 1).ToString();
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        void populateCustomer()
        {
            try
            {
                con.Open();
                String selectallquery = "SELECT * FROM CustomerTb";
                SqlDataAdapter adapter = new SqlDataAdapter(selectallquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView6.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }
    }
}
