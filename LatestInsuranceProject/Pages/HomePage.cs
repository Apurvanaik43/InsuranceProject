using LatestInsuranceProject.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsuranceDemoProject.Pages
{
    public class HomePage :AbstractPage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver) : base(driver)
        {
            
     
            this.driver = driver;
            PageFactory.InitElements(driver, this);


        }


        [FindsBy(How=How.XPath,Using = "//h4")]
        private IWebElement userEmail { get; set; } 


       public string getUserEmail()
        {
            return userEmail.Text;
        }
        public IWebElement getUserEmailEle()
        {
            return userEmail;
        }
    }
}
