namespace TemplatePattern
{
    internal class PdfCVReportGeneration : CVReportGeneration
    {
        protected override Data ExtractData(string file)
        {
            Console.WriteLine("extracting data from PDF");

            return new();
        }
    }
}
