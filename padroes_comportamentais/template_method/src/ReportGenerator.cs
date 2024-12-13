namespace template_method;

public abstract class ReportGenerator
{
    public void GenerateReport()
    {
        GenerateHeader();
        GenerateContent();
        Export();
    }
    
    protected void GenerateHeader()
    {
        Console.WriteLine("Generating report header...");
    }
    
    protected abstract void Export();

    protected virtual void GenerateContent()
    {
        Console.WriteLine("Generating default content...");
    }
}