using System;
using dym.IRepository;

namespace dym.Repository
{
    public class BaseRepository:IBaseRepository
    {
        public string GetTestName()
        {
            return "BaseRepository";
        }
    }
}
