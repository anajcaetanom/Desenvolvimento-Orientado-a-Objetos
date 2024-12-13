namespace template_method;

class Program
{
    static void Main(string[] args)
    {
        var pdfReport = new PdfReportGenerator();
        pdfReport.GenerateReport();

        var excelReport = new ExcelReportGenerator();
        excelReport.GenerateReport();
    }
}