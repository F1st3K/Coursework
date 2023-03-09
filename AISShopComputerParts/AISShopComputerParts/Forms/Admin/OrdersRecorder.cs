using System;
using System.Windows.Forms;
using AISShopComputerParts.Logic;
using AISShopComputerParts.Logic.MySql;
using AISShopComputerParts.Logic.MySql.DBStructure;

namespace AISShopComputerParts
{
    public partial class OrdersRecorder : Form
    {
        private DataGridViewRow _currentRow;
        private string[] idsStaffs;
        
        public OrdersRecorder()
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
            var form = new OrderEditor();
            this.Hide();
            form.Show();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            UpdateDataGridView();
            AddSelectionComboboxes();
        }

        private void UpdateDataGridView()
        {
            dataGridView.DataSource = MySqlAdapter.ReturnAll(DatabaseStructure.Orders);
        }

        private void AddSelectionComboboxes()
        {
            staff.DropDownStyle = ComboBoxStyle.DropDownList;
            staff.DataSource = TableParser.ParseData(
                MySqlAdapter.ReturnAll(DatabaseStructure.Staffs), " ");
            idsStaffs = TableParser.ParseData(
                MySqlAdapter.ReturnColumn(
                    DatabaseStructure.Staffs, DatabaseStructure.Staffs.Columns[0]), String.Empty);
            staff.SelectedIndex = staff.Items.Count - 1;
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

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            _currentRow = dataGridView.Rows[e.RowIndex];
            _currentRow.Selected = true;
        }
    }
}
