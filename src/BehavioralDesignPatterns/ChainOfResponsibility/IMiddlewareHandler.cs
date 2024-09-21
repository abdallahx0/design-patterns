namespace ChainOfResponsibilityPattern
{
    public interface IMiddlewareHandler
    {
        IMiddlewareHandler SetNext(IMiddlewareHandler middlewareHandler);
        bool Handle(Request request);
    }

}
