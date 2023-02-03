using System;

namespace AISShopComputerParts.Logic.MySql
{
    internal sealed class MySqlQueryGenerator
    {
        private static MySqlQueryGenerator _instance;

        public static MySqlQueryGenerator GetInstance()
        {
            if (_instance == null)
                _instance = new MySqlQueryGenerator();
            return _instance;
        }

    }
}
