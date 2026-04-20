namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager  = new Manager();
            manager.FormClosed += (s, args) => this.Show();
            manager.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier cashier = new Cashier();
            cashier.FormClosed += (s, args) => this.Show();
            cashier.Show();
        }

    }
}
