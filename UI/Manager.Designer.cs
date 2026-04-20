
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(263, 79);
            button1.Name = "button1";
            button1.Size = new Size(167, 58);
            button1.TabIndex = 0;
            button1.Text = "Customers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(263, 160);
            button2.Name = "button2";
            button2.Size = new Size(167, 56);
            button2.TabIndex = 1;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(263, 242);
            button3.Name = "button3";
            button3.Size = new Size(167, 58);
            button3.TabIndex = 2;
            button3.Text = "Sales";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
    }
}