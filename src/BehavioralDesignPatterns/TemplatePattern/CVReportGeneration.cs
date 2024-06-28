namespace TemplatePattern
{
    internal abstract class CVReportGeneration
    {
        public GeneratedReport GenerateCVReport(string cvFilePath)
        {
            var file = ReadFile(cvFilePath);
            var extractedData = ExtractData(file);
            var analyzedData = AnalyzeData(extractedData);
            return GenerateReportOf(analyzedData);
        }

        protected abstract Data ExtractData(string file);

        private string ReadFile(string filePath)
        {
            Console.WriteLine("reading file from: " + filePath);

            return filePath;
        }

        private AnalyzedData AnalyzeData(Data data)
        {
            Console.WriteLine("analyzing data...");

            return new();
        }

        private GeneratedReport GenerateReportOf(AnalyzedData analyzedData)
        {
            Console.WriteLine("generating report...");
            return new GeneratedReport(true);
        }
    }
}
