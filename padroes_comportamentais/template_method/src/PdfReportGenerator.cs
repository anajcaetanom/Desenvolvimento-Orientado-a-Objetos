﻿namespace template_method;

public class PdfReportGenerator : ReportGenerator
{
    protected override void Export()
    {
        Console.WriteLine("Exporting to PDF...");
    }
}