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
