namespace ProxyPattern
{
    public class RemoteService : IProxy
    {
        private static readonly string ProductsEndpoint = "https://dummyjson.com/products";
        private static readonly string RecipesEndpoint = "https://dummyjson.com/recipes";

        public async Task<string> GetAllProductsAsync()
        {
            try
            {
                Console.WriteLine("Fetching products...");
                await Task.Delay(2000);

                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(ProductsEndpoint);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error fetching products", e);
            }
        }

        public async Task<string> GetAllRecipesAsync()
        {
            try
            {
                Console.WriteLine("Fetching recipes...");
                await Task.Delay(2000);

                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(RecipesEndpoint);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error fetching recipes", e);
            }
        }
    }
}
