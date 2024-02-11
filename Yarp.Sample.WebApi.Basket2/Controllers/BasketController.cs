using Microsoft.AspNetCore.Mvc;
using Yarp.Sample.WebApi.Basket2.Models;

namespace Yarp.Sample.WebApi.Basket2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new BasketResponseModel
            {
                Items = new List<BasketResponseModel.BasketItem>()
               {
                   new BasketResponseModel.BasketItem
                   {
                       Name="BasketItem 1",
                       Price=100,
                       Quantity=1
                   },
                   new BasketResponseModel.BasketItem
                   {
                       Name="BasketItem 2",
                       Price=200,
                       Quantity=2
                   }
               }
            });
        }
    }
}
