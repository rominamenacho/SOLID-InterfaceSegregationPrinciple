using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
   public class ReportRepository : IRepository
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
          //
        }

        public void GetAll()
        {
           //
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
//en el caso de implementar un repositorio de solo lectura,
//tendremos metodos que no podremos usar
//el principio plantea que es preferible modularizar, es decir
//tenes muchas interfaces especificas (e ir implementando solo 
//las necesarias) en vez de una sola interfaz obesa con mucha funcionalidad