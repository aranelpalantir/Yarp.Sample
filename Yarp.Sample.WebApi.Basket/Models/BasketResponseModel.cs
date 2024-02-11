namespace Yarp.Sample.WebApi.Basket.Models
{
    public class BasketResponseModel
    {
        public decimal Total => Items.Sum(r => r.Total);

        public List<BasketItem> Items { get; set; }
        public class BasketItem
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal Total => Price * Quantity;
        }
    }

}
