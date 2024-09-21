namespace ChainOfResponsibilityPattern
{
    public class Response
    {
        private readonly string _reason;
        private readonly bool _isSucceeded;

        public Response(string reason, bool isSucceeded)
        {
            _reason = reason;
            _isSucceeded = isSucceeded;
        }

        public string GetReason()
        {
            return _reason;
        }

        public bool IsSucceeded()
        {
            return _isSucceeded;
        }
    }
}
