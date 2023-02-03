using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class OrdersRecorder : Form
    {
        public OrdersRecorder()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var form = new AdminPanel();
            this.Hide();
            form.Show();
        }

        private void viewOrder_Click(object sender, EventArgs e)
        {
            var form = new OrderEditor();
            this.Hide();
            form.Show();
        }
    }
}
