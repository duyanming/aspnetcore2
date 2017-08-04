using System;
using System.Collections.Generic;
using dym.Model;
using System.Linq.Expressions;

namespace dym.LogicService
{
    public class PlatformModule : EngineData.DataBase
    {
        public PlatformModule()
        {
        }
        public List<T> Queryable<T>(Expression<Func<T, bool>> expression) where T : class, new()
        {
            return db.Queryable<T>().Where(expression).ToList();
        }
        public List<T> Queryable<T>() where T : class, new()
        {
            return db.Queryable<T>().ToList();
        }
        public int Deleteable<T>(Expression<Func<T, bool>> expression) where T : class, new()
        {
            return db.Deleteable<T>().Where(expression).ExecuteCommand();
        }
        public int Insertable<T>(T obj) where T : class, new() {
            return db.Insertable(obj).ExecuteCommand();
        }
        public int Updateable<T>(T obj) where T : class, new()
        {
            return db.Updateable(obj).ExecuteCommand();
        }
    }
}
