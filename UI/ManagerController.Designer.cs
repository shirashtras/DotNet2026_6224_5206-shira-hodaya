
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
            CreatetabControl1 = new TabControl();
            ViewOneTabPage1 = new TabPage();
            labelDetails = new Label();
            ShowButton1 = new Button();
            textBox1 = new TextBox();
            IdLabel1 = new Label();
            ViewAllTabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            CreateTabPage3 = new TabPage();
            SubmitBtn = new Button();
            panelCustomer = new Panel();
            Customer_Idlabel3 = new Label();
            IdtextBox4 = new TextBox();
            Customer_Namelabel1 = new Label();
            Customer_NametextBox2 = new TextBox();
            AddresstextBox2label1 = new Label();
            AddresstextBox2 = new TextBox();
            PhoneLabel2 = new Label();
            textBox3 = new TextBox();
            panelSale = new Panel();
            Date_Start_Salelabel4 = new Label();
            Date_Start_SaletextBox2 = new TextBox();
            Date_End_Sale = new Label();
            textBox8 = new TextBox();
            Count_Salelabel9 = new Label();
            Count_SaletextBox7 = new TextBox();
            If_All_Customerslabel8 = new Label();
            If_All_CustomerstextBox8 = new TextBox();
            Price_SaleLabel9 = new Label();
            Price_SaleTextBox9 = new TextBox();
            ProductIdlINsALEabel10 = new Label();
            ProductIdtextBox10 = new TextBox();
            label7 = new Label();
            SaleIdtextBox7 = new TextBox();
            panelProduct = new Panel();
            Product_Namelabel6 = new Label();
            ProductNametextBox6 = new TextBox();
            ProductPricelabel5 = new Label();
            textBox5 = new TextBox();
            ProductCountlabel4 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            ProductIDtextBox2 = new TextBox();
            label5 = new Label();
            ProductCategoriescomboBox1 = new ComboBox();
            DeleteTabPage1 = new TabPage();
            UpdateTabPage1 = new TabPage();
            updateBtn = new Button();
            panelUpdateCustomer = new Panel();
            label16 = new Label();
            textBox17 = new TextBox();
            label17 = new Label();
            textBox18 = new TextBox();
            label18 = new Label();
            textBox19 = new TextBox();
            label19 = new Label();
            textBox20 = new TextBox();
            panelUpdateSale = new Panel();
            label9 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            textBox11 = new TextBox();
            label11 = new Label();
            textBox12 = new TextBox();
            label12 = new Label();
            textBox13 = new TextBox();
            label13 = new Label();
            textBox14 = new TextBox();
            label14 = new Label();
            textBox15 = new TextBox();
            label15 = new Label();
            textBox16 = new TextBox();
            panelupdatePro = new Panel();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox9 = new TextBox();
            label8 = new Label();
            productComboBoxUpdate = new ComboBox();
            OrderByPriceSaleBtn = new Button();
            OrderByCityBtn = new Button();
            OrderByPriceBtn = new Button();
            CreatetabControl1.SuspendLayout();
            ViewOneTabPage1.SuspendLayout();
            ViewAllTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CreateTabPage3.SuspendLayout();
            panelCustomer.SuspendLayout();
            panelSale.SuspendLayout();
            panelProduct.SuspendLayout();
            UpdateTabPage1.SuspendLayout();
            panelUpdateCustomer.SuspendLayout();
            panelUpdateSale.SuspendLayout();
            panelupdatePro.SuspendLayout();
            SuspendLayout();
            // 
            // CreatetabControl1
            // 
            CreatetabControl1.Controls.Add(ViewOneTabPage1);
            CreatetabControl1.Controls.Add(ViewAllTabPage2);
            CreatetabControl1.Controls.Add(CreateTabPage3);
            CreatetabControl1.Controls.Add(DeleteTabPage1);
            CreatetabControl1.Controls.Add(UpdateTabPage1);
            CreatetabControl1.Location = new Point(13, 17);
            CreatetabControl1.Name = "CreatetabControl1";
            CreatetabControl1.SelectedIndex = 0;
            CreatetabControl1.Size = new Size(800, 545);
            CreatetabControl1.TabIndex = 0;
            CreatetabControl1.SelectedIndexChanged += CreatetabControl1_SelectedIndexChanged;
            // 
            // ViewOneTabPage1
            // 
            ViewOneTabPage1.Controls.Add(labelDetails);
            ViewOneTabPage1.Controls.Add(ShowButton1);
            ViewOneTabPage1.Controls.Add(textBox1);
            ViewOneTabPage1.Controls.Add(IdLabel1);
            ViewOneTabPage1.Location = new Point(4, 29);
            ViewOneTabPage1.Name = "ViewOneTabPage1";
            ViewOneTabPage1.Padding = new Padding(3);
            ViewOneTabPage1.Size = new Size(792, 512);
            ViewOneTabPage1.TabIndex = 0;
            ViewOneTabPage1.Text = "View One";
            ViewOneTabPage1.UseVisualStyleBackColor = true;
            ViewOneTabPage1.Click += ViewOneTabPage1_Click;
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Location = new Point(313, 276);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(0, 20);
            labelDetails.TabIndex = 3;
            labelDetails.Click += label1_Click;
            // 
            // ShowButton1
            // 
            ShowButton1.Location = new Point(313, 170);
            ShowButton1.Name = "ShowButton1";
            ShowButton1.Size = new Size(94, 29);
            ShowButton1.TabIndex = 2;
            ShowButton1.Text = "Show";
            ShowButton1.UseVisualStyleBackColor = true;
            ShowButton1.Click += ShowButton1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 1;
            // 
            // IdLabel1
            // 
            IdLabel1.AutoSize = true;
            IdLabel1.Location = new Point(197, 91);
            IdLabel1.Name = "IdLabel1";
            IdLabel1.Size = new Size(22, 20);
            IdLabel1.TabIndex = 0;
            IdLabel1.Text = "Id";
            // 
            // ViewAllTabPage2
            // 
            ViewAllTabPage2.Controls.Add(dataGridView1);
            ViewAllTabPage2.Location = new Point(4, 29);
            ViewAllTabPage2.Name = "ViewAllTabPage2";
            ViewAllTabPage2.Padding = new Padding(3);
            ViewAllTabPage2.Size = new Size(792, 512);
            ViewAllTabPage2.TabIndex = 1;
            ViewAllTabPage2.Text = "View All";
            ViewAllTabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(786, 506);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // CreateTabPage3
            // 
            CreateTabPage3.Controls.Add(SubmitBtn);
            CreateTabPage3.Controls.Add(panelCustomer);
            CreateTabPage3.Controls.Add(panelSale);
            CreateTabPage3.Controls.Add(panelProduct);
            CreateTabPage3.Location = new Point(4, 29);
            CreateTabPage3.Name = "CreateTabPage3";
            CreateTabPage3.Padding = new Padding(3);
            CreateTabPage3.Size = new Size(792, 512);
            CreateTabPage3.TabIndex = 2;
            CreateTabPage3.Text = "Create";
            CreateTabPage3.UseVisualStyleBackColor = true;
            CreateTabPage3.Click += CreateTabPage3_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(350, 450);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(94, 29);
            SubmitBtn.TabIndex = 3;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // panelCustomer
            // 
            panelCustomer.BorderStyle = BorderStyle.FixedSingle;
            panelCustomer.Controls.Add(Customer_Idlabel3);
            panelCustomer.Controls.Add(IdtextBox4);
            panelCustomer.Controls.Add(Customer_Namelabel1);
            panelCustomer.Controls.Add(Customer_NametextBox2);
            panelCustomer.Controls.Add(AddresstextBox2label1);
            panelCustomer.Controls.Add(AddresstextBox2);
            panelCustomer.Controls.Add(PhoneLabel2);
            panelCustomer.Controls.Add(textBox3);
            panelCustomer.Location = new Point(531, 20);
            panelCustomer.Name = "panelCustomer";
            panelCustomer.Size = new Size(240, 400);
            panelCustomer.TabIndex = 2;
            // 
            // Customer_Idlabel3
            // 
            Customer_Idlabel3.AutoSize = true;
            Customer_Idlabel3.Location = new Point(10, 20);
            Customer_Idlabel3.Name = "Customer_Idlabel3";
            Customer_Idlabel3.Size = new Size(22, 20);
            Customer_Idlabel3.TabIndex = 0;
            Customer_Idlabel3.Text = "Id";
            // 
            // IdtextBox4
            // 
            IdtextBox4.Location = new Point(90, 17);
            IdtextBox4.Name = "IdtextBox4";
            IdtextBox4.Size = new Size(130, 27);
            IdtextBox4.TabIndex = 1;
            // 
            // Customer_Namelabel1
            // 
            Customer_Namelabel1.AutoSize = true;
            Customer_Namelabel1.Location = new Point(10, 65);
            Customer_Namelabel1.Name = "Customer_Namelabel1";
            Customer_Namelabel1.Size = new Size(49, 20);
            Customer_Namelabel1.TabIndex = 2;
            Customer_Namelabel1.Text = "Name";
            // 
            // Customer_NametextBox2
            // 
            Customer_NametextBox2.Location = new Point(90, 62);
            Customer_NametextBox2.Name = "Customer_NametextBox2";
            Customer_NametextBox2.Size = new Size(130, 27);
            Customer_NametextBox2.TabIndex = 3;
            // 
            // AddresstextBox2label1
            // 
            AddresstextBox2label1.AutoSize = true;
            AddresstextBox2label1.Location = new Point(10, 110);
            AddresstextBox2label1.Name = "AddresstextBox2label1";
            AddresstextBox2label1.Size = new Size(62, 20);
            AddresstextBox2label1.TabIndex = 4;
            AddresstextBox2label1.Text = "Address";
            // 
            // AddresstextBox2
            // 
            AddresstextBox2.Location = new Point(90, 107);
            AddresstextBox2.Name = "AddresstextBox2";
            AddresstextBox2.Size = new Size(130, 27);
            AddresstextBox2.TabIndex = 5;
            // 
            // PhoneLabel2
            // 
            PhoneLabel2.AutoSize = true;
            PhoneLabel2.Location = new Point(10, 155);
            PhoneLabel2.Name = "PhoneLabel2";
            PhoneLabel2.Size = new Size(50, 20);
            PhoneLabel2.TabIndex = 6;
            PhoneLabel2.Text = "Phone";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(90, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 27);
            textBox3.TabIndex = 7;
            // 
            // panelSale
            // 
            panelSale.BorderStyle = BorderStyle.FixedSingle;
            panelSale.Controls.Add(Date_Start_Salelabel4);
            panelSale.Controls.Add(Date_Start_SaletextBox2);
            panelSale.Controls.Add(Date_End_Sale);
            panelSale.Controls.Add(textBox8);
            panelSale.Controls.Add(Count_Salelabel9);
            panelSale.Controls.Add(Count_SaletextBox7);
            panelSale.Controls.Add(If_All_Customerslabel8);
            panelSale.Controls.Add(If_All_CustomerstextBox8);
            panelSale.Controls.Add(Price_SaleLabel9);
            panelSale.Controls.Add(Price_SaleTextBox9);
            panelSale.Controls.Add(ProductIdlINsALEabel10);
            panelSale.Controls.Add(ProductIdtextBox10);
            panelSale.Controls.Add(label7);
            panelSale.Controls.Add(SaleIdtextBox7);
            panelSale.Location = new Point(271, 20);
            panelSale.Name = "panelSale";
            panelSale.Size = new Size(240, 400);
            panelSale.TabIndex = 1;
            // 
            // Date_Start_Salelabel4
            // 
            Date_Start_Salelabel4.AutoSize = true;
            Date_Start_Salelabel4.Location = new Point(10, 65);
            Date_Start_Salelabel4.Name = "Date_Start_Salelabel4";
            Date_Start_Salelabel4.Size = new Size(76, 20);
            Date_Start_Salelabel4.TabIndex = 2;
            Date_Start_Salelabel4.Text = "Start Date";
            // 
            // Date_Start_SaletextBox2
            // 
            Date_Start_SaletextBox2.Location = new Point(120, 62);
            Date_Start_SaletextBox2.Name = "Date_Start_SaletextBox2";
            Date_Start_SaletextBox2.Size = new Size(100, 27);
            Date_Start_SaletextBox2.TabIndex = 3;
            // 
            // Date_End_Sale
            // 
            Date_End_Sale.AutoSize = true;
            Date_End_Sale.Location = new Point(10, 110);
            Date_End_Sale.Name = "Date_End_Sale";
            Date_End_Sale.Size = new Size(70, 20);
            Date_End_Sale.TabIndex = 4;
            Date_End_Sale.Text = "End Date";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(120, 107);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 27);
            textBox8.TabIndex = 5;
            // 
            // Count_Salelabel9
            // 
            Count_Salelabel9.AutoSize = true;
            Count_Salelabel9.Location = new Point(10, 155);
            Count_Salelabel9.Name = "Count_Salelabel9";
            Count_Salelabel9.Size = new Size(48, 20);
            Count_Salelabel9.TabIndex = 6;
            Count_Salelabel9.Text = "Count";
            // 
            // Count_SaletextBox7
            // 
            Count_SaletextBox7.Location = new Point(120, 152);
            Count_SaletextBox7.Name = "Count_SaletextBox7";
            Count_SaletextBox7.Size = new Size(100, 27);
            Count_SaletextBox7.TabIndex = 7;
            // 
            // If_All_Customerslabel8
            // 
            If_All_Customerslabel8.AutoSize = true;
            If_All_Customerslabel8.Location = new Point(10, 245);
            If_All_Customerslabel8.Name = "If_All_Customerslabel8";
            If_All_Customerslabel8.Size = new Size(107, 20);
            If_All_Customerslabel8.TabIndex = 10;
            If_All_Customerslabel8.Text = "All Customers?";
            // 
            // If_All_CustomerstextBox8
            // 
            If_All_CustomerstextBox8.Location = new Point(120, 242);
            If_All_CustomerstextBox8.Name = "If_All_CustomerstextBox8";
            If_All_CustomerstextBox8.Size = new Size(100, 27);
            If_All_CustomerstextBox8.TabIndex = 11;
            // 
            // Price_SaleLabel9
            // 
            Price_SaleLabel9.AutoSize = true;
            Price_SaleLabel9.Location = new Point(10, 200);
            Price_SaleLabel9.Name = "Price_SaleLabel9";
            Price_SaleLabel9.Size = new Size(41, 20);
            Price_SaleLabel9.TabIndex = 8;
            Price_SaleLabel9.Text = "Price";
            // 
            // Price_SaleTextBox9
            // 
            Price_SaleTextBox9.Location = new Point(120, 197);
            Price_SaleTextBox9.Name = "Price_SaleTextBox9";
            Price_SaleTextBox9.Size = new Size(100, 27);
            Price_SaleTextBox9.TabIndex = 9;
            // 
            // ProductIdlINsALEabel10
            // 
            ProductIdlINsALEabel10.AutoSize = true;
            ProductIdlINsALEabel10.Location = new Point(10, 290);
            ProductIdlINsALEabel10.Name = "ProductIdlINsALEabel10";
            ProductIdlINsALEabel10.Size = new Size(77, 20);
            ProductIdlINsALEabel10.TabIndex = 12;
            ProductIdlINsALEabel10.Text = "Product Id";
            // 
            // ProductIdtextBox10
            // 
            ProductIdtextBox10.Location = new Point(120, 287);
            ProductIdtextBox10.Name = "ProductIdtextBox10";
            ProductIdtextBox10.Size = new Size(100, 27);
            ProductIdtextBox10.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 20);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 0;
            label7.Text = "Sale Id";
            // 
            // SaleIdtextBox7
            // 
            SaleIdtextBox7.Location = new Point(120, 17);
            SaleIdtextBox7.Name = "SaleIdtextBox7";
            SaleIdtextBox7.Size = new Size(100, 27);
            SaleIdtextBox7.TabIndex = 1;
            // 
            // panelProduct
            // 
            panelProduct.BorderStyle = BorderStyle.FixedSingle;
            panelProduct.Controls.Add(Product_Namelabel6);
            panelProduct.Controls.Add(ProductNametextBox6);
            panelProduct.Controls.Add(ProductPricelabel5);
            panelProduct.Controls.Add(textBox5);
            panelProduct.Controls.Add(ProductCountlabel4);
            panelProduct.Controls.Add(textBox4);
            panelProduct.Controls.Add(label2);
            panelProduct.Controls.Add(ProductIDtextBox2);
            panelProduct.Controls.Add(label5);
            panelProduct.Controls.Add(ProductCategoriescomboBox1);
            panelProduct.Location = new Point(11, 20);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(240, 400);
            panelProduct.TabIndex = 0;
            // 
            // Product_Namelabel6
            // 
            Product_Namelabel6.AutoSize = true;
            Product_Namelabel6.Location = new Point(10, 65);
            Product_Namelabel6.Name = "Product_Namelabel6";
            Product_Namelabel6.Size = new Size(49, 20);
            Product_Namelabel6.TabIndex = 2;
            Product_Namelabel6.Text = "Name";
            // 
            // ProductNametextBox6
            // 
            ProductNametextBox6.Location = new Point(110, 62);
            ProductNametextBox6.Name = "ProductNametextBox6";
            ProductNametextBox6.Size = new Size(110, 27);
            ProductNametextBox6.TabIndex = 3;
            // 
            // ProductPricelabel5
            // 
            ProductPricelabel5.AutoSize = true;
            ProductPricelabel5.Location = new Point(10, 110);
            ProductPricelabel5.Name = "ProductPricelabel5";
            ProductPricelabel5.Size = new Size(41, 20);
            ProductPricelabel5.TabIndex = 4;
            ProductPricelabel5.Text = "Price";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(110, 107);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 27);
            textBox5.TabIndex = 5;
            // 
            // ProductCountlabel4
            // 
            ProductCountlabel4.AutoSize = true;
            ProductCountlabel4.Location = new Point(10, 155);
            ProductCountlabel4.Name = "ProductCountlabel4";
            ProductCountlabel4.Size = new Size(48, 20);
            ProductCountlabel4.TabIndex = 6;
            ProductCountlabel4.Text = "Count";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 27);
            textBox4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 20);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 0;
            label2.Text = "Id";
            // 
            // ProductIDtextBox2
            // 
            ProductIDtextBox2.Location = new Point(110, 17);
            ProductIDtextBox2.Name = "ProductIDtextBox2";
            ProductIDtextBox2.Size = new Size(110, 27);
            ProductIDtextBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 200);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "Category";
            // 
            // ProductCategoriescomboBox1
            // 
            ProductCategoriescomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductCategoriescomboBox1.FormattingEnabled = true;
            ProductCategoriescomboBox1.Location = new Point(110, 197);
            ProductCategoriescomboBox1.Name = "ProductCategoriescomboBox1";
            ProductCategoriescomboBox1.Size = new Size(110, 28);
            ProductCategoriescomboBox1.TabIndex = 9;
            ProductCategoriescomboBox1.SelectedIndexChanged += ProductCategoriescomboBox1_SelectedIndexChanged;
            // 
            // DeleteTabPage1
            // 
            DeleteTabPage1.Location = new Point(4, 29);
            DeleteTabPage1.Name = "DeleteTabPage1";
            DeleteTabPage1.Padding = new Padding(3);
            DeleteTabPage1.Size = new Size(792, 512);
            DeleteTabPage1.TabIndex = 3;
            DeleteTabPage1.Text = "Delete";
            DeleteTabPage1.UseVisualStyleBackColor = true;
            // 
            // UpdateTabPage1
            // 
            UpdateTabPage1.Controls.Add(updateBtn);
            UpdateTabPage1.Controls.Add(panelUpdateCustomer);
            UpdateTabPage1.Controls.Add(panelUpdateSale);
            UpdateTabPage1.Controls.Add(panelupdatePro);
            UpdateTabPage1.Location = new Point(4, 29);
            UpdateTabPage1.Name = "UpdateTabPage1";
            UpdateTabPage1.Padding = new Padding(3);
            UpdateTabPage1.Size = new Size(792, 512);
            UpdateTabPage1.TabIndex = 4;
            UpdateTabPage1.Text = "Update";
            UpdateTabPage1.UseVisualStyleBackColor = true;
            UpdateTabPage1.Click += UpdateTabPage1_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(345, 421);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(102, 37);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "עדכן";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // panelUpdateCustomer
            // 
            panelUpdateCustomer.BorderStyle = BorderStyle.FixedSingle;
            panelUpdateCustomer.Controls.Add(label16);
            panelUpdateCustomer.Controls.Add(textBox17);
            panelUpdateCustomer.Controls.Add(label17);
            panelUpdateCustomer.Controls.Add(textBox18);
            panelUpdateCustomer.Controls.Add(label18);
            panelUpdateCustomer.Controls.Add(textBox19);
            panelUpdateCustomer.Controls.Add(label19);
            panelUpdateCustomer.Controls.Add(textBox20);
            panelUpdateCustomer.Location = new Point(546, 15);
            panelUpdateCustomer.Name = "panelUpdateCustomer";
            panelUpdateCustomer.Size = new Size(240, 400);
            panelUpdateCustomer.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 20);
            label16.Name = "label16";
            label16.Size = new Size(22, 20);
            label16.TabIndex = 0;
            label16.Text = "Id";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(90, 17);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(130, 27);
            textBox17.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 65);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 2;
            label17.Text = "Name";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(90, 62);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(130, 27);
            textBox18.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(10, 110);
            label18.Name = "label18";
            label18.Size = new Size(62, 20);
            label18.TabIndex = 4;
            label18.Text = "Address";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(90, 107);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(130, 27);
            textBox19.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(10, 155);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 6;
            label19.Text = "Phone";
            // 
            // textBox20
            // 
            textBox20.Location = new Point(90, 152);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(130, 27);
            textBox20.TabIndex = 7;
            // 
            // panelUpdateSale
            // 
            panelUpdateSale.BorderStyle = BorderStyle.FixedSingle;
            panelUpdateSale.Controls.Add(label9);
            panelUpdateSale.Controls.Add(textBox10);
            panelUpdateSale.Controls.Add(label10);
            panelUpdateSale.Controls.Add(textBox11);
            panelUpdateSale.Controls.Add(label11);
            panelUpdateSale.Controls.Add(textBox12);
            panelUpdateSale.Controls.Add(label12);
            panelUpdateSale.Controls.Add(textBox13);
            panelUpdateSale.Controls.Add(label13);
            panelUpdateSale.Controls.Add(textBox14);
            panelUpdateSale.Controls.Add(label14);
            panelUpdateSale.Controls.Add(textBox15);
            panelUpdateSale.Controls.Add(label15);
            panelUpdateSale.Controls.Add(textBox16);
            panelUpdateSale.Location = new Point(280, 15);
            panelUpdateSale.Name = "panelUpdateSale";
            panelUpdateSale.Size = new Size(240, 400);
            panelUpdateSale.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 65);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 2;
            label9.Text = "Start Date";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(120, 62);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 27);
            textBox10.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 110);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 4;
            label10.Text = "End Date";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(120, 107);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 27);
            textBox11.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 155);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 6;
            label11.Text = "Count";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(120, 152);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 27);
            textBox12.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 245);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 10;
            label12.Text = "All Customers?";
            label12.Click += label12_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(120, 242);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 27);
            textBox13.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 200);
            label13.Name = "label13";
            label13.Size = new Size(41, 20);
            label13.TabIndex = 8;
            label13.Text = "Price";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(120, 197);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(100, 27);
            textBox14.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 290);
            label14.Name = "label14";
            label14.Size = new Size(77, 20);
            label14.TabIndex = 12;
            label14.Text = "Product Id";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(120, 287);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(100, 27);
            textBox15.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 20);
            label15.Name = "label15";
            label15.Size = new Size(54, 20);
            label15.TabIndex = 0;
            label15.Text = "Sale Id";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(120, 17);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(100, 27);
            textBox16.TabIndex = 1;
            // 
            // panelupdatePro
            // 
            panelupdatePro.BorderStyle = BorderStyle.FixedSingle;
            panelupdatePro.Controls.Add(label1);
            panelupdatePro.Controls.Add(textBox2);
            panelupdatePro.Controls.Add(label3);
            panelupdatePro.Controls.Add(textBox6);
            panelupdatePro.Controls.Add(label4);
            panelupdatePro.Controls.Add(textBox7);
            panelupdatePro.Controls.Add(label6);
            panelupdatePro.Controls.Add(textBox9);
            panelupdatePro.Controls.Add(label8);
            panelupdatePro.Controls.Add(productComboBoxUpdate);
            panelupdatePro.Location = new Point(19, 15);
            panelupdatePro.Name = "panelupdatePro";
            panelupdatePro.Size = new Size(240, 400);
            panelupdatePro.TabIndex = 1;
            panelupdatePro.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 65);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 110);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(110, 107);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 27);
            textBox6.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 155);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 6;
            label4.Text = "Count";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(110, 152);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(110, 27);
            textBox7.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 20);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 0;
            label6.Text = "Id";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(110, 17);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(110, 27);
            textBox9.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 200);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 8;
            label8.Text = "Category";
            // 
            // productComboBoxUpdate
            // 
            productComboBoxUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBoxUpdate.FormattingEnabled = true;
            productComboBoxUpdate.Location = new Point(110, 197);
            productComboBoxUpdate.Name = "productComboBoxUpdate";
            productComboBoxUpdate.Size = new Size(110, 28);
            productComboBoxUpdate.TabIndex = 9;
            // 
            // OrderByPriceSaleBtn
            // 
            OrderByPriceSaleBtn.Location = new Point(810, 375);
            OrderByPriceSaleBtn.Name = "OrderByPriceSaleBtn";
            OrderByPriceSaleBtn.Size = new Size(107, 123);
            OrderByPriceSaleBtn.TabIndex = 3;
            OrderByPriceSaleBtn.Text = "מיין לפי מחיר מבצע מהגדול לקטן";
            OrderByPriceSaleBtn.UseVisualStyleBackColor = true;
            OrderByPriceSaleBtn.Click += OrderByPriceSaleBtn_Click;
            // 
            // OrderByCityBtn
            // 
            OrderByCityBtn.Location = new Point(817, 61);
            OrderByCityBtn.Name = "OrderByCityBtn";
            OrderByCityBtn.Size = new Size(85, 103);
            OrderByCityBtn.TabIndex = 1;
            OrderByCityBtn.Text = "מיין עפ\"י ערים";
            OrderByCityBtn.UseVisualStyleBackColor = true;
            OrderByCityBtn.Click += OrderByCityBtn_Click;
            // 
            // OrderByPriceBtn
            // 
            OrderByPriceBtn.Location = new Point(817, 189);
            OrderByPriceBtn.Name = "OrderByPriceBtn";
            OrderByPriceBtn.Size = new Size(75, 158);
            OrderByPriceBtn.TabIndex = 2;
            OrderByPriceBtn.Text = "מיין לפי מחיר מוצר מהקטן לגדול";
            OrderByPriceBtn.UseVisualStyleBackColor = true;
            OrderByPriceBtn.Click += OrderByPriceBtn_Click;
            // 
            // ManagerController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(OrderByPriceSaleBtn);
            Controls.Add(OrderByPriceBtn);
            Controls.Add(OrderByCityBtn);
            Controls.Add(CreatetabControl1);
            Name = "ManagerController";
            Text = "ManagerController";
            Load += ManagerController_Load;
            CreatetabControl1.ResumeLayout(false);
            ViewOneTabPage1.ResumeLayout(false);
            ViewOneTabPage1.PerformLayout();
            ViewAllTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CreateTabPage3.ResumeLayout(false);
            panelCustomer.ResumeLayout(false);
            panelCustomer.PerformLayout();
            panelSale.ResumeLayout(false);
            panelSale.PerformLayout();
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            UpdateTabPage1.ResumeLayout(false);
            panelUpdateCustomer.ResumeLayout(false);
            panelUpdateCustomer.PerformLayout();
            panelUpdateSale.ResumeLayout(false);
            panelUpdateSale.PerformLayout();
            panelupdatePro.ResumeLayout(false);
            panelupdatePro.PerformLayout();
            ResumeLayout(false);
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
        private Panel panelUpdateCustomer;
        private Label label16;
        private TextBox textBox17;
        private Label label17;
        private TextBox textBox18;
        private Label label18;
        private TextBox textBox19;
        private Label label19;
        private TextBox textBox20;
        private Panel panelUpdateSale;
        private Label label9;
        private TextBox textBox10;
        private Label label10;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBox12;
        private Label label12;
        private TextBox textBox13;
        private Label label13;
        private TextBox textBox14;
        private Label label14;
        private TextBox textBox15;
        private Label label15;
        private TextBox textBox16;
        private Panel panelupdatePro;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox6;
        private Label label4;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox9;
        private Label label8;
        private ComboBox productComboBoxUpdate;
        private Button updateBtn;
    }
}
