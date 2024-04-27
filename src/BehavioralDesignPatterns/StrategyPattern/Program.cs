
using StrategyPattern;
using StrategyPattern.Strategies.Payment;
using StrategyPattern.Strategies.Pricing;

Product wallet = new Product("wallet", new RegularPricingStrategy());
decimal walletPrice = wallet.CalculatePrice(200);
Console.WriteLine(walletPrice);

Product laptop = new Product("laptop", new PremiumPricingStrategy());
decimal laptopPrice = laptop.CalculatePrice(5000);
Console.WriteLine(laptopPrice);

Product mobile = new Product("mobile", new GoldPricingStrategy());
decimal mobilePrice = mobile.CalculatePrice(3500);
Console.WriteLine(mobilePrice);

Checkout visaCard = new Checkout(new VisaCardPaymentStrategy());
visaCard.ProcessPayment(walletPrice);

Checkout paypal = new Checkout(new PayPalPaymentStrategy());
paypal.ProcessPayment(laptopPrice);

Checkout bank = new Checkout(new BankTransferPaymentStrategy());
bank.ProcessPayment(mobilePrice);