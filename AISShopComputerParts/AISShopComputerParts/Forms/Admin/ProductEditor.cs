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

        private void BackClick(object sender, EventArgs e)
        {
            var form = new AdminPanel();
            this.Hide();
            form.Show();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            //update gridview
            //load combobox
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //add change delete disable
            //update current row
            //bold row
            //delete enable
        }

        private void ChangedInputField(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            //add change delete disable
            //if (currentRow != null)
            //    change enable
            //else
            //    add enable
        }

        private void AddClick(object sender, EventArgs e)
        {
            //check fields
            //quary insert into
            //update gridview
            //clear input fields
            //add change delete disable
        }

        private void EditClick(object sender, EventArgs e)
        {
            //check fields
            //quary update set
            //update gridview
            //clear input fields
            //add change delete disable
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            //quary delete
            //update gridview
            //clear input fields
            //add change delete disable
        }
    }
}
