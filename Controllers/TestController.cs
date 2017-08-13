using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testapi.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public String Get()
        {
            return new ContatoDAO().Nomes() ;
        }

        [HttpGet("{id}")]
        public String Get(int id)
        {
            return new ContatoDAO().Id(id) ;
        }
    }
}