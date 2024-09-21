using ChainOfResponsibility;

IMiddlewareHandler authenticationHandler = new AuthenticationMiddlewareHandler();
IMiddlewareHandler authorizationHandler = new AuthorizationMiddlewareHandler();
IMiddlewareHandler securietyChecksHandler = new SecurityChecksMiddlewareHandler();

authenticationHandler.SetNext(authorizationHandler)
    .SetNext(securietyChecksHandler);

RequestProcessor requestProcessor = new RequestProcessor(authenticationHandler);

Request successRequest = new Request(type: "GET", isAuthenticated: true, isAuthorized: true, hasPassedSecurityChecks: true);
var successResult = requestProcessor.processRequest(successRequest);
Console.WriteLine("Request is succeeded: " + successResult.IsSucceeded() + " because of: " + successResult.GetReason());

Request failureRequest = new Request(type: "GET", isAuthenticated: false, isAuthorized: true, hasPassedSecurityChecks: true);
var failureResult = requestProcessor.processRequest(failureRequest);
Console.WriteLine("Request is succeeded: " + failureResult.IsSucceeded() + " because of: " + failureResult.GetReason());
