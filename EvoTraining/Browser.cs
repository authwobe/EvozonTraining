
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EvoTraining
{
    public class Browser
    {
        private static IWebDriver _webDriver;


        public static void GoTo(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }


        public static void Close()
        {
            _webDriver.Quit();
        }
        public static void CreateNew()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--window-size=1920,1080");

            _webDriver = new ChromeDriver(options);
            _webDriver.Manage().Window.Maximize();
        }

    }
}
