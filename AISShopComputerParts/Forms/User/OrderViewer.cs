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
