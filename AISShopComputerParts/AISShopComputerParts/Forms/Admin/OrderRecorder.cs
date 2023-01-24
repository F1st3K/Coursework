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
    public partial class OrderRecorder : Form
    {
        public OrderRecorder()
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
            var form = new ViewerOrder();
            this.Hide();
            form.Show();
        }
    }
}
