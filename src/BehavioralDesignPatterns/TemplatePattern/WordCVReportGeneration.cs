namespace TemplatePattern
{
    internal class WordCVReportGeneration : CVReportGeneration
    {
        protected override Data ExtractData(string file)
        {
            Console.WriteLine("extracting data from word file");

            return new();
        }
    }
}
