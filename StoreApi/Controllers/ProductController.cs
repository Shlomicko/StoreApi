using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StoreApi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        // GET: /<controller>/

        public IActionResult Get()
        {
            List<Product> products = MockData.GetData();
            string json = JsonConvert.SerializeObject(products);

            return Ok(json);
        }


       [HttpGet("(id)")]
        public IActionResult Get(int id)
        {
            Product product = MockData.GetProductById(id);
            string json = JsonConvert.SerializeObject(product);
            return Ok(json);
        }


        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            MockData.AddProduct(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]int id)
        {
            bool product = MockData.RemoveProduct(id);
            return Ok();
        }


       
    }
}
