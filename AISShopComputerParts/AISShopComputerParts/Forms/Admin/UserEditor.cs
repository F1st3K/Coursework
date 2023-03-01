using AISShopComputerParts.Logic.MySql.DBStructure;
using AISShopComputerParts.Logic.MySql;
using AISShopComputerParts.Logic;
using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class UserEditor : Form
    {
        private DataGridViewRow _currentRow;
        private string[] idsStaffs;
        private string[] Statuses = new string[] { "admin", "user" };

        public UserEditor()
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
            dataGridView.DataSource = MySqlAdapter.ReturnAll(DatabaseStructure.Users);
        }

        private void AddSelectionComboboxes()
        {
            staff.DropDownStyle = ComboBoxStyle.DropDownList;
            staff.DataSource = TableParser.ParseData(MySqlAdapter.ReturnAll(DatabaseStructure.Staffs), "\t");
            idsStaffs = TableParser.ParseData(
                MySqlAdapter.ReturnColumn(DatabaseStructure.Staffs, DatabaseStructure.Staffs.Columns[0]),
                String.Empty);
            staff.SelectedIndex = staff.Items.Count - 1;
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            status.DataSource = Statuses;
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
            login.Text = String.Empty;
            password.Text = String.Empty;
            staff.Text = String.Empty;
            status.Text = String.Empty;
        }

        private void FillInputFields()
        {
            login.Text = _currentRow.Cells[1].Value.ToString();
            password.Text = _currentRow.Cells[2].Value.ToString();
            status.SelectedIndex = FindSelectCombobox(_currentRow.Cells[3].Value.ToString(), Statuses);
            staff.SelectedIndex = FindSelectCombobox(_currentRow.Cells[4].Value.ToString(), idsStaffs);
        }

        private int FindSelectCombobox(string value, string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (value.Equals(data[i]))
                    return i;
            }
            return 0;
        }

        private bool FieldsIsPass()
        {
            return login.Text == String.Empty ||
                   password.Text == String.Empty ||
                   staff.Text == String.Empty ||
                   status.Text == String.Empty;
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
            MySqlAdapter.AddAllString(DatabaseStructure.Users,
                MySqlAdapter.DEFAULT,
                login.Text,
                password.Text,
                Statuses[status.SelectedIndex],
                idsStaffs[staff.SelectedIndex]);
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
            MySqlAdapter.EditStringByID(DatabaseStructure.Users,
                _currentRow.Cells[0].Value.ToString(),
                login.Text,
                password.Text,
                Statuses[status.SelectedIndex],
                idsStaffs[staff.SelectedIndex]);
            UpdateDataGridView();
            DisableMode();
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить текущую запись?",
                "Внимание! УДАЛЕНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.No)
                return;
            MySqlAdapter.DeleteStringByID(DatabaseStructure.Products,
                Convert.ToInt32(_currentRow.Cells[0].Value));
            UpdateDataGridView();
            DisableMode();
        }
    }
}