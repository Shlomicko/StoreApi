using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StoreApi.DAL;
using StoreApi.Data;
using StoreApi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IDataFetch _dataRepository = new MockData();
        // GET: /<controller>/
        public IActionResult Get()
        {
            List<IProduct> products = _dataRepository.GetData();
            string json = JsonConvert.SerializeObject(products);

            return Ok(json);
        }


        [HttpGet("(id)")]
        public IActionResult Get(int id)
        {
            IProduct product = _dataRepository.GetProductById(id);
            string json = JsonConvert.SerializeObject(product);
            return Ok(json);
        }


        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _dataRepository.AddProduct(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]dynamic obj)
        {
            bool removed = _dataRepository.RemoveProduct(obj.id);
            return Ok();
        }



    }
}
