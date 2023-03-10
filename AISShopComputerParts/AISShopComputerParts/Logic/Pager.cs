using System;
using System.Data;

namespace AISShopComputerParts.Logic
{
    public static class Pager
    {
        public static DataTable Return(DataTable dataTable, int countRow, int page)
        {
            if (countRow <= 0)
                throw new ArgumentException("count row low null");
            if (page <= 0)
                throw new ArgumentException("page low null");
            if (Math.Ceiling(dataTable.Rows.Count / Convert.ToDouble(countRow)) < page)
                throw new ArgumentException("there are not so many rows in the table");

            var result = new DataTable();
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                var copyColumn = dataTable.Columns[i].ColumnName;
                result.Columns.Add(copyColumn);
            }
            for (int i = countRow * (page - 1); i < countRow * page; i++)
            {
                if (i >= dataTable.Rows.Count)
                    break;
                var copyrow = dataTable.Rows[i].ItemArray;
                result.Rows.Add(copyrow);
            }
            return result;
        }
    }
}
