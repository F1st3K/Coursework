using AISShopComputerParts.Logic.MySql.DBStructure;
using System.Data;

namespace AISShopComputerParts.Logic.MySql
{
    static public class MySqlAdapter
    {
        const string ALL = "*";
        const string TRUE = "true";

        static public DataTable ReturnAll(Table table)
        {
            string query = MySqlQueryGenerator.Select(ALL, table.Name, TRUE);
            return MySqlExecutor.GetInstance().QueryReturn(query);
        }
    }
}
