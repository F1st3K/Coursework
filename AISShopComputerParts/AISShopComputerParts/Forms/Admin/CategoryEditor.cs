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

        private void Back_Click(object sender, EventArgs e)
        {
            var form = new AdminPanel();
            this.Hide();
            form.Show();
        }

        private void CategoryEditor_Load(object sender, EventArgs e)
        {
            //update gridview
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //add change delete disable
            //update current row
            //bold row
            //delete enable
        }

        private void ChangedInputField(object sender, EventArgs e)
        {
            //add change delete disable
            //if (currentRow != null)
            //    change enable
            //else
            //    add enable
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //check fields
            //quary insert into
            //update gridview
            //clear input fields
            //add change delete disable
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //check fields
            //quary update set
            //update gridview
            //clear input fields
            //add change delete disable
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //quary delete
            //update gridview
            //clear input fields
            //add change delete disable
        }
    }
}
