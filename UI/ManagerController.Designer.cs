
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

        private DataGridView GetDataGridView1()
        {
            return dataGridView1;
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
            textBox1 = new TextBox();
            IdLabel1 = new Label();
            ViewAllTabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            CreateTabPage3 = new TabPage();
            DeleteTabPage1 = new TabPage();
            UpdateTabPage1 = new TabPage();
            ShowButton1 = new Button();
            ViewAllTabControl1.SuspendLayout();
            ViewOneTabPage1.SuspendLayout();
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
            ViewAllTabControl1.Location = new Point(11, 16);
            ViewAllTabControl1.Margin = new Padding(3, 4, 3, 4);
            ViewAllTabControl1.Name = "ViewAllTabControl1";
            ViewAllTabControl1.SelectedIndex = 0;
            ViewAllTabControl1.Size = new Size(800, 545);
            ViewAllTabControl1.TabIndex = 6;
            // 
            // ViewOneTabPage1
            // 
            ViewOneTabPage1.Controls.Add(ShowButton1);
            ViewOneTabPage1.Controls.Add(textBox1);
            ViewOneTabPage1.Controls.Add(IdLabel1);
            ViewOneTabPage1.Location = new Point(4, 29);
            ViewOneTabPage1.Margin = new Padding(3, 4, 3, 4);
            ViewOneTabPage1.Name = "ViewOneTabPage1";
            ViewOneTabPage1.Padding = new Padding(3, 4, 3, 4);
            ViewOneTabPage1.Size = new Size(792, 512);
            ViewOneTabPage1.TabIndex = 0;
            ViewOneTabPage1.Text = "View One";
            ViewOneTabPage1.UseVisualStyleBackColor = true;
            ViewOneTabPage1.Click += ViewOneTabPage1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 91);
            textBox1.Margin = new Padding(3, 4, 3, 4);
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
            ViewAllTabPage2.Margin = new Padding(3, 4, 3, 4);
            ViewAllTabPage2.Name = "ViewAllTabPage2";
            ViewAllTabPage2.Padding = new Padding(3, 4, 3, 4);
            ViewAllTabPage2.Size = new Size(792, 512);
            ViewAllTabPage2.TabIndex = 1;
            ViewAllTabPage2.Text = "View All";
            ViewAllTabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(786, 504);
            dataGridView1.TabIndex = 0;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // CreateTabPage3
            // 
            CreateTabPage3.Location = new Point(4, 29);
            CreateTabPage3.Margin = new Padding(3, 4, 3, 4);
            CreateTabPage3.Name = "CreateTabPage3";
            CreateTabPage3.Padding = new Padding(3, 4, 3, 4);
            CreateTabPage3.Size = new Size(792, 512);
            CreateTabPage3.TabIndex = 2;
            CreateTabPage3.Text = "Create";
            CreateTabPage3.UseVisualStyleBackColor = true;
            CreateTabPage3.Click += CreateTabPage3_Click;
            // 
            // DeleteTabPage1
            // 
            DeleteTabPage1.Location = new Point(4, 29);
            DeleteTabPage1.Margin = new Padding(3, 4, 3, 4);
            DeleteTabPage1.Name = "DeleteTabPage1";
            DeleteTabPage1.Padding = new Padding(3, 4, 3, 4);
            DeleteTabPage1.Size = new Size(792, 512);
            DeleteTabPage1.TabIndex = 3;
            DeleteTabPage1.Text = "Delete";
            DeleteTabPage1.UseVisualStyleBackColor = true;
            // 
            // UpdateTabPage1
            // 
            UpdateTabPage1.BackgroundImageLayout = ImageLayout.None;
            UpdateTabPage1.ForeColor = SystemColors.ControlText;
            UpdateTabPage1.Location = new Point(4, 29);
            UpdateTabPage1.Margin = new Padding(3, 4, 3, 4);
            UpdateTabPage1.Name = "UpdateTabPage1";
            UpdateTabPage1.Padding = new Padding(3, 4, 3, 4);
            UpdateTabPage1.Size = new Size(792, 512);
            UpdateTabPage1.TabIndex = 4;
            UpdateTabPage1.Text = "Update";
            UpdateTabPage1.UseVisualStyleBackColor = true;
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
            // ManagerController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ViewAllTabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerController";
            Text = "ManagerController";
            Load += ManagerController_Load;
            ViewAllTabControl1.ResumeLayout(false);
            ViewOneTabPage1.ResumeLayout(false);
            ViewOneTabPage1.PerformLayout();
            ViewAllTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        //private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{
           
        //}

        #endregion
        private TabControl ViewAllTabControl1;
        private TabPage ViewOneTabPage1;
        private TabPage ViewAllTabPage2;
        private TabPage CreateTabPage3;
        private TabPage DeleteTabPage1;
        private TabPage UpdateTabPage1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label IdLabel1;
        private Button ShowButton1;
    }
}