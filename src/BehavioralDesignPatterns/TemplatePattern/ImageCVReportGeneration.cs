namespace TemplatePattern
{
    internal class ImageCVReportGeneration : CVReportGeneration
    {
        protected override Data ExtractData(string file)
        {
            Console.WriteLine("extracting data from an image...");

            return new();
        }
    }
}
