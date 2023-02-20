﻿namespace AISShopComputerParts.Logic.MySql.DBStructure
{
    public class Column
    {
        public readonly string Name;
        public readonly ColumnType Type;

        public Column(string name, ColumnType type)
        {
            Name = name;
            Type = type;
        }
    }
}
