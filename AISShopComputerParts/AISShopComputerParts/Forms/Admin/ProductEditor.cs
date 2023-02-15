using AISShopComputerParts.Logic.MySql;
using System;
using System.Data;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class ProductEditor : Form
    {
        private DataGridViewRow _currentRow;
        private string[] idsCategories;

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
            UpdateDataGridView();
            AddSelectionComboboxes();
            DisableMode();
        }

        private void UpdateDataGridView()
        {
            string query = MySqlQueryGenerator.Select("*", "products", true.ToString());
            dataGridView.DataSource = MySqlExecutor.GetInstance().QueryReturn(query);
        }

        private void AddSelectionComboboxes()
        {
            category.DropDownStyle = ComboBoxStyle.DropDownList;
            category.DataSource = ParseData("*", "categories");
            idsCategories = ParseData("idCategory", "categories");
            category.SelectedIndex = category.Items.Count - 1;
        }

        private string[] ParseData(string column, string tableName)
        {
            string condition = "true";
            string query = MySqlQueryGenerator.Select(column, tableName, condition);
            DataTable dt = MySqlExecutor.GetInstance().QueryReturn(query);
            string[] data = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                    data[i] += dt.Rows[i][j].ToString() + " \t ";
            }
            return data;
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
            name.Text = String.Empty;
            category.Text = String.Empty;
            charactirystics.Text = String.Empty;
            id.Value = 0;
            count.Value = 0;
            price.Value = 0;
        }

        private void FillInputFields()
        {
            id.Value = Convert.ToInt32(_currentRow.Cells[0].Value);
            name.Text = _currentRow.Cells[1].Value.ToString();
            charactirystics.Text = _currentRow.Cells[2].Value.ToString();
            category.SelectedIndex = FindSelectCombobox(_currentRow.Cells[3].Value.ToString(), idsCategories);

            count.Value = Convert.ToInt32(_currentRow.Cells[5].Value);
            price.Value = Convert.ToInt32(_currentRow.Cells[6].Value);
        }

        private int FindSelectCombobox(string value, string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == value)
                    return i;
            }
            return 0;
        }

        private bool FieldsIsPass()
        {
            return name.Text == String.Empty ||
                    category.Text == String.Empty ||
                    id.Value == 0 ||
                    count.Value == 0 ||
                    price.Value == 0;
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
            string quary = MySqlQueryGenerator.InsertInto("products",
                id.Value.ToString(),
                "'"+name.Text+"'",
                "'"+charactirystics.Text+"'",
                idsCategories[category.SelectedIndex],
                "'"+id.Value+"'",
                count.Value.ToString(),
                price.Value.ToString());
            MySqlExecutor.GetInstance().QueryExecute(quary);
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
            string quary = MySqlQueryGenerator.UpdateSet("categories",
                "idProduct = "+_currentRow.Cells[0].Value.ToString(),
                "name = '"+name.Text+"'",
                "charactirystics = '"+charactirystics.Text+"'",
                "idCategory = "+idsCategories[category.SelectedIndex],
                "count = " +count.Value.ToString(),
                "price = "+price.Value.ToString());
            MySqlExecutor.GetInstance().QueryExecute(quary);
            UpdateDataGridView();
            DisableMode();
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить текущую запись?",
                "Внимание! УДАЛЕНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.No)
                return;
            string quary = MySqlQueryGenerator.DeleteFrom("products",
                "idProduct = "+_currentRow.Cells[0].Value.ToString());
            MySqlExecutor.GetInstance().QueryExecute(quary);
            UpdateDataGridView();
            DisableMode();
        }
    }
}
