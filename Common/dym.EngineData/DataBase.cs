using System;
using SqlSugar;

namespace dym.EngineData
{
    public class DataBase
    {
       // public  MySqlConnection db = new MySqlConnection(Const.AppSettings.ConnStr);
        public SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = Const.AppSettings.ConnStr, //必填
            DbType = DbType.MySql, //必填
            IsAutoCloseConnection = true, //默认false
            InitKeyType = InitKeyType.SystemTable //默认SystemTable
        }); 
    }
}
