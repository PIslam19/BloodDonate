using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
   public class BGroupRepo : Interface.IRepo<BGroup, int, bool>
    {
        public bool Add( BGroup obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BGroup> Get()
        {
            throw new NotImplementedException();
        }

        public BGroup Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool UPDATE(BGroup obj)
        {
            throw new NotImplementedException();
        }
    }
}
