namespace TDD.UI
{
    public class DB : IDB
    {
        public int GetDBValue()
        {
            return 200;
        }

        public Product GetProduct()
        {
            throw new System.NotImplementedException();
        }
    }
}
