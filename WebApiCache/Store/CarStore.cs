using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCache.Entities;
using WebApiCache.Interfaces;

namespace WebApiCache.Store
{
   public class CarStore : ICarStore
   {
      private readonly IList<Car> _cars;
      private readonly int _max;
      public CarStore()
      {
         _max = 100;
         _cars = new List<Car>();
         for (int i = 1; i <= _max; i++)
         {
            _cars.Add(new() { Id = i, Name = "Car " + i });
         }
      }

      public Car Get(int id)
      {
         int indice = new Random().Next(1, _max);
         return _cars[indice];
      }

      public IEnumerable<Car> List()
      {
         int take = new Random().Next(1, _max);
         return _cars.Take(take).ToList();
      }
   }
}
