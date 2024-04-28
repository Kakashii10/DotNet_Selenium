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
        [Category("Smoke")]        
        public void IsPrime_InputIs1_ReturnFalse1()
        {

            Console.WriteLine("shdsjdhs",driver);
            driver.Quit();
        }

        [Test]
        [Category("Regression")]
        public void IsPrime_InputIs1_ReturnFalse2()
        {

            Console.WriteLine("shdsjd231s", driver);
            driver.Quit();
        }

        [Test]
        [Category("Smoke")]
        public void IsPrime_InputIs1_ReturnFalse3()
        {

            Console.WriteLine("shdsjdhs1", driver);
            driver.Quit();
        }

        [Test]
        [Category("Smoke")]
        public void IsPrime_InputIs1_ReturnFalse4()
        {

            Console.WriteLine("shds453jdhs", driver);
            driver.Quit();
        }

        [Test]
        [Category("Regression")]
        public void IsPrime_InputIs1_ReturnFalse5()
        {

            Console.WriteLine("shd756sjdhs", driver);
            driver.Quit();
        }
    }
}
