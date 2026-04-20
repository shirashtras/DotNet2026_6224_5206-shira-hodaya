
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIApi;
using BO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class ManagerController : Form
    {

        public enum Types { PRODUCT, SALE, CUSTOMER }

        private Types type;
        public ManagerController(Types t)
        {
           
            InitializeComponent();
            OrderByCityBtn.Hide();
            OrderByPriceBtn.Hide();
            OrderByPriceSaleBtn.Hide();

            type = t;

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
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ViewOneButton1_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton3_Click(object sender, EventArgs e)
        {

        }

        private void CreateTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e, Types type)
        {
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

        private void ViewOneTabPage1_Click(object sender, EventArgs e)
        {


        }

        private void ManagerController_Load(object sender, EventArgs e)
        {

        }

        private void ShowLabel1_Click(object sender, EventArgs e)
        {

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
            if (obj is Product p)
            {
                labelDetails.Text =
                    $"Product ID: {p.Product_Id}\n" +
                    $"Name: {p.Product_Name}\n" +
                    $"Price: {p.Price}\n" +
                    $"Count: {p.Count}\n" +
                    $"Category: {p.category}";
            }

            else if (obj is Customer c)
            {
                labelDetails.Text =
                    $"Customer ID: {c.Customer_Id}\n" +
                    $"Name: {c.Customer_Name}\n" +
                    $"Phone: {c.Customer_Phone}\n" +
                    $"Address:{c.Customer_Address}";

            }

            else if (obj is Sale s)
            {
                labelDetails.Text =
                    $"Sale ID: {s.SaleId}\n" +
                    $"Product ID: {s.ProductId}\n" +
                    $"Price : {s.Price_Sale}\n" +
                    $"Is All Customers?: {s.If_All_Customers}\n" +
                    $"Count_Sale: {s.Count_Sale}\n" +
                    $"Date Start: {s.Date_Start_Sale}\n" +
                      $"Date End: {s.Date_End_Sale}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderByCityBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Factory.Get().iCustomer
                .ReadAll()
               .OrderBy(c => c.Customer_Address)
                .ToList();
        }

        private void OrderByPriceBtn_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Factory.Get().iProduct
                .ReadAll()
                .OrderBy(p => p.Price)
                .ToList();
        }

        private void OrderByPriceSaleBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Factory.Get().iSale
             .ReadAll()
             .OrderBy(s => s.Price_Sale).Distinct()
             .ToList();
        }
    }
}