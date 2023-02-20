using AISShopComputerParts.Logic.MySql.DBStructure;
using System;

namespace AISShopComputerParts.Logic.MySql
{
    static internal class MySqlTableConverter
    {
        static public string[] ConvertToСolumnEquality(Table table, string[] values)
        {
            for (int i = 0; i < table.Columns.Length; i++)
            {
                values[i] = table.Columns[i].Name.ToString() + MySqlAdapter.EQUALS + values[i];
            }
            return values;
        }

        static public string[] ConvertToColumnTypes(Table table, params string[] values)
        {
            if (table.Columns.Length != values.Length)
                throw new ArgumentException("values is not equels table values!");
            for (int i = 0; i < table.Columns.Length; i++)
            {
                switch (table.Columns[i].Type)
                {
                    case ColumnType.Id:
                        values[i] = values[i] == MySqlAdapter.DEFAULT ? MySqlAdapter.DEFAULT : Convert.ToInt32(values[i]).ToString();
                        break;
                    case ColumnType.Int:
                        values[i] = Convert.ToInt32(values[i]).ToString();
                        break;
                    case ColumnType.Varchar:
                        values[i] = "'" + values[i].ToString() + "'";
                        break;
                    case ColumnType.DateTime:
                        values[i] = "'" + Convert.ToDateTime(values[i]).ToString("YYYY-MM-DD hh:mm:ss") + "'";
                        break;
                    default:
                        break;
                }
            }
            return values;
        }
    }
}
