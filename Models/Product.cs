namespace GroceryStockApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int RestockThreshold { get; set; }
    }
}
