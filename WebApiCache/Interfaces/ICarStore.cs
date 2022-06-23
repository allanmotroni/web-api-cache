using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCache.Entities;

namespace WebApiCache.Interfaces
{
   public interface ICarStore
   {
      IEnumerable<Car> List();
      Car Get(int id);
   }
}
