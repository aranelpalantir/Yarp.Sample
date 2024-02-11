using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yarp.Sample.WebApi.Product.Models;

namespace Yarp.Sample.WebApi.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new ProductResponseModel
            {
                Products = new List<ProductResponseModel.Product>
                {
                    new ProductResponseModel.Product {

                        Id = 1,
                        Name = "Product 1 Name",
                        Description = "Product 1 Description"
                    },
                    new ProductResponseModel.Product {

                        Id = 2,
                        Name = "Product 2 Name",
                        Description = "Product 2 Description"
                    },
                    new ProductResponseModel.Product {

                        Id = 3,
                        Name = "Product 3 Name",
                        Description = "Product 3 Description"
                    }
                }
            });
        }
    }
}
