using AISShopComputerParts.Logic.MySql;
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

        private void BackClick(object sender, EventArgs e)
        {
            var form = new AdminPanel();
            this.Hide();
            form.Show();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            //update gridview
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //add change delete disable
            //update current row
                //if (current row == row)
                //    current row = null
                //    clear input fields
                //else
                //    bold row
                //    current row = row
                //    insert input fields
                //    delete enable
        }

        private void ChangedInputField(object sender, EventArgs e)
        {
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
