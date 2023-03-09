using System;
using System.Collections.Generic;
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
            AddSelectionComboboxes();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView.DataSource = MySqlAdapter.ReturnAll(DatabaseStructure.Orders);
        }

        private void AddSelectionComboboxes()
        {
            staff.DropDownStyle = ComboBoxStyle.DropDownList;
            var staffs = new List<string>();
            staffs.AddRange(TableParser.ParseData(
                MySqlAdapter.ReturnAll(DatabaseStructure.Staffs), " "));
            staffs.Add("Все");
            staff.DataSource = staffs.ToArray();
            staffs.Clear();
            staffs.AddRange(TableParser.ParseData(
                MySqlAdapter.ReturnColumn(
                    DatabaseStructure.Staffs, DatabaseStructure.Staffs.Columns[0]), String.Empty));
            staffs.Add("Все");
            idsStaffs = staffs.ToArray();
            staff.SelectedIndex = staff.Items.Count - 1;
        }

        private void OnFilter(object sender, EventArgs e)
        {
            string condition = "orders.date >= '"+dateStart.Value.ToString("yyyy-MM-dd HH:mm:ss")+"' AND " +
                               "orders.date <= '"+dateFinish.Value.ToString("yyyy-MM-dd HH:mm:ss")+"'";
            if (staff.SelectedIndex != staff.Items.Count-1)
                condition += " AND orders.idStaff = " + idsStaffs[staff.SelectedIndex];
            if (statusPositive.Checked == false)
                condition += " AND orders.status != 1";
            if (statusNegative.Checked == false)
                condition += " AND orders.status != 2";
            string query = MySqlQueryGenerator.Select(
                MySqlAdapter.ALL,
                DatabaseStructure.Orders.Name,
                condition);
            dataGridView.DataSource = MySqlExecutor.GetInstance().QueryReturn(query);
        }
        
        private void OnSearch(object sender, EventArgs e)
        {
            _currentRow = SearcherOnDataGridView.ReturnFirst(dataGridView, textSearch.Text);
            if (_currentRow != null)
                _currentRow.Selected = true;
        }
        
        private void OnSort(object sender, EventArgs e)
        {
            MessageBox.Show("sort");
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

        private void dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            countStrings.Text = dataGridView.Rows.Count.ToString();
        }
    }
}
