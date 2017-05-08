using System;
using Dapper;
using MySql.Data.MySqlClient;

namespace dym.Context
{
    public class Context
    {
        public static MySqlConnection Conn = new MySqlConnection(Const.AppSettings.ConnStr);
    }
}
