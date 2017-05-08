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
    }
}
