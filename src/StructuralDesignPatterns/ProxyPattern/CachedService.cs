namespace ProxyPattern
{
    public class CachedService : IProxy
    {
        private readonly Dictionary<string, string> _cachingLayer;
        private static readonly string ProductsEndpoint = "https://dummyjson.com/products";
        private static readonly string RecipesEndpoint = "https://dummyjson.com/recipes";
        private readonly IProxy _dummyJsonApi;

        public CachedService()
        {
            _dummyJsonApi = new RemoteService();
            _cachingLayer = new Dictionary<string, string>();
        }

        public async Task<string> GetAllProductsAsync()
        {
            if (_cachingLayer.ContainsKey(ProductsEndpoint))
            {
                return _cachingLayer[ProductsEndpoint];
            }

            string productResponse = await _dummyJsonApi.GetAllProductsAsync();
            _cachingLayer[ProductsEndpoint] = productResponse;
            return productResponse;
        }

        public async Task<string> GetAllRecipesAsync()
        {
            if (_cachingLayer.ContainsKey(RecipesEndpoint))
            {
                return _cachingLayer[RecipesEndpoint];
            }

            string recipesResponse = await _dummyJsonApi.GetAllRecipesAsync();
            _cachingLayer[RecipesEndpoint] = recipesResponse;
            return recipesResponse;
        }
    }
}
