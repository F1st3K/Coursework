using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using AISShopComputerParts.Logic;
using AISShopComputerParts.Logic.MySql;
using AISShopComputerParts.Logic.MySql.DBStructure;

namespace AISShopComputerParts
{
    public partial class OrdersRecorder : Form
    {
        private DataGridViewRow _currentRow;
        private DataTable _globalTable;
        private string[] _idsStaffs;
        private bool SortByDate;
        private int _countRows;
        
        public OrdersRecorder()
        {
            _globalTable = new DataTable();
            _countRows = 13;
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
            _globalTable = MySqlAdapter.ReturnAll(DatabaseStructure.Orders);
            AddSelectionComboboxes();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            try
            {
                dataGridView.DataSource = Pager.Return(_globalTable, _countRows, Convert.ToInt32(pageNumber.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            _idsStaffs = staffs.ToArray();
            staff.SelectedIndex = staff.Items.Count - 1;
        }

        private void OnFilter(object sender, EventArgs e)
        {
            if (_idsStaffs is null) return;
            string condition = "orders.date >= '"+dateStart.Value.ToString("yyyy-MM-dd HH:mm:ss")+"' AND " +
                               "orders.date <= '"+dateFinish.Value.ToString("yyyy-MM-dd HH:mm:ss")+"'";
            if (staff.SelectedIndex != staff.Items.Count-1)
                condition += " AND orders.idStaff = " + _idsStaffs[staff.SelectedIndex];
            if (statusPositive.Checked == false)
                condition += " AND orders.status != 1";
            if (statusNegative.Checked == false)
                condition += " AND orders.status != 2";
            string query = MySqlQueryGenerator.Select(
                MySqlAdapter.ALL,
                DatabaseStructure.Orders.Name,
                condition);
            _globalTable = MySqlExecutor.GetInstance().QueryReturn(query);
            UpdateDataGridView();
        }
        
        private void OnSearch(object sender, EventArgs e)
        {
            var searchRow = SearcherOnDataGridView.ReturnIndexFirst(_globalTable, textSearch.Text);
            pageNumber.Text = Convert.ToInt32(Math.Ceiling((searchRow + 1) / Convert.ToDouble(_countRows))).ToString();
            int rowNumber = searchRow % _countRows;
            UpdateDataGridView();
            if (_currentRow != null)
                _currentRow.Selected = false;
            _currentRow = dataGridView.Rows[rowNumber];
            if (_currentRow != null)
                _currentRow.Selected = true;
        }
        
        private void OnSort(object sender, EventArgs e)
        {
            _globalTable.DefaultView.Sort = "date";
            symbolSort.Text = SortByDate ? "↓" : "↑";
            UpdateDataGridView();
            SortByDate = !SortByDate;
        }
        
        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (_currentRow != null)
                _currentRow.Selected = false;
            _currentRow = dataGridView.Rows[e.RowIndex];
            _currentRow.Selected = true;
        }

        private void dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            countStrings.Text = dataGridView.Rows.Count.ToString();
            var generalPrice = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[5].Value.ToString() == "Выполнен")
                    generalPrice += Convert.ToInt32(dataGridView.Rows[i].Cells[4].Value);
            }

            allPrice.Text = generalPrice.ToString();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            pageNumber.Text = (Convert.ToInt32(pageNumber.Text) + 1).ToString();
            UpdateDataGridView();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            pageNumber.Text = (Convert.ToInt32(pageNumber.Text) - 1).ToString();
            UpdateDataGridView();
        }
    }
}
