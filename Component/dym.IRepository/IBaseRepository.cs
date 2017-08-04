using System;
using System.Collections.Generic;
using SqlSugar;

namespace dym.IRepository
{
    public interface IBaseRepository
    {
        SqlSugarClient db { get;}
    }
}
