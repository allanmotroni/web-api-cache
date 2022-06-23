using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCache.Interfaces;

namespace WebApiCache.Controllers
{
   [Route("cars")]
   [ApiController]
   public class CarController : ControllerBase
   {
      private readonly ICarStore _store;
      public CarController(ICarStore store)
      {
         _store = store;
      }

      [HttpGet]
      public IActionResult Get()
      {
         return Ok(_store.List());
      }
   }
}
