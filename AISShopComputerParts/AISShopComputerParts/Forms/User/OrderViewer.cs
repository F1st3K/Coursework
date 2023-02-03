using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class OrderViewer : Form
    {
        public OrderViewer()
        {
            InitializeComponent();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            var form = new OrdersList();
            this.Hide();
            form.Show();
        }
    }
}
