namespace ProxyPattern
{
    public interface IProxy
    {
        Task<string> GetAllProductsAsync();
        Task<string> GetAllRecipesAsync();
    }

}
