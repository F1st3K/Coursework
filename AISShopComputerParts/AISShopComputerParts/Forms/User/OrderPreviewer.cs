using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
