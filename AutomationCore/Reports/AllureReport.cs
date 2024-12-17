//using Allure.Net.Commons;
//using CsvHelper;
//using System;
//using System.IO;
//using TechTalk.SpecFlow.CommonModels;

//namespace AutomationCore.Reports
//{
//    public class AllureReport : IReport
//    {
//        private readonly AllureLifecycle _allure;
//        public AllureReport()
//        {
//            _allure = AllureLifecycle.Instance;
//        }

//        /// <summary>
//        /// Generates the final Allure Report.
//        /// </summary>
//        public void IntializeReport()
//        {
//            Console.WriteLine("Initializing Allure Report...");

//            // Set up Allure results directory
//            string allureResultsPath = Path.Combine(Directory.GetCurrentDirectory(), "allure-results");
//            if (!Directory.Exists(allureResultsPath))
//            {
//                Directory.CreateDirectory(allureResultsPath);
//            }

//            Environment.SetEnvironmentVariable("ALLURE_RESULTS_DIR", allureResultsPath);
//            Console.WriteLine($"Allure Results Directory: {allureResultsPath}");
//        }

//        /// <summary>
//        /// Logs a test step to the Allure Report.           
//        /// </summary>
//        /// <param name="step"></param>
//        /// <param name="status"></param>
//        public void LogTestStep(string step, string status)
//        {
//            Console.WriteLine($"Allure Log: Step - {step}, Status - {status}");

//            // Map status to Allure's status enumeration
//            Status allureStatus = status.ToLower() switch
//            {
//                "passed" => Status.passed,
//                "failed" => Status.failed,
//                "skipped" => Status.skipped,
//                _ => Status.broken
//            };

//            //_allure(step, allureStatus);
//        }

//        /// <summary>
//        /// Initializes the Allure Report with necessary setup.
//        /// </summary>
//        public void GenerateReport()
//        {
//            //Startservice allure serve allureResultsPath
//            var args1 = "cd project / allure - results";
//            var args2 = "allure generate . --clean - o.. / allure - report";
//            var args3 = "allure open ../allure-report";
//            string[] args = {args1, args2,args3};
//            CommandRunner.CommandRunner.RunCommand(args);
//        }
//    }
//}
