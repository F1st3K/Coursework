using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class OrderEditor : Form
    {
        public OrderEditor()
        {
            InitializeComponent();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            var form = new OrdersRecorder();
            this.Hide();
            form.Show();
        }
    }
}
