namespace AISShopComputerParts.Logic.MySql.DBStructure
{
    static internal class DatabaseStructure
    {
        static public readonly string Name = "dbshopcomputerparts";
        static public readonly Table Categories;
        static public readonly Table CompositionsOrders;
        static public readonly Table Orders;
        static public readonly Table Products;
        static public readonly Table Staffs;
        static public readonly Table Users;

        static DatabaseStructure()
        {
            Categories = new Table(
                "categories",
                new Column("idCategory", ColumnType.Number),
                new Column("name", ColumnType.String));
            CompositionsOrders = new Table(
                "compositions_orders",
                new Column("idCompositionsOrders", ColumnType.Number),
                new Column("idOrder", ColumnType.Number),
                new Column("idProduct", ColumnType.Number),
                new Column("countProduct", ColumnType.Number));
            Orders = new Table(
                "orders",
                new Column("idOrder", ColumnType.Number),
                new Column("date", ColumnType.DataTime),
                new Column("idUser", ColumnType.Number),
                new Column("countPosition", ColumnType.Number),
                new Column("price", ColumnType.Number));
            Products = new Table(
                "products",
                new Column("idProduct", ColumnType.Number),
                new Column("name", ColumnType.String),
                new Column("characteristic", ColumnType.String),
                new Column("idCategory", ColumnType.Number),
                new Column("linkPhoto", ColumnType.String),
                new Column("count", ColumnType.Number),
                new Column("price", ColumnType.Number));
            Staffs = new Table(
                "staffs",
                new Column("idStaff", ColumnType.Number),
                new Column("fullName", ColumnType.String),
                new Column("post", ColumnType.String),
                new Column("phoneNumber", ColumnType.String));
            Users = new Table(
                "users",
                new Column("idUser", ColumnType.Number),
                new Column("login", ColumnType.String),
                new Column("password", ColumnType.String),
                new Column("status", ColumnType.String),
                new Column("idStaff", ColumnType.Number));
        }

    }

    internal class Table
    {
        public readonly string Name;
        public readonly Column[] Columns;

        public Table(string name, params Column[] columns)
        {
            Name = name;
            Columns = columns;
        }
    }

    internal class Column
    {
        public readonly string Name;
        public readonly ColumnType Type;

        public Column(string name, ColumnType type)
        {
            Name = name;
            Type = type;
        }
    }

    enum ColumnType
    {
        Number,
        String,
        DataTime,
    }

}
