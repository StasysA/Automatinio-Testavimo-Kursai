using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class HomeWork1
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://testsheepnz.github.io/BasicCalculator.html#main-body";
        }

        [TestCase("25", "25.5", "50.5", TestName = "25 + 25.5 = 55.5")]
        [TestCase("1.99", "0.959", "2.949", TestName = "1.99 + 0.959 = 2.949")]
       
        public static void TestCalculator(string number1, string number2, string expectedResult)
        {
            IWebElement firstNumberInputField = _driver.FindElement(By.Id("number1Field"));
            firstNumberInputField.Clear();
            firstNumberInputField.SendKeys(number1);

            IWebElement secondNumberInputField = _driver.FindElement(By.Id("number2Field"));
            secondNumberInputField.Clear();
            secondNumberInputField.SendKeys(number2);

            IWebElement submitButton = _driver.FindElement(By.Id("calculateButton"));
            submitButton.Click();

            IWebElement result = _driver.FindElement(By.Id("numberAnswerField"));
            Assert.AreEqual(expectedResult, result.GetAttribute("value").ToString(), "Answer is wrong");

        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }
    }
}
