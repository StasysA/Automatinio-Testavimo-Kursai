using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND
{
    class ND1
    {
        [Test]

        public static void TestFirstTask()
        {
            string number1 = "2";
            string number2 = "2";
          
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstNumberInputField = driver.FindElement(By.Id("number1"));
            firstNumberInputField.SendKeys(number1);

            IWebElement secondNumberInputField = driver.FindElement(By.Id("number2"));
            secondNumberInputField.SendKeys(number2);

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", result.Text, "Answer is wrong");

            driver.Close();
        }

        [Test]

        public static void TestSecondTask()
        {
            string number3 = "-5";
            string number4 = "3";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstNumberInputField = driver.FindElement(By.Id("number1"));
            firstNumberInputField.SendKeys(number3);

            IWebElement secondNumberInputField = driver.FindElement(By.Id("number2"));
            secondNumberInputField.SendKeys(number4);

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("-2", result.Text, "Answer is wrong");

            driver.Close ();

        }

        [Test]

        public static void TestThirdTask()
        {
            string number5 = "a";
            string number6 = "b";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstNumberInputField = driver.FindElement(By.Id("number1"));
            firstNumberInputField.SendKeys(number5);

            IWebElement secondNumberInputField = driver.FindElement(By.Id("number2"));
            secondNumberInputField.SendKeys(number6);

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("ERR", result.Text, "Answer is wrong");

            driver.Close();
        }
    }

}
