using AISShopComputerParts.Logic.MySql.DBStructure;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using Table = AISShopComputerParts.Logic.MySql.DBStructure.Table;

namespace AISShopComputerParts.Logic.MySql
{
    static public class MySqlAdapter
    {
        public const string ALL = "*";
        public const string TRUE = "true";
        public const string DEFAULT = "DEFAULT";
        public const string EQUALS = " = ";

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

        static public void EditStringByID(Table table, params string[] values)
        {
            values = ConvertToColumnTypes(table, values);
            values = ConvertToСolumnEquality(table, values);
            string quary = MySqlQueryGenerator.UpdateSet(
                table.Name, values[0], values);
            MySqlExecutor.GetInstance().QueryExecute(quary);
        }

        static public void DeleteStringByID(Table table, int id)
        {
            string quary = MySqlQueryGenerator.DeleteFrom(
                table.Name, table.Columns[0].Name + EQUALS + id.ToString());
            MySqlExecutor.GetInstance().QueryExecute(quary);
        }

        static private string[] ConvertToСolumnEquality(Table table, string[] values)
        {
            for (int i = 0; i < table.Columns.Length; i++)
            {
                values[i] = table.Columns[i].Name.ToString() + EQUALS + values[i];
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
                    case ColumnType.Id:
                        values[i] = values[i] == DEFAULT ? DEFAULT : Convert.ToInt32(values[i]).ToString();
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
