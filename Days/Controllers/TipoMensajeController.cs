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
    public class TipoMensajeController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<TipoMensaje> Get()
        {
            using (var context = new AmaneContext())
            {
                return context.TipoMensajes.ToList();
            }


        }
    }
}
