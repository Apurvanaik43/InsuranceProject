using LatestInsuranceProject.TestComponents;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using IsuranceDemoProject.Pages;
using System.Text.Json;

namespace IsuranceDemoProject.TestComponents
{
    public class BaseClass :DriverHelper
    {

        public WebDriverWait wait;
        public LoginPage loginPage;
        public HomePage homePage;



        public IWebDriver initializeWebdriver()
        {
             driver = null;
            string browserName = BaseClass.getPropertyValue("browser");

            if (browserName.Equals("chrome"))
            {
                 driver =new ChromeDriver();

            }
            else if (browserName.Equals("firefox"))
            {
                driver = new FirefoxDriver();

            }

            else if (browserName.Equals("edge"))
            {
                driver = new EdgeDriver();

            }
            else
            {
                Console.WriteLine("Invalid Browser Selected");
            }

            driver.Manage().Window.Maximize();
             wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
          



            return driver;




        }

        [SetUp]
        public void setUp()
        {
            IWebDriver driver =initializeWebdriver();
            driver.Navigate().GoToUrl(BaseClass.getPropertyValue("url"));
            loginPage = new LoginPage(driver);
            homePage = loginPage.loginToApplication(BaseClass.getPropertyValue("username"), BaseClass.getPropertyValue("password"));
            homePage.waitforElementtobeClickable(homePage.getUserEmailEle()); 
            Assert.That(homePage.getUserEmail, Is.EqualTo("apurvanaik42@gmail.com").IgnoreCase);
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
        }




       
        public static String getPropertyValue(String key)
        {
            String fpath = Path.GetFullPath(Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"..\..\..\")) + "DataFiles\\ProjectConfig.txt";
            string value = null;
            using (var reader = new StreamReader(fpath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    if (line.Contains(key))
                    {
                        value = line.Replace(key, "");
                        value = value.Replace("=", "");
                        value = value.Trim();
                        break;
                    }

                }
            }

            return value;
        }



       
    }
}
