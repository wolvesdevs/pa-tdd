namespace TDD.UI
{
    public interface IDB
    {
        int GetDBValue();
        Product GetProduct();
        void SaveProduct(Product product);
    }
}
