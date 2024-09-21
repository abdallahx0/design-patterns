namespace ChainOfResponsibilityPattern
{
    public class AbstractMiddlewareHandler : IMiddlewareHandler
    {
        private IMiddlewareHandler? _nextHandler;
        public IMiddlewareHandler SetNext(IMiddlewareHandler middlewareHandler)
        {
            _nextHandler = middlewareHandler;
            return middlewareHandler;
        }

        public virtual bool Handle(Request request)
        {
            if (_nextHandler is { })
            {
                return _nextHandler.Handle(request);
            }
            return true;
        }
    }
}
