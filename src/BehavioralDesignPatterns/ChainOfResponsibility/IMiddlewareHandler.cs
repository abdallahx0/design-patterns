namespace ChainOfResponsibility
{
    public interface IMiddlewareHandler
    {
        IMiddlewareHandler SetNext(IMiddlewareHandler middlewareHandler);
        bool Handle(Request request);
    }

}
