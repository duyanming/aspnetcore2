using System;
using System.Collections.Generic;

namespace dym.IRepository
{
    public interface IBaseRepository
    {
        List<T> GetList<T>(string where = null);
        Boolean Delete<T>(string Where);
    }
}
