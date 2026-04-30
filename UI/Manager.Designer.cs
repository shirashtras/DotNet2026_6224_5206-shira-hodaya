
namespace UI
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(128, 64, 0);
            button1.Location = new Point(302, 107);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(207, 101);
            button1.TabIndex = 0;
            button1.Text = "Customers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(128, 64, 0);
            button2.Location = new Point(301, 216);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(207, 99);
            button2.TabIndex = 1;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(128, 64, 0);
            button3.Location = new Point(301, 323);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(207, 101);
            button3.TabIndex = 2;
            button3.Text = "Sales";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonBack
            // 
            buttonBack.AccessibleRole = AccessibleRole.TitleBar;
            buttonBack.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.FromArgb(128, 64, 0);
            buttonBack.Location = new Point(331, 458);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(144, 44);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Manager
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonBack);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager";
            Text = "Form2";
            ResumeLayout(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerController managerController = new ManagerController(ManagerController.Types.SALE);
            managerController.FormClosed += (s, args) => this.Show();
            managerController.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerController managerController = new ManagerController(ManagerController.Types.PRODUCT);
            managerController.FormClosed += (s, args) => this.Show();
            managerController.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManagerController managerController = new ManagerController(ManagerController.Types.CUSTOMER);
            managerController.FormClosed += (s, args) => this.Show();
            managerController.Show();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonBack;
    }
}