using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            this.Visible = false;
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventrydbDataSet7.OrderTb' table. You can move, or remove it, as needed.
            this.orderTbTableAdapter.Fill(this.inventrydbDataSet7.OrderTb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Visible = true;
            this.Visible=false;
        }
    }
}
