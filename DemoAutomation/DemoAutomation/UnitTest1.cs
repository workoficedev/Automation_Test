using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace DemoAutomation
    {
        public class Tests
        {
            IWebDriver driver;
            [SetUp]
            public void StartBrowser()
            {
                //Methods -getUrl, click-
                //chromedriver.exe on chrome browser
                //99 .exe (99)
                //WebDriverManager-(
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
                //driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
                //driver.Navigate().GoToUrl("https://selenium.dev");
                //driver.Quit();
            }

            [Test]
            public void Test1()
            {
                driver.Url = "https://rahulshettyacademy.com/#/index";
                TestContext.Progress.WriteLine(driver.Title);
                TestContext.Progress.WriteLine(driver.Url);
                //driver.PageSource
                driver.Close();
                //driver.Quit();
                //Assert.Pass();
            }
        }
    }