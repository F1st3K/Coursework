using AISShopComputerParts.Logic.MySql;
using AISShopComputerParts.Logic.MySql.DBStructure;
using MySqlX.XDevAPI.Relational;
using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class CategoryEditor : Form
    {
        private DataGridViewRow _currentRow;

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
            UpdateDataGridView();
            DisableMode();
        }

        private void UpdateDataGridView()
        {
            dataGridView.DataSource = MySqlAdapter.ReturnAll(DatabaseStructure.Categories);
        }

        private void EnableAddMode()
        {
            add.Enabled = true;
            edit.Enabled = false;
            delete.Enabled = false;
        }

        private void EnableEditMode()
        {
            add.Enabled = false;
            edit.Enabled = true;
            delete.Enabled = false;
        }

        private void EnableDeleteMode()
        {
            add.Enabled = false;
            edit.Enabled = false;
            delete.Enabled = true;
        }

        private void DisableMode()
        {
            dataGridView.ClearSelection();
            _currentRow = null;
            add.Enabled = false;
            edit.Enabled = false;
            delete.Enabled = false;
            ClearInputField();
        }

        private void ClearInputField()
        {
            categoryName.Text = String.Empty;
        }

        private void FillInputFields()
        {
            categoryName.Text = _currentRow.Cells[1].Value.ToString();
        }

        private bool FieldsIsPass()
        {
            return categoryName.Text == String.Empty;
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (_currentRow == dataGridView.Rows[e.RowIndex])
            {
                DisableMode();
            }
            else
            {
                _currentRow = dataGridView.Rows[e.RowIndex];
                _currentRow.Selected = true;
                FillInputFields();
                EnableDeleteMode();
            }

        }

        private void ChangedInputField(object sender, EventArgs e)
        {
            if (_currentRow != null)
                EnableEditMode();
            else EnableAddMode();
        }

        private void AddClick(object sender, EventArgs e)
        {
            if (FieldsIsPass())
            {
                MessageBox.Show("Не все поля заполнены верно!!!");
                return;
            }
            MySqlAdapter.AddAllString(DatabaseStructure.Categories, MySqlAdapter.DEFAULT, categoryName.Text);
            UpdateDataGridView();
            DisableMode();
        }

        private void EditClick(object sender, EventArgs e)
        {
            if (FieldsIsPass())
            {
                MessageBox.Show("Не все поля заполнены верно!!!");
                return;
            }
            MySqlAdapter.EditStringByID(DatabaseStructure.Categories,
                _currentRow.Cells[0].Value.ToString(), categoryName.Text);
            UpdateDataGridView();
            DisableMode();
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить текущую запись?", 
                "Внимание! УДАЛЕНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.No)
                return;
            MySqlAdapter.DeleteStringByID(DatabaseStructure.Categories,
                Convert.ToInt32(_currentRow.Cells[0].Value));
            UpdateDataGridView();
            DisableMode();
        }
    }
}
