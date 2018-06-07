using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using akimedia_server.Models;

namespace akimedia_server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("HELLO WORLD");
        }

        [HttpGet("/api/[action]")]
        public async Task<IActionResult> Get()
        {
            //TODO: Implement Realistic Implementation
            await Task.Yield();
            return Ok(new int[]{1, 2, 3});
        }
    }
}
