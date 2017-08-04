using System;
using dym.IRepository;
using System.Collections.Generic;
using dym.Model;
using SqlSugar;

namespace dym.Repository
{
    public class BaseRepository :IBaseRepository
    {
        SqlSugarClient IBaseRepository.db { get =>new EngineData.DataBase().db; }
    }
}
