using BIApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void DoOrderbutton1_Click(object sender, EventArgs e)
        {
            CashiarController cashiarController = new CashiarController();
            // When the controller form is closed, show this Cashier form again
            cashiarController.FormClosed += (s, args) => this.Show();
            cashiarController.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
