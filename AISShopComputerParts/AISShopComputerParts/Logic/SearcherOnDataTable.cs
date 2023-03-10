using System.Data;

namespace AISShopComputerParts.Logic
{
    public static class SearcherOnDataGridView
    {
        public static int ReturnIndexFirst(DataTable table, string value)
        {
            for (int i = 0; i < table.Columns.Count; i++)
            {
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    if (table.Rows[j][i] != null &&
                        table.Rows[j][i].ToString().Contains(value))
                    {
                        return j;
                    }
                }
            }
            return 0;
        }
    }
}