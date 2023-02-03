using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class OrderPreviewer : Form
    {
        public OrderPreviewer()
        {
            InitializeComponent();
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            var form = new ManagerPanel();
            this.Hide();
            form.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var form = new OrderCreater();
            this.Hide();
            form.Show();
        }
    }
}
