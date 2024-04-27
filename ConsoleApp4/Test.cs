using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Test
    {
        IWebDriver driver = null;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(); 
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {

            Console.WriteLine("shdsjdhs",driver);
            driver.Quit();
        }
    }
}
