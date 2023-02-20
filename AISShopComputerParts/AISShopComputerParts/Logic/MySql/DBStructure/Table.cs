namespace AISShopComputerParts.Logic.MySql.DBStructure
{
    public class Table
    {
        public readonly string Name;
        public readonly Column[] Columns;

        public Table(string name, params Column[] columns)
        {
            Name = name;
            Columns = columns;
        }
    }
}
