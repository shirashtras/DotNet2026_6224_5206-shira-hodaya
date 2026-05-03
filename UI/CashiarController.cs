using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using BIApi;
using BL.BO;
using BO;

namespace UI
{
    public class CashiarController : Form
    {
        private ComboBox comboProducts;
        private TextBox txtProductId;
        private NumericUpDown numQuantity;
        private Button btnAdd;
        private ListView lvOrder;
        private Label lblTotal;
        private Button btnFinish;
        private Order currentOrder;

        public CashiarController()
        {
            InitializeComponent();
            currentOrder = new Order();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(CashiarController));

            comboProducts = new ComboBox();
            txtProductId = new TextBox();
            numQuantity = new NumericUpDown();
            btnAdd = new Button();
            lvOrder = new ListView();
            lblTotal = new Label();
            btnFinish = new Button();

            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();

            // comboProducts
            comboProducts.Location = new Point(20, 20);
            comboProducts.Size = new Size(200, 28);
            comboProducts.BackColor = Color.White;

            // txtProductId
            txtProductId.Location = new Point(20, 60);
            txtProductId.Size = new Size(200, 27);
            txtProductId.BackColor = Color.White;

            // numQuantity
            numQuantity.Location = new Point(20, 100);
            numQuantity.Size = new Size(200, 27);
            numQuantity.BackColor = Color.White;

            // btnAdd
            btnAdd.Location = new Point(20, 140);
            btnAdd.Size = new Size(200, 30);
            btnAdd.Text = "Add";
            btnAdd.BackColor = Color.White;
            btnAdd.Click += BtnAdd_Click;

            // lvOrder
            lvOrder.Location = new Point(250, 20);
            lvOrder.Size = new Size(500, 400);
            lvOrder.BackColor = Color.White;
            lvOrder.View = View.Details;
            lvOrder.Columns.Add("ID", 50);
            lvOrder.Columns.Add("Name", 150);
            lvOrder.Columns.Add("Qty", 50);
            lvOrder.Columns.Add("Base Price", 100);
            lvOrder.Columns.Add("Sales", 100);
            lvOrder.Columns.Add("Final Price", 100);

            // lblTotal
            lblTotal.Location = new Point(250, 440);
            lblTotal.Size = new Size(300, 30);
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Arial", 12, FontStyle.Bold);

            // btnFinish
            btnFinish.Location = new Point(250, 480);
            btnFinish.Size = new Size(200, 30);
            btnFinish.Text = "Finish Order";
            btnFinish.BackColor = Color.White;
            btnFinish.Click += BtnFinish_Click;

            // Form
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 593);

            Controls.Add(comboProducts);
            Controls.Add(txtProductId);
            Controls.Add(numQuantity);
            Controls.Add(btnAdd);
            Controls.Add(lvOrder);
            Controls.Add(lblTotal);
            Controls.Add(btnFinish);

            FormBorderStyle = FormBorderStyle.Fixed3D;
            Text = "Cashiar";
            Load += CashiarController_Load;

            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CashiarController_Load(object? sender, EventArgs e)
        {
            try
            {
                var products = Factory.Get().iProduct.ReadAll();
                comboProducts.Items.Clear();

                foreach (var p in products)
                    comboProducts.Items.Add($"{p.Product_Id} - {p.Product_Name}");

                if (comboProducts.Items.Count > 0)
                    comboProducts.SelectedIndex = 0;

                RefreshOrderDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!TryGetSelectedProductId(out int productId))
            {
                MessageBox.Show("Invalid product id");
                return;
            }

            int qty = (int)numQuantity.Value;

            try
            {
                Factory.Get().iOrder.AddProductToOrder(currentOrder, qty, productId);
                RecalculateOrderFallback();
                RefreshOrderDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot add product: " + ex.Message);
            }
        }

        private bool TryGetSelectedProductId(out int id)
        {
            id = 0;

            var manual = txtProductId.Text?.Trim();
            if (!string.IsNullOrEmpty(manual))
                return int.TryParse(manual, out id);

            if (comboProducts.SelectedItem != null)
            {
                var text = comboProducts.SelectedItem.ToString() ?? "";
                var parts = text.Split('-', 2);
                return int.TryParse(parts[0].Trim(), out id);
            }

            return false;
        }

        private void RecalculateOrderFallback()
        {
            foreach (var p in currentOrder.listProductInOrder)
            {
                if (p.finalPriceProductInOrder <= 0)
                    p.finalPriceProductInOrder = p.amountProductInOrder * p.basePriceProductInOrder;
            }

            currentOrder.finalPrice =
                currentOrder.listProductInOrder.Sum(p => p.finalPriceProductInOrder);
        }

        private void RefreshOrderDisplay()
        {
            lvOrder.Items.Clear();

            foreach (var p in currentOrder.listProductInOrder)
            {
                string salesText = "";

                if (p.listSaleToProductInOrder != null && p.listSaleToProductInOrder.Any())
                {
                    salesText = string.Join(", ",
                        p.listSaleToProductInOrder.Select(s =>
                            $"{s.amountSaleInProduct}@{s.priceSaleInProduct:0.00}"));
                }

                var item = new ListViewItem(new[]
                {
                    p.idProductInOrder.ToString(),
                    p.nameProductInOrder ?? "",
                    p.amountProductInOrder.ToString(),
                    p.basePriceProductInOrder.ToString("0.00"),
                    salesText,
                    p.finalPriceProductInOrder.ToString("0.00")
                });

                lvOrder.Items.Add(item);
            }

            lblTotal.Text = $"Total: {currentOrder.finalPrice:0.00}";
        }

        private void BtnFinish_Click(object? sender, EventArgs e)
        {
            if (currentOrder.listProductInOrder.Count == 0)
            {
                MessageBox.Show("Order is empty");
                return;
            }

            try
            {
                Factory.Get().iOrder.DoOrder(currentOrder);
                MessageBox.Show("Order completed successfully");
                currentOrder = new Order();
                RefreshOrderDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to complete order: " + ex.Message);
            }
        }
    }
}
