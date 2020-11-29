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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("[controller]")]
    public class HabitoController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Habito> Get()
        {
            using (var context = new AmaneContext())
            {
                return context.Habitos.ToList();
            }


        }
    }
}
