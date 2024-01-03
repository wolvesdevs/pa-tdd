namespace TDD.UI
{
    public sealed class Product
    {
        public Product(int productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
        }

        public int ProductId { get; }
        public string ProductName { get; }
    }
}
