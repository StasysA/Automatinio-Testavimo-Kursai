using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work
{
    internal class CheckBoxDemo
    {
            
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://demo.anhtester.com/basic-checkbox-demo.html";
        }
        [Test]
        public static void TestSingleCheckBox()
        {
            IWebElement singleCheckBox = _driver.FindElement(By.Id("isAgeSelected"));
            singleCheckBox.Click();

            IWebElement singleCheckBoxResult = _driver.FindElement(By.Id("txtAge"));
            Assert.AreEqual("Success - Check box is checked", singleCheckBoxResult.Text, "Message is wrong!");
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }
    }
}
