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
    public class RequestQuotationPage : AbstractPage
    {
        IWebDriver driver;
        public RequestQuotationPage(IWebDriver driver) :base(driver) 
        {
            
            PageFactory.InitElements(driver, this);
            this.driver = driver;

           
        }


        [FindsBy(How=How.XPath,Using = "//select[@id='quotation_breakdowncover']")]
        private IWebElement breakDownCoverSelect { get; set; }



        [FindsBy(How = How.XPath, Using = "//input[@id='quotation_windscreenrepair_t']")]
        private IWebElement windscreenRepairRadioBtn_Y { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='quotation_incidents']")]
        private IWebElement incidents { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='quotation_vehicle_attributes_registration']")]
        private IWebElement registration { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='quotation_vehicle_attributes_mileage']")]
        private IWebElement annualMileage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='quotation_vehicle_attributes_value']")]
        private IWebElement estimatedValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='quotation_vehicle_attributes_parkinglocation']")]
        private IWebElement parkingLocationSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='quotation_vehicle_attributes_policystart_1i']")]
        private IWebElement startPolicy_YearSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='quotation_vehicle_attributes_policystart_2i']")]
        private IWebElement startPolicy_MonthSelect { get; set; }


        [FindsBy(How = How.XPath, Using = "//select[@id='quotation_vehicle_attributes_policystart_3i']")]
        private IWebElement startPolicy_DaySelect { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@value='Calculate Premium']")]
        private IWebElement calculatePremium { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='submit']")]
        private IWebElement saveQuotation { get; set; }

        [FindsBy(How = How.XPath, Using = "//html/body")]
        private IWebElement identificationNum { get; set; }




        public RetriveQuotationPage getQuotation(String breakdownVal,String incidentVal,String registrationVal,int milegaeVal,int estimatedVal,String parkingLocationVal,String yearVal,String monthVal,String dayVal){

            selectfromDropDown(breakDownCoverSelect, breakdownVal);
            windscreenRepairRadioBtn_Y.Click();
            incidents.SendKeys(incidentVal);
            registration.SendKeys(registrationVal);
            annualMileage.SendKeys(milegaeVal.ToString());
            estimatedValue.SendKeys(estimatedVal.ToString());
            selectfromDropDown(parkingLocationSelect, parkingLocationVal);
            selectfromDropDown(startPolicy_YearSelect, yearVal);
            selectfromDropDown(startPolicy_MonthSelect, monthVal);
            selectfromDropDown(startPolicy_DaySelect, dayVal);
            calculatePremium.Click();
            saveQuotation.Click();
            return new RetriveQuotationPage(driver);


        }

        public string getIdentificationNumber()
        {
            waitforElementtobeClickable(identificationNum);
            String txt = identificationNum.Text.Split(":")[1].Trim().Split("Please")[0];
            Console.WriteLine(txt);
            return txt;

        }
    }
}
