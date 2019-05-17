using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationUITestingProject
{   [TestFixture]
    class NUnitTest
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize() {
            driver = new ChromeDriver();
            //driver = new ChromeDriver(@"C:\Users\Admin\Desktop\AutomatedUITesting\ChromeDriver.exe");
        }

        [Test (Description ="First Test")]
        public void FirstTest() {
            
            driver.Url = "https://www.google.com";      
            
        }

        [Test (Description ="Second Test")]
        public void SecondTest()
        {          
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();
            IWebElement link = driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();           
        }


        [TearDown]
        public void EndTest() {

            driver.Close();
        }

    }
}
