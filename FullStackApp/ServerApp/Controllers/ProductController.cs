using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;

namespace ServerApp.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 999.99,
                Stock = 5,
                Category = new Category { Id = 101, Name = "Electronics" }
            },
            new Product
            {
                Id = 2,
                Name = "Desk Chair",
                Price = 199.99,
                Stock = 12,
                Category = new Category { Id = 102, Name = "Furniture" }
            }
        };

            return Ok(products);
        }
    }

}
