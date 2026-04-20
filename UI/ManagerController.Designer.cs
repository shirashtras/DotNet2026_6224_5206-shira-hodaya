
namespace UI
{
    partial class ManagerController
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private DataGridView GetDataGridView1()
        {
            return dataGridView1;
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.CreatetabControl1 = new System.Windows.Forms.TabControl();
            this.ViewOneTabPage1 = new System.Windows.Forms.TabPage();
            this.labelDetails = new System.Windows.Forms.Label();
            this.ShowButton1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.ViewAllTabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CreateTabPage3 = new System.Windows.Forms.TabPage();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.Customer_Idlabel3 = new System.Windows.Forms.Label();
            this.IdtextBox4 = new System.Windows.Forms.TextBox();
            this.Customer_Namelabel1 = new System.Windows.Forms.Label();
            this.Customer_NametextBox2 = new System.Windows.Forms.TextBox();
            this.AddresstextBox2label1 = new System.Windows.Forms.Label();
            this.AddresstextBox2 = new System.Windows.Forms.TextBox();
            this.PhoneLabel2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panelSale = new System.Windows.Forms.Panel();
            this.Date_Start_Salelabel4 = new System.Windows.Forms.Label();
            this.Date_Start_SaletextBox2 = new System.Windows.Forms.TextBox();
            this.Date_End_Sale = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Count_Salelabel9 = new System.Windows.Forms.Label();
            this.Count_SaletextBox7 = new System.Windows.Forms.TextBox();
            this.If_All_Customerslabel8 = new System.Windows.Forms.Label();
            this.If_All_CustomerstextBox8 = new System.Windows.Forms.TextBox();
            this.Price_SaleLabel9 = new System.Windows.Forms.Label();
            this.Price_SaleTextBox9 = new System.Windows.Forms.TextBox();
            this.ProductIdlINsALEabel10 = new System.Windows.Forms.Label();
            this.ProductIdtextBox10 = new System.Windows.Forms.TextBox();
            this.SaleIdtextBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.Product_Namelabel6 = new System.Windows.Forms.Label();
            this.ProductNametextBox6 = new System.Windows.Forms.TextBox();
            this.ProductPricelabel5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ProductCountlabel4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductIDtextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductCategoriescomboBox1 = new System.Windows.Forms.ComboBox();
            this.DeleteTabPage1 = new System.Windows.Forms.TabPage();
            this.UpdateTabPage1 = new System.Windows.Forms.TabPage();
            this.OrderByPriceSaleBtn = new System.Windows.Forms.Button();
            this.OrderByCityBtn = new System.Windows.Forms.Button();
            this.OrderByPriceBtn = new System.Windows.Forms.Button();
            this.CreatetabControl1.SuspendLayout();
            this.ViewOneTabPage1.SuspendLayout();
            this.ViewAllTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CreateTabPage3.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelSale.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatetabControl1
            // 
            this.CreatetabControl1.Controls.Add(this.ViewOneTabPage1);
            this.CreatetabControl1.Controls.Add(this.ViewAllTabPage2);
            this.CreatetabControl1.Controls.Add(this.CreateTabPage3);
            this.CreatetabControl1.Controls.Add(this.DeleteTabPage1);
            this.CreatetabControl1.Controls.Add(this.UpdateTabPage1);
            this.CreatetabControl1.Location = new System.Drawing.Point(11, 16);
            this.CreatetabControl1.Name = "CreatetabControl1";
            this.CreatetabControl1.SelectedIndex = 0;
            this.CreatetabControl1.Size = new System.Drawing.Size(800, 545);
            this.CreatetabControl1.TabIndex = 0;
            this.CreatetabControl1.SelectedIndexChanged += new System.EventHandler(this.CreatetabControl1_SelectedIndexChanged);
            // 
            // ViewOneTabPage1
            // 
            this.ViewOneTabPage1.Controls.Add(this.labelDetails);
            this.ViewOneTabPage1.Controls.Add(this.ShowButton1);
            this.ViewOneTabPage1.Controls.Add(this.textBox1);
            this.ViewOneTabPage1.Controls.Add(this.IdLabel1);
            this.ViewOneTabPage1.Location = new System.Drawing.Point(4, 29);
            this.ViewOneTabPage1.Name = "ViewOneTabPage1";
            this.ViewOneTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.ViewOneTabPage1.Size = new System.Drawing.Size(792, 512);
            this.ViewOneTabPage1.TabIndex = 0;
            this.ViewOneTabPage1.Text = "View One";
            this.ViewOneTabPage1.UseVisualStyleBackColor = true;
            this.ViewOneTabPage1.Click += new System.EventHandler(this.ViewOneTabPage1_Click);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(313, 276);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(0, 20);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowButton1
            // 
            this.ShowButton1.Location = new System.Drawing.Point(313, 170);
            this.ShowButton1.Name = "ShowButton1";
            this.ShowButton1.Size = new System.Drawing.Size(94, 29);
            this.ShowButton1.TabIndex = 2;
            this.ShowButton1.Text = "Show";
            this.ShowButton1.UseVisualStyleBackColor = true;
            this.ShowButton1.Click += new System.EventHandler(this.ShowButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 27);
            this.textBox1.TabIndex = 1;
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Location = new System.Drawing.Point(197, 91);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(22, 20);
            this.IdLabel1.TabIndex = 0;
            this.IdLabel1.Text = "Id";
            // 
            // ViewAllTabPage2
            // 
            this.ViewAllTabPage2.Controls.Add(this.dataGridView1);
            this.ViewAllTabPage2.Location = new System.Drawing.Point(4, 29);
            this.ViewAllTabPage2.Name = "ViewAllTabPage2";
            this.ViewAllTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.ViewAllTabPage2.Size = new System.Drawing.Size(792, 512);
            this.ViewAllTabPage2.TabIndex = 1;
            this.ViewAllTabPage2.Text = "View All";
            this.ViewAllTabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(786, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // CreateTabPage3
            // 
            this.CreateTabPage3.Controls.Add(this.SubmitBtn);
            this.CreateTabPage3.Controls.Add(this.panelCustomer);
            this.CreateTabPage3.Controls.Add(this.panelSale);
            this.CreateTabPage3.Controls.Add(this.panelProduct);
            this.CreateTabPage3.Location = new System.Drawing.Point(4, 29);
            this.CreateTabPage3.Name = "CreateTabPage3";
            this.CreateTabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.CreateTabPage3.Size = new System.Drawing.Size(792, 512);
            this.CreateTabPage3.TabIndex = 2;
            this.CreateTabPage3.Text = "Create";
            this.CreateTabPage3.UseVisualStyleBackColor = true;
            this.CreateTabPage3.Click += new System.EventHandler(this.CreateTabPage3_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(350, 450);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(94, 29);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomer.Controls.Add(this.Customer_Idlabel3);
            this.panelCustomer.Controls.Add(this.IdtextBox4);
            this.panelCustomer.Controls.Add(this.Customer_Namelabel1);
            this.panelCustomer.Controls.Add(this.Customer_NametextBox2);
            this.panelCustomer.Controls.Add(this.AddresstextBox2label1);
            this.panelCustomer.Controls.Add(this.AddresstextBox2);
            this.panelCustomer.Controls.Add(this.PhoneLabel2);
            this.panelCustomer.Controls.Add(this.textBox3);
            this.panelCustomer.Location = new System.Drawing.Point(531, 20);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(240, 400);
            this.panelCustomer.TabIndex = 2;
            // 
            // Customer_Idlabel3
            // 
            this.Customer_Idlabel3.AutoSize = true;
            this.Customer_Idlabel3.Location = new System.Drawing.Point(10, 20);
            this.Customer_Idlabel3.Name = "Customer_Idlabel3";
            this.Customer_Idlabel3.Size = new System.Drawing.Size(22, 20);
            this.Customer_Idlabel3.TabIndex = 0;
            this.Customer_Idlabel3.Text = "Id";
            // 
            // IdtextBox4
            // 
            this.IdtextBox4.Location = new System.Drawing.Point(90, 17);
            this.IdtextBox4.Name = "IdtextBox4";
            this.IdtextBox4.Size = new System.Drawing.Size(130, 27);
            this.IdtextBox4.TabIndex = 1;
            // 
            // Customer_Namelabel1
            // 
            this.Customer_Namelabel1.AutoSize = true;
            this.Customer_Namelabel1.Location = new System.Drawing.Point(10, 65);
            this.Customer_Namelabel1.Name = "Customer_Namelabel1";
            this.Customer_Namelabel1.Size = new System.Drawing.Size(49, 20);
            this.Customer_Namelabel1.TabIndex = 2;
            this.Customer_Namelabel1.Text = "Name";
            // 
            // Customer_NametextBox2
            // 
            this.Customer_NametextBox2.Location = new System.Drawing.Point(90, 62);
            this.Customer_NametextBox2.Name = "Customer_NametextBox2";
            this.Customer_NametextBox2.Size = new System.Drawing.Size(130, 27);
            this.Customer_NametextBox2.TabIndex = 3;
            // 
            // AddresstextBox2label1
            // 
            this.AddresstextBox2label1.AutoSize = true;
            this.AddresstextBox2label1.Location = new System.Drawing.Point(10, 110);
            this.AddresstextBox2label1.Name = "AddresstextBox2label1";
            this.AddresstextBox2label1.Size = new System.Drawing.Size(60, 20);
            this.AddresstextBox2label1.TabIndex = 4;
            this.AddresstextBox2label1.Text = "Address";
            // 
            // AddresstextBox2
            // 
            this.AddresstextBox2.Location = new System.Drawing.Point(90, 107);
            this.AddresstextBox2.Name = "AddresstextBox2";
            this.AddresstextBox2.Size = new System.Drawing.Size(130, 27);
            this.AddresstextBox2.TabIndex = 5;
            // 
            // PhoneLabel2
            // 
            this.PhoneLabel2.AutoSize = true;
            this.PhoneLabel2.Location = new System.Drawing.Point(10, 155);
            this.PhoneLabel2.Name = "PhoneLabel2";
            this.PhoneLabel2.Size = new System.Drawing.Size(50, 20);
            this.PhoneLabel2.TabIndex = 6;
            this.PhoneLabel2.Text = "Phone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 27);
            this.textBox3.TabIndex = 7;
            // 
            // panelSale
            // 
            this.panelSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSale.Controls.Add(this.Date_Start_Salelabel4);
            this.panelSale.Controls.Add(this.Date_Start_SaletextBox2);
            this.panelSale.Controls.Add(this.Date_End_Sale);
            this.panelSale.Controls.Add(this.textBox8);
            this.panelSale.Controls.Add(this.Count_Salelabel9);
            this.panelSale.Controls.Add(this.Count_SaletextBox7);
            this.panelSale.Controls.Add(this.If_All_Customerslabel8);
            this.panelSale.Controls.Add(this.If_All_CustomerstextBox8);
            this.panelSale.Controls.Add(this.Price_SaleLabel9);
            this.panelSale.Controls.Add(this.Price_SaleTextBox9);
            this.panelSale.Controls.Add(this.ProductIdlINsALEabel10);
            this.panelSale.Controls.Add(this.ProductIdtextBox10);
            this.panelSale.Controls.Add(this.label7);
            this.panelSale.Controls.Add(this.SaleIdtextBox7);
            this.panelSale.Location = new System.Drawing.Point(271, 20);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(240, 400);
            this.panelSale.TabIndex = 1;
            // 
            // Date_Start_Salelabel4
            // 
            this.Date_Start_Salelabel4.AutoSize = true;
            this.Date_Start_Salelabel4.Location = new System.Drawing.Point(10, 65);
            this.Date_Start_Salelabel4.Name = "Date_Start_Salelabel4";
            this.Date_Start_Salelabel4.Size = new System.Drawing.Size(77, 20);
            this.Date_Start_Salelabel4.TabIndex = 2;
            this.Date_Start_Salelabel4.Text = "Start Date";
            // 
            // Date_Start_SaletextBox2
            // 
            this.Date_Start_SaletextBox2.Location = new System.Drawing.Point(120, 62);
            this.Date_Start_SaletextBox2.Name = "Date_Start_SaletextBox2";
            this.Date_Start_SaletextBox2.Size = new System.Drawing.Size(100, 27);
            this.Date_Start_SaletextBox2.TabIndex = 3;
            // 
            // Date_End_Sale
            // 
            this.Date_End_Sale.AutoSize = true;
            this.Date_End_Sale.Location = new System.Drawing.Point(10, 110);
            this.Date_End_Sale.Name = "Date_End_Sale";
            this.Date_End_Sale.Size = new System.Drawing.Size(71, 20);
            this.Date_End_Sale.TabIndex = 4;
            this.Date_End_Sale.Text = "End Date";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(120, 107);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 27);
            this.textBox8.TabIndex = 5;
            // 
            // Count_Salelabel9
            // 
            this.Count_Salelabel9.AutoSize = true;
            this.Count_Salelabel9.Location = new System.Drawing.Point(10, 155);
            this.Count_Salelabel9.Name = "Count_Salelabel9";
            this.Count_Salelabel9.Size = new System.Drawing.Size(49, 20);
            this.Count_Salelabel9.TabIndex = 6;
            this.Count_Salelabel9.Text = "Count";
            // 
            // Count_SaletextBox7
            // 
            this.Count_SaletextBox7.Location = new System.Drawing.Point(120, 152);
            this.Count_SaletextBox7.Name = "Count_SaletextBox7";
            this.Count_SaletextBox7.Size = new System.Drawing.Size(100, 27);
            this.Count_SaletextBox7.TabIndex = 7;
            // 
            // If_All_Customerslabel8
            // 
            this.If_All_Customerslabel8.AutoSize = true;
            this.If_All_Customerslabel8.Location = new System.Drawing.Point(10, 245);
            this.If_All_Customerslabel8.Name = "If_All_Customerslabel8";
            this.If_All_Customerslabel8.Size = new System.Drawing.Size(104, 20);
            this.If_All_Customerslabel8.TabIndex = 10;
            this.If_All_Customerslabel8.Text = "All Customers?";
            // 
            // If_All_CustomerstextBox8
            // 
            this.If_All_CustomerstextBox8.Location = new System.Drawing.Point(120, 242);
            this.If_All_CustomerstextBox8.Name = "If_All_CustomerstextBox8";
            this.If_All_CustomerstextBox8.Size = new System.Drawing.Size(100, 27);
            this.If_All_CustomerstextBox8.TabIndex = 11;
            // 
            // Price_SaleLabel9
            // 
            this.Price_SaleLabel9.AutoSize = true;
            this.Price_SaleLabel9.Location = new System.Drawing.Point(10, 200);
            this.Price_SaleLabel9.Name = "Price_SaleLabel9";
            this.Price_SaleLabel9.Size = new System.Drawing.Size(41, 20);
            this.Price_SaleLabel9.TabIndex = 8;
            this.Price_SaleLabel9.Text = "Price";
            // 
            // Price_SaleTextBox9
            // 
            this.Price_SaleTextBox9.Location = new System.Drawing.Point(120, 197);
            this.Price_SaleTextBox9.Name = "Price_SaleTextBox9";
            this.Price_SaleTextBox9.Size = new System.Drawing.Size(100, 27);
            this.Price_SaleTextBox9.TabIndex = 9;
            // 
            // ProductIdlINsALEabel10
            // 
            this.ProductIdlINsALEabel10.AutoSize = true;
            this.ProductIdlINsALEabel10.Location = new System.Drawing.Point(10, 290);
            this.ProductIdlINsALEabel10.Name = "ProductIdlINsALEabel10";
            this.ProductIdlINsALEabel10.Size = new System.Drawing.Size(77, 20);
            this.ProductIdlINsALEabel10.TabIndex = 12;
            this.ProductIdlINsALEabel10.Text = "Product Id";
            // 
            // ProductIdtextBox10
            // 
            this.ProductIdtextBox10.Location = new System.Drawing.Point(120, 287);
            this.ProductIdtextBox10.Name = "ProductIdtextBox10";
            this.ProductIdtextBox10.Size = new System.Drawing.Size(100, 27);
            this.ProductIdtextBox10.TabIndex = 13;
            // 
            // label7 (Sale Id)
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sale Id";
            // 
            // SaleIdtextBox7
            // 
            this.SaleIdtextBox7.Location = new System.Drawing.Point(120, 17);
            this.SaleIdtextBox7.Name = "SaleIdtextBox7";
            this.SaleIdtextBox7.Size = new System.Drawing.Size(100, 27);
            this.SaleIdtextBox7.TabIndex = 1;
            // 
            // panelProduct
            // 
            this.panelProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduct.Controls.Add(this.Product_Namelabel6);
            this.panelProduct.Controls.Add(this.ProductNametextBox6);
            this.panelProduct.Controls.Add(this.ProductPricelabel5);
            this.panelProduct.Controls.Add(this.textBox5);
            this.panelProduct.Controls.Add(this.ProductCountlabel4);
            this.panelProduct.Controls.Add(this.textBox4);
            this.panelProduct.Controls.Add(this.label2);
            this.panelProduct.Controls.Add(this.ProductIDtextBox2);
            this.panelProduct.Controls.Add(this.label5);
            this.panelProduct.Controls.Add(this.ProductCategoriescomboBox1);
            this.panelProduct.Location = new System.Drawing.Point(11, 20);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(240, 400);
            this.panelProduct.TabIndex = 0;
            // 
            // Product_Namelabel6
            // 
            this.Product_Namelabel6.AutoSize = true;
            this.Product_Namelabel6.Location = new System.Drawing.Point(10, 65);
            this.Product_Namelabel6.Name = "Product_Namelabel6";
            this.Product_Namelabel6.Size = new System.Drawing.Size(49, 20);
            this.Product_Namelabel6.TabIndex = 2;
            this.Product_Namelabel6.Text = "Name";
            // 
            // ProductNametextBox6
            // 
            this.ProductNametextBox6.Location = new System.Drawing.Point(110, 62);
            this.ProductNametextBox6.Name = "ProductNametextBox6";
            this.ProductNametextBox6.Size = new System.Drawing.Size(110, 27);
            this.ProductNametextBox6.TabIndex = 3;
            // 
            // ProductPricelabel5
            // 
            this.ProductPricelabel5.AutoSize = true;
            this.ProductPricelabel5.Location = new System.Drawing.Point(10, 110);
            this.ProductPricelabel5.Name = "ProductPricelabel5";
            this.ProductPricelabel5.Size = new System.Drawing.Size(41, 20);
            this.ProductPricelabel5.TabIndex = 4;
            this.ProductPricelabel5.Text = "Price";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(110, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 27);
            this.textBox5.TabIndex = 5;
            // 
            // ProductCountlabel4
            // 
            this.ProductCountlabel4.AutoSize = true;
            this.ProductCountlabel4.Location = new System.Drawing.Point(10, 155);
            this.ProductCountlabel4.Name = "ProductCountlabel4";
            this.ProductCountlabel4.Size = new System.Drawing.Size(49, 20);
            this.ProductCountlabel4.TabIndex = 6;
            this.ProductCountlabel4.Text = "Count";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 27);
            this.textBox4.TabIndex = 7;
            // 
            // label2 (Product Id)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // ProductIDtextBox2
            // 
            this.ProductIDtextBox2.Location = new System.Drawing.Point(110, 17);
            this.ProductIDtextBox2.Name = "ProductIDtextBox2";
            this.ProductIDtextBox2.Size = new System.Drawing.Size(110, 27);
            this.ProductIDtextBox2.TabIndex = 1;
            // 
            // label5 (Category)
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category";
            // 
            // ProductCategoriescomboBox1
            // 
            this.ProductCategoriescomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategoriescomboBox1.FormattingEnabled = true;
            this.ProductCategoriescomboBox1.Location = new System.Drawing.Point(110, 197);
            this.ProductCategoriescomboBox1.Name = "ProductCategoriescomboBox1";
            this.ProductCategoriescomboBox1.Size = new System.Drawing.Size(110, 28);
            this.ProductCategoriescomboBox1.TabIndex = 9;
            this.ProductCategoriescomboBox1.SelectedIndexChanged += new System.EventHandler(this.ProductCategoriescomboBox1_SelectedIndexChanged);
            // 
            // DeleteTabPage1
            // 
            this.DeleteTabPage1.Location = new System.Drawing.Point(4, 29);
            this.DeleteTabPage1.Name = "DeleteTabPage1";
            this.DeleteTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteTabPage1.Size = new System.Drawing.Size(792, 512);
            this.DeleteTabPage1.TabIndex = 3;
            this.DeleteTabPage1.Text = "Delete";
            this.DeleteTabPage1.UseVisualStyleBackColor = true;
            // 
            // UpdateTabPage1
            // 
            this.UpdateTabPage1.Location = new System.Drawing.Point(4, 29);
            this.UpdateTabPage1.Name = "UpdateTabPage1";
            this.UpdateTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTabPage1.Size = new System.Drawing.Size(792, 512);
            this.UpdateTabPage1.TabIndex = 4;
            this.UpdateTabPage1.Text = "Update";
            this.UpdateTabPage1.UseVisualStyleBackColor = true;
            // 
            // OrderByPriceSaleBtn
            // 
            this.OrderByPriceSaleBtn.Location = new System.Drawing.Point(810, 375);
            this.OrderByPriceSaleBtn.Name = "OrderByPriceSaleBtn";
            this.OrderByPriceSaleBtn.Size = new System.Drawing.Size(107, 123);
            this.OrderByPriceSaleBtn.TabIndex = 3;
            this.OrderByPriceSaleBtn.Text = "מיין לפי מחיר מבצע מהגדול לקטן";
            this.OrderByPriceSaleBtn.UseVisualStyleBackColor = true;
            this.OrderByPriceSaleBtn.Click += new System.EventHandler(this.OrderByPriceSaleBtn_Click);
            // 
            // OrderByCityBtn
            // 
            this.OrderByCityBtn.Location = new System.Drawing.Point(817, 61);
            this.OrderByCityBtn.Name = "OrderByCityBtn";
            this.OrderByCityBtn.Size = new System.Drawing.Size(85, 103);
            this.OrderByCityBtn.TabIndex = 1;
            this.OrderByCityBtn.Text = "מיין עפ\"י ערים";
            this.OrderByCityBtn.UseVisualStyleBackColor = true;
            this.OrderByCityBtn.Click += new System.EventHandler(this.OrderByCityBtn_Click);
            // 
            // OrderByPriceBtn
            // 
            this.OrderByPriceBtn.Location = new System.Drawing.Point(817, 189);
            this.OrderByPriceBtn.Name = "OrderByPriceBtn";
            this.OrderByPriceBtn.Size = new System.Drawing.Size(75, 158);
            this.OrderByPriceBtn.TabIndex = 2;
            this.OrderByPriceBtn.Text = "מיין לפי מחיר מוצר מהקטן לגדול";
            this.OrderByPriceBtn.UseVisualStyleBackColor = true;
            this.OrderByPriceBtn.Click += new System.EventHandler(this.OrderByPriceBtn_Click);
            // 
            // ManagerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.OrderByPriceSaleBtn);
            this.Controls.Add(this.OrderByPriceBtn);
            this.Controls.Add(this.OrderByCityBtn);
            this.Controls.Add(this.CreatetabControl1);
            this.Name = "ManagerController";
            this.Text = "ManagerController";
            this.Load += new System.EventHandler(this.ManagerController_Load);
            this.CreatetabControl1.ResumeLayout(false);
            this.ViewOneTabPage1.ResumeLayout(false);
            this.ViewOneTabPage1.PerformLayout();
            this.ViewAllTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CreateTabPage3.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelSale.ResumeLayout(false);
            this.panelSale.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.ResumeLayout(false);
        }

