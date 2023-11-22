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
    public class LoginPage :AbstractPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver) :base(driver) {
            PageFactory.InitElements(driver, this);
            this.driver = driver;

           
        }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "password")]
        private IWebElement passwordTextBox { get; set; }


        [FindsBy(How=How.XPath,Using = "//input[@name='submit']")]
        private IWebElement loginBtn { get; set; } 


        public HomePage loginToApplication(String username,String password)
        {
            emailTextBox.SendKeys(username);
            passwordTextBox.SendKeys(password);
            loginBtn.Click();
            return new HomePage(driver);

        }
    }
}
