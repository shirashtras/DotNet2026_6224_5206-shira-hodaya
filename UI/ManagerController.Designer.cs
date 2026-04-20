
namespace UI
{
    partial class ManagerController
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
            ViewAllTabControl1 = new TabControl();
            ViewOneTabPage1 = new TabPage();
            ViewAllTabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            CreateTabPage3 = new TabPage();
            DeleteTabPage1 = new TabPage();
            UpdateTabPage1 = new TabPage();
            ViewAllTabControl1.SuspendLayout();
            ViewAllTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ViewAllTabControl1
            // 
            ViewAllTabControl1.Controls.Add(ViewOneTabPage1);
            ViewAllTabControl1.Controls.Add(ViewAllTabPage2);
            ViewAllTabControl1.Controls.Add(CreateTabPage3);
            ViewAllTabControl1.Controls.Add(DeleteTabPage1);
            ViewAllTabControl1.Controls.Add(UpdateTabPage1);
            ViewAllTabControl1.Location = new Point(10, 12);
            ViewAllTabControl1.Name = "ViewAllTabControl1";
            ViewAllTabControl1.SelectedIndex = 0;
            ViewAllTabControl1.Size = new Size(700, 409);
            ViewAllTabControl1.TabIndex = 6;
            // 
            // ViewOneTabPage1
            // 
            ViewOneTabPage1.Location = new Point(4, 24);
            ViewOneTabPage1.Name = "ViewOneTabPage1";
            ViewOneTabPage1.Padding = new Padding(3);
            ViewOneTabPage1.Size = new Size(692, 381);
            ViewOneTabPage1.TabIndex = 0;
            ViewOneTabPage1.Text = "View One";
            ViewOneTabPage1.UseVisualStyleBackColor = true;
            ViewOneTabPage1.Click += ViewOneTabPage1_Click;
            // 
            // ViewAllTabPage2
            // 
            ViewAllTabPage2.Controls.Add(dataGridView1);
            ViewAllTabPage2.Location = new Point(4, 24);
            ViewAllTabPage2.Name = "ViewAllTabPage2";
            ViewAllTabPage2.Padding = new Padding(3);
            ViewAllTabPage2.Size = new Size(692, 381);
            ViewAllTabPage2.TabIndex = 1;
            ViewAllTabPage2.Text = "View All";
            ViewAllTabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(689, 378);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // CreateTabPage3
            // 
            CreateTabPage3.Location = new Point(4, 24);
            CreateTabPage3.Name = "CreateTabPage3";
            CreateTabPage3.Padding = new Padding(3);
            CreateTabPage3.Size = new Size(692, 381);
            CreateTabPage3.TabIndex = 2;
            CreateTabPage3.Text = "Create";
            CreateTabPage3.UseVisualStyleBackColor = true;
            CreateTabPage3.Click += CreateTabPage3_Click;
            // 
            // DeleteTabPage1
            // 
            DeleteTabPage1.Location = new Point(4, 24);
            DeleteTabPage1.Name = "DeleteTabPage1";
            DeleteTabPage1.Padding = new Padding(3);
            DeleteTabPage1.Size = new Size(692, 381);
            DeleteTabPage1.TabIndex = 3;
            DeleteTabPage1.Text = "Delete";
            DeleteTabPage1.UseVisualStyleBackColor = true;
            // 
            // UpdateTabPage1
            // 
            UpdateTabPage1.BackgroundImageLayout = ImageLayout.None;
            UpdateTabPage1.ForeColor = SystemColors.ControlText;
            UpdateTabPage1.Location = new Point(4, 24);
            UpdateTabPage1.Name = "UpdateTabPage1";
            UpdateTabPage1.Padding = new Padding(3);
            UpdateTabPage1.Size = new Size(692, 381);
            UpdateTabPage1.TabIndex = 4;
            UpdateTabPage1.Text = "Update";
            UpdateTabPage1.UseVisualStyleBackColor = true;
            // 
            // ManagerController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewAllTabControl1);
            Name = "ManagerController";
            Text = "ManagerController";
            Load += ManagerController_Load;
            ViewAllTabControl1.ResumeLayout(false);
            ViewAllTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        #endregion
        private TabControl ViewAllTabControl1;
        private TabPage ViewOneTabPage1;
        private TabPage ViewAllTabPage2;
        private TabPage CreateTabPage3;
        private TabPage DeleteTabPage1;
        private TabPage UpdateTabPage1;
        private DataGridView dataGridView1;
    }
}