        private void ProductCategoriescomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

      

        private void CreateTabPage3_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ViewOneTabPage1_Click(object sender, EventArgs e)
        {
        }

        private void CreatetabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CreatetabControl1.SelectedTab == CreateTabPage3)
            {
                HideAllPanels();

                switch (type)
                {
                    case Types.PRODUCT:
                        panelProduct.Show();
                        break;

                    case Types.SALE:
                        panelSale.Show();
                        break;

                    case Types.CUSTOMER:
                        panelCustomer.Show();
                        break;
                }

                AdjustIdFields();
            }
        }


        #endregion

        private System.Windows.Forms.TabControl CreatetabControl1;
        private System.Windows.Forms.TabPage ViewOneTabPage1;
        private System.Windows.Forms.TabPage ViewAllTabPage2;
        private System.Windows.Forms.TabPage CreateTabPage3;
        private System.Windows.Forms.TabPage DeleteTabPage1;
        private System.Windows.Forms.TabPage UpdateTabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.Button ShowButton1;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Button OrderByCityBtn;
        private System.Windows.Forms.Button OrderByPriceSaleBtn;
        private System.Windows.Forms.Button OrderByPriceBtn;
        private System.Windows.Forms.Panel panelSale;
        private System.Windows.Forms.Label Date_Start_Salelabel4;
        private System.Windows.Forms.TextBox Date_Start_SaletextBox2;
        private System.Windows.Forms.Label Count_Salelabel9;
        private System.Windows.Forms.TextBox Count_SaletextBox7;
        private System.Windows.Forms.Label Date_End_Sale;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProductCategoriescomboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SaleIdtextBox7;
        private System.Windows.Forms.Label If_All_Customerslabel8;
        private System.Windows.Forms.TextBox If_All_CustomerstextBox8;
        private System.Windows.Forms.Label Price_SaleLabel9;
        private System.Windows.Forms.TextBox Price_SaleTextBox9;
        private System.Windows.Forms.Label ProductIdlINsALEabel10;
        private System.Windows.Forms.TextBox ProductIdtextBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductIDtextBox2;
        private System.Windows.Forms.Label ProductCountlabel4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ProductPricelabel5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Product_Namelabel6;
        private System.Windows.Forms.TextBox ProductNametextBox6;
        private System.Windows.Forms.Label Customer_Idlabel3;
        private System.Windows.Forms.TextBox IdtextBox4;
        private System.Windows.Forms.Label PhoneLabel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label AddresstextBox2label1;
        private System.Windows.Forms.TextBox AddresstextBox2;
        private System.Windows.Forms.Label Customer_Namelabel1;
        private System.Windows.Forms.TextBox Customer_NametextBox2;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Button SubmitBtn;
    }
}
