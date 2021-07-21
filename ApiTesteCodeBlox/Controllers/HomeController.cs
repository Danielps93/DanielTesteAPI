using ApiTesteCodeBlox.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTesteCodeBlox.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public Apresentacao Home()
        {
            return new Apresentacao();
        }
    }
}
