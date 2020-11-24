using Days.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Days.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoSalaController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<TipoSala> Get()
        {
            using (var context = new AmaneContext())
            {
                return context.TipoSalas.ToList();
            }


        }
    }
}
