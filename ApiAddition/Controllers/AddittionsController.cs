using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAddition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddittionsController : ControllerBase
    {  //httpget
        [HttpGet]
        public int Add(int numA, int numB)
        {
            return numA + numB;   //funcion de suma
        }
    }
}
