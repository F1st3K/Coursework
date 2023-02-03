using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class CategoryEditor : Form
    {
        public CategoryEditor()
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
