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
    class DemoQA
    {
        [Test]

        public static void TestFullNameInputField()
        {
            string name = "Friday";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement fullNameInputField = driver.FindElement(By.Id("userName"));
            fullNameInputField.SendKeys(name);

            IWebElement submitButton = driver.FindElement(By.CssSelector("#submit"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("name"));
            Assert.AreEqual($"Name:{name}", $"Name:{name}", "Name is wrong");
        }

    }

}
