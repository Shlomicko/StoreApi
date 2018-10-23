using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreApi.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Get()
        {
            Product product = MockData.GetData();
            return Ok();
        }

        public IActionResult Poop
        {

        }
    }
}
