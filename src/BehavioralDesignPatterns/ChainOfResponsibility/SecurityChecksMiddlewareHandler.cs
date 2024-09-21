namespace ChainOfResponsibilityPattern
{
    public class SecurityChecksMiddlewareHandler : AbstractMiddlewareHandler
    {
        public override bool Handle(Request request)
        {
            Console.WriteLine("Checking if request pass security checks...");
            if (!request.IsHasPassedSecurityChecks())
            {
                Console.WriteLine("Request failed to pass security checks...");
                return false;
            }
            return base.Handle(request);
        }
    }

}
