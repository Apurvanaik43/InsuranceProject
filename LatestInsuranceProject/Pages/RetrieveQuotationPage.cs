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
    public class RetriveQuotationPage : AbstractPage
    {
        IWebDriver driver;
        public RetriveQuotationPage(IWebDriver driver) :base(driver) {
            
            PageFactory.InitElements(driver, this);
            this.driver = driver;

           
        }


        [FindsBy(How=How.XPath,Using = "//input[@placeholder='identification number']")]
        private IWebElement textBox { get; set; }

      


       public RetriveQuotationDisplayPage retrieve_QuotationbyId(String identificationNumber)
        {
            textBox.SendKeys(identificationNumber);
          /*  Thread.Sleep(5000);
           // waitforElementtobeClickable(retriveBtn);
           // retriveBtn.Click();*/
            return new RetriveQuotationDisplayPage(driver);

        }
    }
}
