using AISShopComputerParts.Logic.MySql.DBStructure;
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
        public const string AND = " AND ";


        static public DataTable ReturnAll(Table table)
        {
            string query = MySqlQueryGenerator.Select(ALL, table.Name, TRUE);
            return MySqlExecutor.GetInstance().QueryReturn(query);
        }

        static public DataTable ReturnRows(Table table, string condition)
        {
            string query = MySqlQueryGenerator.Select(ALL, table.Name, condition);
            return MySqlExecutor.GetInstance().QueryReturn(query);
            
        }

        static public DataTable ReturnColumn(Table table, Column column)
        {
            string query = MySqlQueryGenerator.Select(column.Name, table.Name, TRUE);
            return MySqlExecutor.GetInstance().QueryReturn(query);
        }

        static public void AddAllString(Table table, params string[] values)
        {
            values = MySqlTableConverter.ConvertToColumnTypes(table, values);
            string quary = MySqlQueryGenerator.InsertInto(table.Name, values);
            MySqlExecutor.GetInstance().QueryExecute(quary);
        }

        static public void EditStringByID(Table table, params string[] values)
        {
            values = MySqlTableConverter.ConvertToColumnTypes(table, values);
            values = MySqlTableConverter.ConvertToСolumnEquality(table, values);
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
    }
}
