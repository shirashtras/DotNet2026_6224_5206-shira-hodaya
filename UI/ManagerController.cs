using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BIApi;
using System.Globalization;
using BL.BO;

namespace UI
{
    public partial class ManagerController : Form
    {
        public enum Types { PRODUCT, SALE, CUSTOMER }

        private Types type;

        public ManagerController(Types t)
        {
            InitializeComponent();

            // מילוי קטגוריות ליצירה ולעדכון
            ProductCategoriescomboBox1.DataSource = Enum.GetNames(typeof(Category));
            productComboBoxUpdate.DataSource = Enum.GetNames(typeof(Category));

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

        // הסתרת שדות ID לפי סוג (יצירה)
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

            object? result = null;

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
                            If_All_Customers = If_All_CustomersCheckBox.Checked
                        };

                        Factory.Get().iSale.Create(sale);
                        dataGridView1.DataSource = Factory.Get().iSale.ReadAll().ToList();
                        break;
                }

                MessageBox.Show("Added successfully!");
                textBoxDelete.Text = "";
                textBoxDelete.Focus();
                ClearAllFields();
            }
            catch (Exception ex)
            {
                // TEMP: show full info while debugging to find root cause
                MessageBox.Show("Error: " + ex.Message + "\n\nDetails:\n" + ex.ToString());
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

            // Uncheck any checkboxes in sale/update panels
            foreach (Control c in panelSale.Controls)
                if (c is CheckBox) ((CheckBox)c).Checked = false;

            foreach (Control c in panelUpdateSale.Controls)
                if (c is CheckBox) ((CheckBox)c).Checked = false;

            // clear update product fields
            textBox9.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            productComboBoxUpdate.SelectedIndex = -1;
        }

        private void ManagerController_Load(object sender, EventArgs e)
        { 

            HideAllPanels();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (type)
                {
                    case Types.PRODUCT:
                        // update panel fields: textBox9 = id, textBox2 = name, textBox6 = price, textBox7 = count
                        if (!int.TryParse(textBox9.Text, out int prodId))
                        {
                            MessageBox.Show("Product ID must be a number");
                            return;
                        }

                        if (!double.TryParse(textBox6.Text, out double prodPrice))
                        {
                            MessageBox.Show("Price must be a number");
                            return;
                        }

                        if (!int.TryParse(textBox7.Text, out int prodCount))
                        {
                            MessageBox.Show("Count must be a number");
                            return;
                        }

                        var catText = productComboBoxUpdate.SelectedItem?.ToString() ?? productComboBoxUpdate.Text;
                        if (!Enum.TryParse<Category>(catText, out var prodCat))
                        {
                            MessageBox.Show("Invalid category");
                            return;
                        }

                        var product = new BO.Product
                        {
                            Product_Id = prodId,
                            Product_Name = textBox2.Text,
                            Price = prodPrice,
                            Count = prodCount,
                            category = prodCat
                        };

                        Factory.Get().iProduct.Update(product);
                        dataGridView1.DataSource = Factory.Get().iProduct.ReadAll().ToList();
                        break;

                    case Types.CUSTOMER:
                        if (!int.TryParse(textBox17.Text, out int custId))
                        {
                            MessageBox.Show("Customer ID must be a number");
                            return;
                        }

                        var customer = new BO.Customer
                        {
                            Customer_Id = custId,
                            Customer_Name = textBox18.Text,
                            Customer_Address = textBox19.Text,
                            Customer_Phone = textBox20.Text
                        };

                        Factory.Get().iCustomer.Update(customer);
                        dataGridView1.DataSource = Factory.Get().iCustomer.ReadAll().ToList();
                        break;

                    case Types.SALE:
                        if (!int.TryParse(textBox16.Text, out int saleId))
                        {
                            MessageBox.Show("Sale ID must be a number");
                            return;
                        }

                        if (!int.TryParse(textBox15.Text, out int productIdSale))
                        {
                            MessageBox.Show("Product ID must be a number");
                            return;
                        }

                        if (!double.TryParse(textBox14.Text, out double priceSale))
                        {
                            MessageBox.Show("Price must be a number");
                            return;
                        }

                        if (!int.TryParse(textBox12.Text, out int countSale))
                        {
                            MessageBox.Show("Count must be a number");
                            return;
                        }

                        // read checkbox state directly
                        bool allCustomers = If_All_CustomersCheckBoxUpdate.Checked;

                        if (!TryParseDate(textBox10.Text, out DateTime startDate))
                        {
                            MessageBox.Show("Start Date format invalid. Use one of: dd/MM/yyyy, MM/dd/yyyy, yyyy-MM-dd");
                            return;
                        }

                        if (!TryParseDate(textBox11.Text, out DateTime endDate))
                        {
                            MessageBox.Show("End Date format invalid. Use one of: dd/MM/yyyy, MM/dd/yyyy, yyyy-MM-dd");
                            return;
                        }

                        var sale = new BO.Sale
                        {
                            SaleId = saleId,
                            ProductId = productIdSale,
                            Price_Sale = priceSale,
                            Date_Start_Sale = startDate,
                            Date_End_Sale = endDate,
                            Count_Sale = countSale,
                            If_All_Customers = allCustomers
                        };

                        Factory.Get().iSale.Update(sale);
                        dataGridView1.DataSource = Factory.Get().iSale.ReadAll().ToList();
                        break;
                }

                MessageBox.Show("Updated successfully!");
                ClearAllFields();
            }
            catch (Exception ex)
            {
                // TEMP: show full info while debugging to find root cause
                MessageBox.Show("Error: " + ex.Message + "\n\nDetails:\n" + ex.ToString());
            }
        }
        private void AdjustIdFieldsUpdate()
        {
            if (type == Types.PRODUCT)
            {
                // For update we need to show the product id to choose which product to update
                textBox9.Visible = true;
                label6.Visible = true;
            }

            if (type == Types.SALE)
            {
                textBox16.Visible = true;
                label15.Visible = true;
            }

            if (type == Types.CUSTOMER)
            {
                textBox17.Visible = true;
                label16.Visible = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void HideAllPanelsUpdate()
        {
            panelUpdateCustomer.Visible = false;
            panelupdatePro.Visible = false;
            panelUpdateSale.Visible = false;
        }
        private void UpdateTabPage1_Click(object sender, EventArgs e)
        {
            HideAllPanelsUpdate();

            switch (type)
            {
                case Types.PRODUCT:
                    // populate update category combobox (defensive)
                    productComboBoxUpdate.DataSource = Enum.GetNames(typeof(Category));
                    panelupdatePro.Visible = true;
                    break;

                case Types.SALE:
                    panelUpdateSale.Visible = true;
                    break;

                case Types.CUSTOMER:
                    panelUpdateCustomer.Visible = true;
                    break;
            }

            AdjustIdFieldsUpdate();
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
            else if (CreatetabControl1.SelectedTab == UpdateTabPage1)
            {
                HideAllPanelsUpdate();

                switch (type)
                {
                    case Types.PRODUCT:
                        productComboBoxUpdate.DataSource = Enum.GetNames(typeof(Category));
                        panelupdatePro.Show();
                        break;

                    case Types.SALE:
                        panelUpdateSale.Show();
                        break;

                    case Types.CUSTOMER:
                        panelUpdateCustomer.Show();
                        break;
                }

                AdjustIdFieldsUpdate();
            }
        }

        private bool TryParseDate(string input, out DateTime result)
        {
            string[] formats = new[] { "dd/MM/yyyy", "d/M/yyyy", "MM/dd/yyyy", "yyyy-MM-dd" };
            if (DateTime.TryParseExact(input, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
                return true;

            // fallback to culture-aware parse
            return DateTime.TryParse(input, CultureInfo.CurrentCulture, DateTimeStyles.None, out result);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDelete.Text, out int id))
            {
                MessageBox.Show("ID must be a number");
                return;
            }

            try
            {
                switch (type)
                {
                    case Types.PRODUCT:
                        Factory.Get().iProduct.Delete(id);
                        dataGridView1.DataSource = Factory.Get().iProduct.ReadAll().ToList();
                        break;

                    case Types.CUSTOMER:
                        Factory.Get().iCustomer.Delete(id);
                        dataGridView1.DataSource = Factory.Get().iCustomer.ReadAll().ToList();
                        break;

                    case Types.SALE:
                        Factory.Get().iSale.Delete(id);
                        dataGridView1.DataSource = Factory.Get().iSale.ReadAll().ToList();
                        break;
                }

                MessageBox.Show("Deleted successfully!");
                ClearAllFields();

                // clear delete ID field and return focus for convenience
                textBoxDelete.Text = "";
                textBoxDelete.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // optional: validate input as the user types
            // For now keep empty to satisfy designer wiring.
        }
    }
}
