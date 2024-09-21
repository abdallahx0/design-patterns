namespace ChainOfResponsibility
{

    public class Request
    {

        private readonly string _type;
        private readonly bool _isAuthenticated;
        private readonly bool _isAuthorized;
        private readonly bool _hasPassedSecurityChecks;

        public Request(string type, bool isAuthenticated, bool isAuthorized, bool hasPassedSecurityChecks)
        {
            _type = type;
            _isAuthenticated = isAuthenticated;
            _isAuthorized = isAuthorized;
            _hasPassedSecurityChecks = hasPassedSecurityChecks;
        }

        public new string GetType()
        {
            return _type;
        }

        public bool IsAuthenticated()
        {
            return _isAuthenticated;
        }

        public bool IsAuthorized()
        {
            return _isAuthorized;
        }

        public bool IsHasPassedSecurityChecks()
        {
            return _hasPassedSecurityChecks;
        }
    }

}
