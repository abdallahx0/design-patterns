namespace ChainOfResponsibility
{
    public class AuthorizationMiddlewareHandler : AbstractMiddlewareHandler
    {
        public override bool Handle(Request request)
        {
            Console.WriteLine("Checking if request is authorized...");
            if (!request.IsAuthorized())
            {
                Console.WriteLine("Request failed to be authorized...");
                return false;
            }
            return base.Handle(request);
        }
    }

}
