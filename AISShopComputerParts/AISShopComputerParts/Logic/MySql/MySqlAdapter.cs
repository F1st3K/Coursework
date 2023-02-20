using AISShopComputerParts.Logic.MySql.DBStructure;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using Table = AISShopComputerParts.Logic.MySql.DBStructure.Table;

namespace AISShopComputerParts.Logic.MySql
{
    static public class MySqlAdapter
    {
        const string ALL = "*";
        const string TRUE = "true";
        const string DEFAULT = "DEFAULT";
        const string EQUALS = " = ";

        static public DataTable ReturnAll(Table table)
        {
            string query = MySqlQueryGenerator.Select(ALL, table.Name, TRUE);
            return MySqlExecutor.GetInstance().QueryReturn(query);
        }

        static public void AddAllString(Table table, params string[] values)
        {
            values = ConvertToColumnTypes(table, values);
            string quary = MySqlQueryGenerator.InsertInto(table.Name, values);
            MySqlExecutor.GetInstance().QueryExecute(quary);
        }

        static public void EditStringByID(Table table, int id, params string[] values)
        {
            values = ConvertToColumnTypes(table, values);
            values = ConvertToСolumnEquality(table, values);
            string quary = MySqlQueryGenerator.UpdateSet(
                table.Name, table.Columns[0] + EQUALS + id.ToString(), values);
            MySqlExecutor.GetInstance().QueryExecute(quary);
        }

        static private string[] ConvertToСolumnEquality(Table table, string[] values)
        {
            for (int i = 0; i < table.Columns.Length; i++)
            {
                values[i] = table.Columns[i].ToString() + EQUALS + values[i];
            }
            return values;
        }

        static private string[] ConvertToColumnTypes(Table table, params string[] values)
        {
            if (table.Columns.Length != values.Length)
                throw new ArgumentException("values is not equels table values!");
            for (int i = 0; i < table.Columns.Length; i++)
            {
                switch (table.Columns[i].Type)
                {
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
