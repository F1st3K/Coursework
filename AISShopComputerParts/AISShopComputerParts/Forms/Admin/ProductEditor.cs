using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class ProductEditor : Form
    {
        public ProductEditor()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var form = new AdminPanel();
            this.Hide();
            form.Show();
        }
    }
}
