using OpenQA.Selenium;
using System;
using System.Configuration;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;

namespace Automacao.UI.Helpers
{
    public class DriverFactory
    {
        public static IWebDriver INSTANCE { get; set; } = null;

        public static void CreateInstance()
        {
            string browser = ConfigurationManager.AppSettings["browser"].ToString();
            string execution = ConfigurationManager.AppSettings["execution"].ToString();
            string seleniumHub = ConfigurationManager.AppSettings["seleniumHub"].ToString();
            string headless = ConfigurationManager.AppSettings["headless"].ToString();

            if (INSTANCE == null)
            {
                switch (browser)
                {
                    case "chrome":
                        if (execution.Equals("local"))
                        {
                            ChromeOptions chrome = new ChromeOptions();
                            chrome.AddArgument("enable-automation");
                            chrome.AddArgument("--no-sandbox");
                            chrome.AddArgument("--disable-infobars");
                            chrome.AddArgument("--disable-dev-shm-usage");
                            chrome.AddArgument("--disable-browser-side-navigation");
                            chrome.AddArgument("--disable-gpu");

                            if (headless.Equals("headless-true"))
                            {
                                chrome.AddArgument("--headless");
                            }

                            chrome.AddArgument("--window-size=1920,1080");
                            chrome.PageLoadStrategy = PageLoadStrategy.Normal;
                            INSTANCE = new ChromeDriver(chrome);

                        }

                        if (execution.Equals("remota"))
                        {
                            ChromeOptions chrome = new ChromeOptions();
                            chrome.AddArgument("no-sandbox");
                            chrome.AddArgument("--allow-running-insecure-content");
                            chrome.AddArgument("--lang=pt-BR");

                            INSTANCE = new RemoteWebDriver(new Uri(seleniumHub), chrome.ToCapabilities());
                        }

                        break;

                    case "ie":
                        if (execution.Equals("local"))
                        {
                            INSTANCE = new InternetExplorerDriver();
                        }

                        if (execution.Equals("remota"))
                        {
                            InternetExplorerOptions ie = new InternetExplorerOptions();
                            INSTANCE = new RemoteWebDriver(new Uri(seleniumHub), ie.ToCapabilities());
                        }

                        break;

                    case "firefox":
                        if (execution.Equals("local"))
                        {
                            INSTANCE = new FirefoxDriver();
                        }

                        if (execution.Equals("remota"))
                        {
                            FirefoxOptions firefox = new FirefoxOptions();
                            firefox.SetPreference("intl.accept_languages", "pt-BR");
                            INSTANCE = new RemoteWebDriver(new Uri(seleniumHub), firefox.ToCapabilities());
                        }

                        break;

                    case "edge":
                        if (execution.Equals("local"))
                        {
                            INSTANCE = new EdgeDriver();
                        }

                        if (execution.Equals("remota"))
                        {
                            EdgeOptions edge = new EdgeOptions();
                            INSTANCE = new RemoteWebDriver(new Uri(seleniumHub), edge.ToCapabilities());
                        }

                        break;

                    default:
                        throw new Exception("O browser informado não existe ou não é suportado pela automação");
                }
            }
        }

        public static void QuitDriver()
        {
            INSTANCE.Quit();
            INSTANCE = null;
        }
    }
}
