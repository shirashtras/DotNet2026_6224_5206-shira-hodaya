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
            Text = "Cashiar";
            Size = new Size(820, 640);

            comboProducts = new ComboBox { Left = 20, Top = 18, Width = 420, DropDownStyle = ComboBoxStyle.DropDownList };
            txtProductId = new TextBox { Left = 460, Top = 18, Width = 140, PlaceholderText = "Product Id" };
            numQuantity = new NumericUpDown { Left = 610, Top = 18, Width = 80, Minimum = 1, Value = 1 };
            btnAdd = new Button { Left = 700, Top = 16, Width = 90, Text = "Add" };
            btnAdd.Click += BtnAdd_Click;

            lvOrder = new ListView
            {
                Left = 20,
                Top = 60,
                Width = 770,
                Height = 480,
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };
            lvOrder.Columns.Add("Product Id", 80);
            lvOrder.Columns.Add("Name", 280);
            lvOrder.Columns.Add("Qty", 60);
            lvOrder.Columns.Add("Base Price", 100);
            lvOrder.Columns.Add("Applied Sales", 160);
            lvOrder.Columns.Add("Final Price", 90);

            lblTotal = new Label { Left = 20, Top = 555, Width = 400, Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold) };
            btnFinish = new Button { Left = 700, Top = 548, Width = 90, Text = "Finish" };
            btnFinish.Click += BtnFinish_Click;

            Controls.Add(comboProducts);
            Controls.Add(txtProductId);
            Controls.Add(numQuantity);
            Controls.Add(btnAdd);
            Controls.Add(lvOrder);
            Controls.Add(lblTotal);
            Controls.Add(btnFinish);

            Load += CashiarController_Load;
        }

        private void CashiarController_Load(object? sender, EventArgs e)
        {
            try
            {
                var products = Factory.Get().iProduct.ReadAll();
                comboProducts.Items.Clear();
                foreach (var p in products)
                {
                    // "id - name" format to allow selection or manual entry
                    comboProducts.Items.Add($"{p.Product_Id} - {p.Product_Name}");
                }

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
                // Add product to order via BL. This should populate product info and sales on the order.
                Factory.Get().iOrder.AddProductToOrder(currentOrder, qty, productId);

                // Ensure each ProductInOrder has a sensible final price for display
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
            {
                return int.TryParse(manual, out id);
            }

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
            // If BL did not calculate final prices for products, compute basic fallback:
            foreach (var p in currentOrder.listProductInOrder)
            {
                if (p.finalPriceProductInOrder <= 0)
                    p.finalPriceProductInOrder = p.amountProductInOrder * p.basePriceProductInOrder;
            }

            currentOrder.finalPrice = currentOrder.listProductInOrder.Sum(p => p.finalPriceProductInOrder);
        }

        private void RefreshOrderDisplay()
        {
            lvOrder.Items.Clear();
            foreach (var p in currentOrder.listProductInOrder)
            {
                string salesText = "";
                if (p.listSaleToProductInOrder != null && p.listSaleToProductInOrder.Any())
                {
                    salesText = string.Join(", ", p.listSaleToProductInOrder.Select(s => $"{s.amountSaleInProduct}@{s.priceSaleInProduct:0.00}"));
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