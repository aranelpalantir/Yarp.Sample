namespace Yarp.Sample.WebApi.Customer.Models
{
    public class CustomerResponseModel
    {
        public List<Customer> Customers { get; set; }
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
        }
    }
}
