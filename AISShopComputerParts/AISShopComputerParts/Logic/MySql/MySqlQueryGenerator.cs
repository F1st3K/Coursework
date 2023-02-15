namespace AISShopComputerParts.Logic.MySql
{
    internal static class MySqlQueryGenerator
    {
        public static string Select(string column, string tableName, string condition)
            => "SELECT " + column + " FROM " + tableName + " WHERE " + condition + ";";

        public static string InsertInto(string tableName, string[,] massValues)
        {
            string values = "";
            for (int i = 0; i < massValues.GetLength(0); i++)
            {
                values += "(";
                for (int j = 0; j < massValues.GetLength(1); j++)
                {
                    values += massValues[j, i];
                    if (j + 1 < massValues.GetLength(1))
                        values += ", ";
                }
                values += ")";
                if (i + 1 < massValues.GetLength(0))
                    values += ", ";
            }
            return "INSERT INTO " + tableName + " VALUES " + values + ";";
        }

        public static string InsertInto(string tableName, params string[] massValue)
        {

            string values = "";
            values += "(";
            for (int i = 0; i < massValue.Length; i++)
            {
                values += massValue[i];
                if (i + 1 < massValue.Length)
                    values += ", ";
            }
            values += ")";
            return "INSERT INTO " + tableName + " VALUES " + values + ";";
        }

        public static string UpdateSet(string tableName, string condition, params string[] massValue)
        {
            string values = "";
            for (int i = 0; i < massValue.Length; i++)
            {
                values += massValue[i];
                if (i + 1 < massValue.Length)
                    values += ", ";
            }
            return "UPDATE " + tableName + " SET " + values + " WHERE " + condition + ";";
        }

        public static string DeleteFrom(string table, string condition)
            => "DELETE FROM " + table + " WHERE " + condition + ";";

    }
}
