using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ND
{
    class ND2
    {
        [TestCase("Chrome 104 on Windows 10", TestName = "Chrome 104 on Windows 10")]
        [TestCase("Firefox 104 on Windows 10", TestName = "Firefox 104 on Windows 10")]

        public static void TestBrowser(string expectedResult)
        {
            IWebDriver driver = new ChromeDriver();
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            Thread.Sleep(2000);

            IWebElement result = driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.AreEqual(expectedResult, result.Text, "ERROR");

            driver.Close();
        }

    }
}
