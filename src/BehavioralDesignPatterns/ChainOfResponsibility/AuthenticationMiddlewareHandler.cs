namespace ChainOfResponsibility
{
    public class AuthenticationMiddlewareHandler : AbstractMiddlewareHandler
    {
        public override bool Handle(Request request)
        {
            Console.WriteLine("Checking if request is Authenticated...");
            if (!request.IsAuthenticated())
            {
                Console.WriteLine("Request is not authenticated");
                return false;
            }
            return base.Handle(request);
        }
    }

}
