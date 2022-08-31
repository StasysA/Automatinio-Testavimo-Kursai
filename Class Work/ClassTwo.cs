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
    class WORK1
    {
        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "ERR", TestName = "a + b = ERR")]

        public static void TestCalculator(string number1, string number2, string expectedResult)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstNumberInputField = driver.FindElement(By.Id("number1"));
            firstNumberInputField.Clear();
            firstNumberInputField.SendKeys(number1);

            IWebElement secondNumberInputField = driver.FindElement(By.Id("number2"));
            secondNumberInputField.Clear();
            secondNumberInputField.SendKeys(number2);

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual(expectedResult, result.Text, "Answer is wrong");

            driver.Close();
        }
    }
}
