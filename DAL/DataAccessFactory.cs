using DAL.EF;
using DAL.Interface;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<BGroup, int, bool> BGroupDataAccess()
        {
            return new BGroupRepo();

        }
    }
}
