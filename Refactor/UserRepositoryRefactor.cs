using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Refactor
{
    class UserRepositoryRefactor : IReadable, IWriteable, IRemovable
    {
        public void Create()
        {
          //
        }

        public void Get(int id)
        {
            //
        }

        public void GetAll(int id)
        {
           //
        }

        public void Remove(int id)
        {
           //
        }

        public void Update()
        {
           //
        }
    }
}
