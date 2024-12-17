using OpenQA.Selenium;

namespace AutomationCore.Drivers
{
    public static class DriverFactory
    {
        public static IWebDriver GetDriver(string browser)
        {
            IDriver driver;
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    //throw new ArgumentException($"Unsupported driver type: {browser}");
                    driver = new ChromeDriver();
                    break;
            }
            //IDriver driver = browser switch
            //{
            //    "Chrome" => new ChromeDriver(),
            //    "Edge" => new EdgeDriver(),
            //    _ => throw new ArgumentException($"Unsupported browser: {browser}")
            //};
            return driver.CreateDriver();
        }
    }
}
