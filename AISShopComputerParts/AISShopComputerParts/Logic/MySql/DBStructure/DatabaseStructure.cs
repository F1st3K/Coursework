using System.Collections;

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

        static public readonly string AdminMode = "admin";
        static public readonly string UserMode = "user";

        static DatabaseStructure()
        {
            Categories = new Table(
                "categories",
                new Column("idCategory", ColumnType.Id),
                new Column("name", ColumnType.Varchar));
            CompositionsOrders = new Table(
                "compositions_orders",
                new Column("idCompositionsOrders", ColumnType.Int),
                new Column("idOrder", ColumnType.Id),
                new Column("idProduct", ColumnType.Int),
                new Column("countProduct", ColumnType.Int));
            Orders = new Table(
                "orders",
                new Column("idOrder", ColumnType.Id),
                new Column("date", ColumnType.DateTime),
                new Column("idUser", ColumnType.Int),
                new Column("countPosition", ColumnType.Int),
                new Column("price", ColumnType.Int));
            Products = new Table(
                "products",
                new Column("idProduct", ColumnType.Id),
                new Column("name", ColumnType.Varchar),
                new Column("characteristic", ColumnType.Varchar),
                new Column("idCategory", ColumnType.Int),
                new Column("linkPhoto", ColumnType.Varchar),
                new Column("count", ColumnType.Int),
                new Column("price", ColumnType.Int));
            Staffs = new Table(
                "staffs",
                new Column("idStaff", ColumnType.Id),
                new Column("fullName", ColumnType.Varchar),
                new Column("post", ColumnType.Varchar),
                new Column("phoneNumber", ColumnType.Varchar));
            Users = new Table(
                "users",
                new Column("idUser", ColumnType.Id),
                new Column("login", ColumnType.Varchar),
                new Column("password", ColumnType.Varchar),
                new Column("status", ColumnType.Varchar),
                new Column("idStaff", ColumnType.Int));
        }
    }
}
