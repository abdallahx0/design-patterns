namespace ChainOfResponsibilityPattern
{
    public class RequestProcessor
    {

        private readonly IMiddlewareHandler _middlewareChainHandler;

        public RequestProcessor(IMiddlewareHandler middlewareChainHandler)
        {
            _middlewareChainHandler = middlewareChainHandler;
        }

        public Response processRequest(Request request)
        {
            Console.WriteLine("processing request");
            if (!_middlewareChainHandler.Handle(request))
            {
                return new Response("Request failed!", false);
            }

            return new Response("Request Successfully Processed", true);
        }
    }
}
