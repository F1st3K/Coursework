using System.Windows.Forms;

namespace AISShopComputerParts.Logic
{
    public static class SearcherOnDataGridView
    {
        public static DataGridViewRow ReturnFirst(DataGridView table, string value)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (table.Rows[i].Cells[j] != null &&
                        table.Rows[i].Cells[j].ToString().Contains(value))
                    {
                        return table.Rows[i];
                    }
                }
            }
            return null;
        }
    }
}