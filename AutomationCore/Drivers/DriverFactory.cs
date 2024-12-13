using AutomationCore.Config;
using System;

namespace AutomationCore.Drivers
{
    public static class DriverFactory
    {
        public static IDriver GetDriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    return new ChromeDriver();
                case "Edge":
                    return new EdgeDriver();
                default:
                    throw new ArgumentException($"Unsupported driver type: {browser}");
            }
            //string browser = ConfigReader.GetAppSetting("Browser");
            //IDriver driver = browser switch
            //{
            //    "Chrome" => new ChromeDriver(),
            //    "Edge" => new EdgeDriver(),
            //    _ => throw new ArgumentException($"Unsupported browser: {browser}")
            //};
        }
    }
}
