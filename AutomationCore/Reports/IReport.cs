namespace AutomationCore.Reports
{
    public interface IReport
    {
        void IntializeReport();
        void LogTestStep(string step, string status);
        void GenerateReport();
    }
}
