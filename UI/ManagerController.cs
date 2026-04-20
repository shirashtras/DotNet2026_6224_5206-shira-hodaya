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

namespace UI
{
    public partial class ManagerController : Form
    {


        public ManagerController()
        {

            InitializeComponent();

            //this.BackgroundImage = Image.FromFile("third-background.jpg");
            //BackgroundImageLayout = ImageLayout.Stretch;


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
        public enum Types { PRODUCT, SALE, CUSTOMER }

        private Types type;

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e, Types type)
        {
            switch (type)
            {
                case Types.PRODUCT:
                    dataGridView1.DataSource = Factory.Get().iProduct.ReadAll();
                    break;
                case Types.SALE:
                    dataGridView1.DataSource = Factory.Get().iSale.ReadAll();
                    break;
                case Types.CUSTOMER:
                    dataGridView1.DataSource = Factory.Get().iCustomer.ReadAll();
                    break;
            }
            }

            private void ViewOneTabPage1_Click(object sender, EventArgs e)
            {

            }

            private void ManagerController_Load(object sender, EventArgs e)
            {

            }
        }
    } 
