using System.Windows.Forms;

namespace AISShopComputerParts.Logic
{
    public static class SearcherOnDataGridView
    {
        public static DataGridViewRow ReturnFirst(DataGridView table, string value)
        {
            for (int i = 0; i < table.Columns.Count; i++)
            {
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    if (table.Rows[j].Cells[i].Value != null &&
                        table.Rows[j].Cells[i].Value.ToString().Contains(value))
                    {
                        return table.Rows[j];
                    }
                }
            }
            return null;
        }
    }
}