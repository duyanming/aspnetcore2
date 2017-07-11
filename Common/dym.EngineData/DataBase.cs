using System;
using Dapper;
using MySql.Data.MySqlClient;

namespace dym.EngineData
{
    public class DataBase
    {
        public  MySqlConnection db = new MySqlConnection(Const.AppSettings.ConnStr);
    }
}
