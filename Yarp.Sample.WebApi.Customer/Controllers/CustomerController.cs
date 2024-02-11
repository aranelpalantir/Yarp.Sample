using Microsoft.AspNetCore.Mvc;
using Yarp.Sample.WebApi.Customer.Models;

namespace Yarp.Sample.WebApi.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new CustomerResponseModel()
            {
                Customers = new List<CustomerResponseModel.Customer>
                {
                    new CustomerResponseModel.Customer{
                       Id = 1,
                       Name = "Test 1 Customer Name",
                       Email="Test 1 Customer Email",
                       Address="Test 1 Customer Address"
                    },
                    new CustomerResponseModel.Customer{
                       Id = 2,
                       Name = "Test 2 Customer Name",
                        Email="Test 2 Customer Email",
                       Address="Test 2 Customer Address"
                    },
                    new CustomerResponseModel.Customer{
                       Id = 3,
                       Name = "Test 3 Customer Name",
                        Email="Test 3 Customer Email",
                       Address="Test 3 Customer Address"
                    }
                }
            });
        }
    }
}
