using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestInsuranceProject.TestComponents
{
    public class DriverHelper
    {
        public static IWebDriver driver { get; set; }
        public static String identificationNumber { get; set; }
    }
}
