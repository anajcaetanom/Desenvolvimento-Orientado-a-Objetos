namespace template_method;

public class ExcelReportGenerator : ReportGenerator
{
    protected override void Export()
    {
        Console.WriteLine("Exporting to Excel...");
    }

    protected override void GenerateContent()
    {
        Console.WriteLine("Generating content for Excel...");
    }
}