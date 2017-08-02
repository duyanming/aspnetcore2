using System;
using dym.IRepository;
using System.Collections.Generic;
using Dapper;
using dym.Model;

namespace dym.Repository
{
    public class BaseRepository:EngineData.DataBase,IBaseRepository
    {
        public string GetTestName()
        {
            return "BaseRepository";
        }
        public List<T> GetList<T>(string where = null)
        {
            return db.Query<T>($"select * from {typeof(T).Name} {where}").AsList<T>();
        }
        public Boolean Delete<T>(string Where)
        {
            if (string.IsNullOrWhiteSpace(Where))
            {
                throw new ArgumentNullException("必须指定 Where 条件！");
            }
            return db.Execute($"delete from  {typeof(T).Name} {Where}") > 0;
        }
    }
}
