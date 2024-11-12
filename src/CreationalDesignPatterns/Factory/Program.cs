using Factory;

PaymentProcessor paymentProcessor = new PaymentProcessor(new InternationalPaymentMethodFactory());
paymentProcessor.ProcessPayment(CardType.VISA, 100, "Ahmed", "123", "123", "2025-12-21");