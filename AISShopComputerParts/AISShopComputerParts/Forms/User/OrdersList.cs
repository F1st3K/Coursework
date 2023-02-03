using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class OrdersList : Form
    {
        public OrdersList()
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
            var form = new OrderViewer();
            this.Hide();
            form.Show();
        }
    }
}
