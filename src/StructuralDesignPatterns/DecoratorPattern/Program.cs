using DecoratorPattern;

IBeverage coffeWithMilkAndSuger = new SugarDecorator(new MilkDecorator(new Coffee()));
Console.WriteLine(coffeWithMilkAndSuger.Prepare());

IBeverage teaWithMilk = new MilkDecorator(new Tea());
Console.WriteLine(teaWithMilk.Prepare());

IBeverage teaWithMint = new MintDecorator(new Tea());
Console.WriteLine(teaWithMint.Prepare());