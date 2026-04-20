using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BIApi;
using BO;
using DO;

namespace UI
{
    public partial class ManagerController : Form
    {
        public enum Types { PRODUCT, SALE, CUSTOMER }

        private Types type;

        public ManagerController(Types t)
        {
            InitializeComponent();

            // מילוי קטגוריות
            ProductCategoriescomboBox1.DataSource = Enum.GetNames(typeof(Category));

            type = t;

            HideAllPanels();
            OrderByCityBtn.Hide();
            OrderByPriceBtn.Hide();
            OrderByPriceSaleBtn.Hide();

            switch (type)
            {
                case Types.PRODUCT:
                    dataGridView1.DataSource = Factory.Get().iProduct.ReadAll();
                    OrderByPriceBtn.Show();
                    break;

                case Types.SALE:
                    dataGridView1.DataSource = Factory.Get().iSale.ReadAll();
                    OrderByPriceSaleBtn.Show();
                    break;

                case Types.CUSTOMER:
                    dataGridView1.DataSource = Factory.Get().iCustomer.ReadAll();
                    OrderByCityBtn.Show();
                    break;
            }
        }

        // הסתרת שדות ID לפי סוג
        private void AdjustIdFields()
        {
            if (type == Types.PRODUCT)
            {
                ProductIDtextBox2.Visible = false;
                label2.Visible = false;
            }

            if (type == Types.SALE)
            {
                SaleIdtextBox7.Visible = false;
                label7.Visible = false;
            }

            if (type == Types.CUSTOMER)
            {
                IdtextBox4.Visible = true;
                Customer_Idlabel3.Visible = true;
            }
        }

        // מיון מוצר לפי מחיר
        private void OrderByPriceBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                Factory.Get().iProduct.ReadAll()
                .OrderBy(p => p.Price)
                .ToList();
        }

        // מיון מבצע לפי מחיר מבצע
        private void OrderByPriceSaleBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                Factory.Get().iSale.ReadAll()
                .OrderByDescending(s => s.Price_Sale)
                .ToList();
        }

        // מיון לקוחות לפי עיר
        private void OrderByCityBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                Factory.Get().iCustomer.ReadAll()
                .OrderBy(c => c.Customer_Address)
                .ToList();
        }

       

        private void CreateButton3_Click(object sender, EventArgs e)
        {
            HideAllPanels();

            switch (type)
            {
                case Types.PRODUCT:
                    panelProduct.Visible = true;
                    break;

                case Types.SALE:
                    panelSale.Visible = true;
                    break;

                case Types.CUSTOMER:
                    panelCustomer.Visible = true;
                    break;
            }

            AdjustIdFields();
        }

        private void HideAllPanels()
        {
            panelCustomer.Visible = false;
            panelProduct.Visible = false;
            panelSale.Visible = false;
        }

        private void ShowButton1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("ID must be a number");
                return;
            }

            object result = null;

            switch (type)
            {
                case Types.PRODUCT:
                    result = Factory.Get().iProduct.Read(id);
                    break;

                case Types.CUSTOMER:
                    result = Factory.Get().iCustomer.Read(id);
                    break;

                case Types.SALE:
                    result = Factory.Get().iSale.Read(id);
                    break;
            }

            if (result == null)
            {
                MessageBox.Show("Not found");
                return;
            }

            DisplayObject(result);
        }

        private void DisplayObject(object obj)
        {
            if (obj is BO.Product p)
            {
                labelDetails.Text =
                    $"Product ID: {p.Product_Id}\n" +
                    $"Name: {p.Product_Name}\n" +
                    $"Price: {p.Price}\n" +
                    $"Count: {p.Count}\n" +
                    $"Category: {p.category}";
            }
            else if (obj is BO.Customer c)
            {
                labelDetails.Text =
                    $"Customer ID: {c.Customer_Id}\n" +
                    $"Name: {c.Customer_Name}\n" +
                    $"Phone: {c.Customer_Phone}\n" +
                    $"Address: {c.Customer_Address}";
            }
            else if (obj is BO.Sale s)
            {
                labelDetails.Text =
                    $"Sale ID: {s.SaleId}\n" +
                    $"Product ID: {s.ProductId}\n" +
                    $"Price: {s.Price_Sale}\n" +
                    $"Is All Customers?: {s.If_All_Customers}\n" +
                    $"Count Sale: {s.Count_Sale}\n" +
                    $"Date Start: {s.Date_Start_Sale}\n" +
                    $"Date End: {s.Date_End_Sale}";
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (type)
                {
                    case Types.PRODUCT:
                        var product = new BO.Product
                        {
                            Product_Name = ProductNametextBox6.Text,
                            Price = double.Parse(textBox5.Text),
                            Count = int.Parse(textBox4.Text),
                            category = (Category)Enum.Parse(typeof(Category), ProductCategoriescomboBox1.Text)
                        };

                        Factory.Get().iProduct.Create(product);
                        dataGridView1.DataSource = Factory.Get().iProduct.ReadAll().ToList();
                        break;

                    case Types.CUSTOMER:
                        var customer = new BO.Customer
                        {
                            Customer_Id = int.Parse(IdtextBox4.Text),
                            Customer_Name = Customer_NametextBox2.Text,
                            Customer_Address = AddresstextBox2.Text,
                            Customer_Phone = textBox3.Text
                        };

                        Factory.Get().iCustomer.Create(customer);
                        dataGridView1.DataSource = Factory.Get().iCustomer.ReadAll().ToList();
                        break;

                    case Types.SALE:
                        var sale = new BO.Sale
                        {
                            ProductId = int.Parse(ProductIdtextBox10.Text),
                            Price_Sale = double.Parse(Price_SaleTextBox9.Text),
                            Date_Start_Sale = DateTime.Parse(Date_Start_SaletextBox2.Text),
                            Date_End_Sale = DateTime.Parse(textBox8.Text),
                            Count_Sale = int.Parse(Count_SaletextBox7.Text),
                            If_All_Customers = bool.Parse(If_All_CustomerstextBox8.Text)
                        };

                        Factory.Get().iSale.Create(sale);
                        dataGridView1.DataSource = Factory.Get().iSale.ReadAll().ToList();
                        break;
                }

                MessageBox.Show("Added successfully!");
                ClearAllFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearAllFields()
        {
            foreach (Control c in panelProduct.Controls)
                if (c is TextBox) c.Text = "";

            foreach (Control c in panelSale.Controls)
                if (c is TextBox) c.Text = "";

            foreach (Control c in panelCustomer.Controls)
                if (c is TextBox) c.Text = "";
        }

        private void ManagerController_Load(object sender, EventArgs e)
        {
            HideAllPanels();
        }
    }
}
