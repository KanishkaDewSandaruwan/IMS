namespace IMS
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inventrydbDataSet2 = new IMS.inventrydbDataSet2();
            this.label8 = new System.Windows.Forms.Label();
            this.pCategory = new System.Windows.Forms.ComboBox();
            this.pDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventrydbDataSet4 = new IMS.inventrydbDataSet4();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.catTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.catTbTableAdapter = new IMS.inventrydbDataSet2TableAdapters.CatTbTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.Catsearch = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.productTbTableAdapter = new IMS.inventrydbDataSet3TableAdapters.ProductTbTableAdapter();
            this.inventrydbDataSet3 = new IMS.inventrydbDataSet3();
            this.productTbTableAdapter1 = new IMS.inventrydbDataSet4TableAdapters.ProductTbTableAdapter();
            this.productTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventrydbDataSet2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventrydbDataSet4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catTbBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventrydbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventrydbDataSet2
            // 
            this.inventrydbDataSet2.DataSetName = "inventrydbDataSet2";
            this.inventrydbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Product Category";
            // 
            // pCategory
            // 
            this.pCategory.FormattingEnabled = true;
            this.pCategory.Location = new System.Drawing.Point(23, 294);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(179, 21);
            this.pCategory.TabIndex = 15;
            // 
            // pDescription
            // 
            this.pDescription.Location = new System.Drawing.Point(23, 244);
            this.pDescription.Name = "pDescription";
            this.pDescription.Size = new System.Drawing.Size(179, 20);
            this.pDescription.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description";
            // 
            // pQty
            // 
            this.pQty.Location = new System.Drawing.Point(23, 189);
            this.pQty.Name = "pQty";
            this.pQty.Size = new System.Drawing.Size(179, 20);
            this.pQty.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qty";
            // 
            // pPrice
            // 
            this.pPrice.Location = new System.Drawing.Point(23, 137);
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(179, 20);
            this.pPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price\r\n";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(271, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(744, 442);
            this.panel5.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.productqtyDataGridViewTextBoxColumn,
            this.productdescriptionDataGridViewTextBoxColumn,
            this.productcategoryDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.productTbBindingSource1;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(744, 442);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView4_RowHeaderMouseClick);
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "pid";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "product_price";
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            // 
            // productqtyDataGridViewTextBoxColumn
            // 
            this.productqtyDataGridViewTextBoxColumn.DataPropertyName = "product_qty";
            this.productqtyDataGridViewTextBoxColumn.HeaderText = "product_qty";
            this.productqtyDataGridViewTextBoxColumn.Name = "productqtyDataGridViewTextBoxColumn";
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            this.productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "product_description";
            this.productdescriptionDataGridViewTextBoxColumn.HeaderText = "product_description";
            this.productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            // 
            // productcategoryDataGridViewTextBoxColumn
            // 
            this.productcategoryDataGridViewTextBoxColumn.DataPropertyName = "product_category";
            this.productcategoryDataGridViewTextBoxColumn.HeaderText = "product_category";
            this.productcategoryDataGridViewTextBoxColumn.Name = "productcategoryDataGridViewTextBoxColumn";
            // 
            // productTbBindingSource1
            // 
            this.productTbBindingSource1.DataMember = "ProductTb";
            this.productTbBindingSource1.DataSource = this.inventrydbDataSet4;
            // 
            // inventrydbDataSet4
            // 
            this.inventrydbDataSet4.DataSetName = "inventrydbDataSet4";
            this.inventrydbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 442);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.pCategory);
            this.panel4.Controls.Add(this.pDescription);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pQty);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pPrice);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.pName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pID);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 442);
            this.panel4.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(132, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(23, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(132, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(23, 85);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(179, 20);
            this.pName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
            // 
            // pID
            // 
            this.pID.Enabled = false;
            this.pID.Location = new System.Drawing.Point(23, 30);
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(179, 20);
            this.pID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product ID";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(12, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 43);
            this.button5.TabIndex = 9;
            this.button5.Text = "Go to Home";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(702, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Products Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(542, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "INVENTORY MANAGMENT SYSTEM";
            // 
            // catTbBindingSource
            // 
            this.catTbBindingSource.DataMember = "CatTb";
            this.catTbBindingSource.DataSource = this.inventrydbDataSet2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 100);
            this.panel1.TabIndex = 6;
            // 
            // catTbTableAdapter
            // 
            this.catTbTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.Catsearch);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 100);
            this.panel2.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 42);
            this.button7.TabIndex = 20;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Catsearch
            // 
            this.Catsearch.FormattingEnabled = true;
            this.Catsearch.Location = new System.Drawing.Point(12, 9);
            this.Catsearch.Name = "Catsearch";
            this.Catsearch.Size = new System.Drawing.Size(179, 21);
            this.Catsearch.TabIndex = 19;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(197, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 25);
            this.button6.TabIndex = 18;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // productTbTableAdapter
            // 
            this.productTbTableAdapter.ClearBeforeFill = true;
            // 
            // inventrydbDataSet3
            // 
            this.inventrydbDataSet3.DataSetName = "inventrydbDataSet3";
            this.inventrydbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTbTableAdapter1
            // 
            this.productTbTableAdapter1.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 642);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Mange";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventrydbDataSet2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventrydbDataSet4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catTbBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventrydbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private inventrydbDataSet2 inventrydbDataSet2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox pCategory;
        private System.Windows.Forms.TextBox pDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource productTbBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource catTbBindingSource;
        private System.Windows.Forms.Panel panel1;
        private inventrydbDataSet2TableAdapters.CatTbTableAdapter catTbTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private inventrydbDataSet3TableAdapters.ProductTbTableAdapter productTbTableAdapter;
        private inventrydbDataSet3 inventrydbDataSet3;
        private inventrydbDataSet4 inventrydbDataSet4;
        private System.Windows.Forms.BindingSource productTbBindingSource1;
        private inventrydbDataSet4TableAdapters.ProductTbTableAdapter productTbTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox Catsearch;
        private System.Windows.Forms.Button button6;
    }
}