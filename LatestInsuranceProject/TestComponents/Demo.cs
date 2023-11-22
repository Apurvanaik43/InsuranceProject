using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IsuranceDemoProject.TestComponents
{
    [TestFixture]
    public class Demo :BaseClass
    {

        [TestCase]
        public void test1()
        {
            IWebDriver driver = initializeWebdriver();
            driver.Close();

      

        }

    }
}
