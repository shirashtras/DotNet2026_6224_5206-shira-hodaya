namespace UI
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            DoOrderbutton1 = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // DoOrderbutton1
            // 
            DoOrderbutton1.Font = new Font("Sitka Banner", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoOrderbutton1.ForeColor = Color.FromArgb(128, 64, 0);
            DoOrderbutton1.Location = new Point(191, 101);
            DoOrderbutton1.Name = "DoOrderbutton1";
            DoOrderbutton1.Size = new Size(361, 184);
            DoOrderbutton1.TabIndex = 0;
            DoOrderbutton1.Text = "DoOrder";
            DoOrderbutton1.UseVisualStyleBackColor = true;
            DoOrderbutton1.Click += DoOrderbutton1_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.FromArgb(128, 64, 0);
            buttonBack.Location = new Point(287, 355);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(168, 46);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(DoOrderbutton1);
            Name = "Cashier";
            Text = "Cashier";
            ResumeLayout(false);
        }




        #endregion

        private Button DoOrderbutton1;
        private Button buttonBack;
    }
}