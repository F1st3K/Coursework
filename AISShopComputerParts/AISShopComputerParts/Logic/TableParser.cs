using System.Data;

namespace AISShopComputerParts.Logic
{
    static public class TableParser
    {
        static public string[] ParseData(DataTable table)
        {
            string[] data = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                    data[i] += table.Rows[i][j].ToString() + " \t ";
            }
            return data;
        }
    }
}
