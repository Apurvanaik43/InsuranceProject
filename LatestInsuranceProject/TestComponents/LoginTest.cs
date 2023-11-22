using IsuranceDemoProject.Pages;
using LatestInsuranceProject.DataFiles;
using NUnit.Framework.Internal.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IsuranceDemoProject.TestComponents
{
    [TestFixture]
    public class LoginTest :BaseClass
    {

        LoginPage loginPage;
        HomePage homePage;
        RequestQuotationPage requestQuotationPage;
        RetriveQuotationPage retriveQuotationPage;
        RetriveQuotationDisplayPage retriveQuotationDisplayPage;
      /*  [TestCase,Order(1)]
        public void loginTest_ValidInput()
        {
            homePage.waitforElementtobeClickable(homePage.getUserEmailEle());
            Assert.That(homePage.getUserEmail, Is.EqualTo("apurvanaik42@gmail.com").IgnoreCase);

        }*/


        [TestCase]
        public void request_Quotation() {
            requestQuotationPage = new RequestQuotationPage(driver);
            requestQuotationPage.clikOnRequestQuotationLink();
            retriveQuotationPage = requestQuotationPage.getQuotation("Roadside", "Anual", "United Kingdon", 22, 200, "Driveway/Carport", "2023", "December", "10");
            identificationNumber = requestQuotationPage.getIdentificationNumber();
            Console.WriteLine(identificationNumber);
         

        }

        [TestCase]

        public void retrieve_Quotation()
        {
            RetriveQuotationPage retriveQuotationPage =new RetriveQuotationPage(driver);
            retriveQuotationPage.clikOnRetrieveQuotationLink();
            RetriveQuotationDisplayPage retriveQuotationDisplayPage =retriveQuotationPage.retrieve_QuotationbyId(identificationNumber);
            ArrayList acctualsavedQuoation = retriveQuotationDisplayPage.retrieve_Saved_QuotationDetails();
            Console.WriteLine("Actual----------");
            foreach(Object a in acctualsavedQuoation)
            {
                Console.WriteLine(a);
            }

          
            ArrayList expectedList = ReadDatafromJson.readData("C:\\Users\\Apnaik\\source\\repos\\LatestInsuranceProject\\LatestInsuranceProject\\DataFiles\\expectedQuoatationVal.json");


            Console.WriteLine("Expeceted---------");
            foreach (Object a in acctualsavedQuoation)
            {
                Console.WriteLine(a);
            }
            
            Assert.AreEqual(acctualsavedQuoation, expectedList);
            Console.WriteLine("Apurva");


        }

       


    }
}
