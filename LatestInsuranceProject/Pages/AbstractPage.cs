using IsuranceDemoProject.TestComponents;
using LatestInsuranceProject.TestComponents;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LatestInsuranceProject.Pages
{
    [TestFixture]
    public class AbstractPage  
    {

        IWebDriver driver;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);

        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Request Quotation')]")]
        private IWebElement RequestQuotationLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Retrieve Quotation')]")]
        private IWebElement RetrieveQuotationLink;

        [FindsBy(How = How.XPath, Using = "//a[(text()='Profile')]")]
        private IWebElement profileLink;

        [FindsBy(How = How.XPath, Using = "//a[(text()='Profile')]")]
        private IWebElement editProfileLink;

        public void clikOnRequestQuotationLink()
        {
            RequestQuotationLink.Click();

        }

        public void clikOnRetrieveQuotationLink()
        {
            RetrieveQuotationLink.Click();

        }

        public void clikOnprofileLink()
        {
            profileLink.Click();

        }

        public void clickOneditProfileLink()
        {
            editProfileLink.Click();

        }






        public void waitforElementtobeClickable(IWebElement ele)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(ele));
        }


        public void selectfromDropDown(IWebElement ele,String text)
        {
        
          SelectElement select = new SelectElement(ele);
            select.SelectByText(text);
        }
    }
}
