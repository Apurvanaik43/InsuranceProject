using LatestInsuranceProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IsuranceDemoProject.Pages
{
    public class RetriveQuotationDisplayPage :AbstractPage
    {
        IWebDriver driver;
        public  ArrayList arrayList = null;
        public RetriveQuotationDisplayPage(IWebDriver driver) :base(driver) {
            
            PageFactory.InitElements(driver, this);
            this.driver = driver;

           
        }


        [FindsBy(How=How.XPath,Using = "//*[contains(text(),'Retrieve Quotation')]")]
        private IWebElement retrieveTitle { get; set; }

    /*    [FindsBy(How = How.XPath, Using = "//table[@border='1']//tbody//tr//td[2]")]
        private By expectedList { get; set; }
*/
     


        public ArrayList retrieve_Saved_QuotationDetails()
        {
            waitforElementtobeClickable(retrieveTitle);
           ICollection<IWebElement> OPlist = driver.FindElements(By.XPath("//table[@border='1']//tbody//tr//td[2]"));
            arrayList = new ArrayList();
            foreach (IWebElement list in OPlist)
            {
         
               
                arrayList.Add(list.Text);
            }
            return arrayList;

        }
        
            

        }
    }

