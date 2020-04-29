using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
           IEnumerable<Product> productList;
           ProductService productService  = new ProductService();
           productList = productService.GetProductList();
           return Ok(productList);
        }

        
    }
}
