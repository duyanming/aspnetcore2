using System;
using System.Collections.Generic;
using Dapper;
using dym.Model;

namespace dym.Logic
{
    public class Platform : Context.Context
    {
        public Platform()
        {
        }
        public List<T> GetList<T>(string where=null)
        { 
            return db.Query<T>($"select * from {typeof(T).Name} {where}").AsList<T>();
        }
        public Boolean Delete<T>(string Where)
        {
            if (string.IsNullOrWhiteSpace(Where))
            {
                throw new ArgumentNullException("必须指定 Where 条件！");
            }
            return db.Execute($"delete from  {typeof(T).Name} {Where}")>0;
        }
    }
}
