namespace TemplatePattern
{
    internal class GeneratedReport
    {
        private readonly bool _isPassed;

        public GeneratedReport(bool isPassed)
        {
            _isPassed = isPassed;
        }

        public bool IsPassed()
        {
            return _isPassed;
        }
    }
}
