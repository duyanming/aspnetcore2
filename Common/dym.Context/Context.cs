using System;
using Dapper;
using MySql.Data.MySqlClient;

namespace dym.Context
{
    public class Context
    {
        public  MySqlConnection db = new MySqlConnection(Const.AppSettings.ConnStr);
    }
}
