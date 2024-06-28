using TemplatePattern;

CVReportGeneration pdfReportGeneration = new PdfCVReportGeneration();
GeneratedReport pdfGeneratedReport = pdfReportGeneration.GenerateCVReport("test file");
Console.WriteLine(pdfGeneratedReport.IsPassed());

Console.WriteLine("============================");

CVReportGeneration wordReportGeneration = new WordCVReportGeneration();
GeneratedReport wordGeneratedReport = wordReportGeneration.GenerateCVReport("test file");
Console.WriteLine(wordGeneratedReport.IsPassed());

Console.WriteLine("============================");

CVReportGeneration imageReportGeneration = new ImageCVReportGeneration();
GeneratedReport imageGeneratedReport = imageReportGeneration.GenerateCVReport("test file");
Console.WriteLine(imageGeneratedReport.IsPassed());
