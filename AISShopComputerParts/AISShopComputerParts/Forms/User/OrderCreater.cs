using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class OrderCreater : Form
    {
        public OrderCreater()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var form = new ManagerPanel();
            this.Hide();
            form.Show();
        }

        private void viewOrder_Click(object sender, EventArgs e)
        {
            var form = new OrderPreviewer();
            this.Hide();
            form.Show();
        }
    }
}
