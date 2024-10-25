using ProxyPattern;

IProxy dummyJsonApi = new CachedService();

Console.WriteLine("Calling No 1");
string productsBeforeCache = await dummyJsonApi.GetAllProductsAsync();
string recipesBeforeCache = await dummyJsonApi.GetAllRecipesAsync();
Console.WriteLine(productsBeforeCache);
Console.WriteLine(recipesBeforeCache);

Thread.Sleep(5000);

Console.WriteLine("Calling No 2");
string productsAfterCache = await dummyJsonApi.GetAllProductsAsync();
string recipesAfterCache = await dummyJsonApi.GetAllRecipesAsync();
Console.WriteLine(productsAfterCache);
Console.WriteLine(recipesAfterCache);