using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Refactor
{
  public interface IReadable
    {
        void Get(int id);
        void GetAll(int id);

    }
}
