using System;

namespace AutomationCore.Reports
{
    public class ReportFactory
    {
        public static IReport CreateReport(string reportType)
        {
            return reportType.ToLower() switch
            {
              //  "allure" => new AllureReport(),
                "extent" => new ExtentReport(),
                _ => throw new ArgumentException("Invalid report type provided"),
            };
        }
    }
}