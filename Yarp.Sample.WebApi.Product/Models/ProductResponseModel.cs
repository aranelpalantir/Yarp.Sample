namespace Yarp.Sample.WebApi.Product.Models
{
    public class ProductResponseModel
    {
        public List<Product> Products { get; set; }
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}
