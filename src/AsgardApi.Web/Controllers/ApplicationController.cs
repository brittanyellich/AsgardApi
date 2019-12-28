using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsgardApi.Web.Controllers
{
    [Route("")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var model = "You've reached the Asgard API!";
            return Ok(model);
        }
    }
}