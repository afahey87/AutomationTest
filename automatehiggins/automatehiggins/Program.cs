using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace automatehiggins
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.higgins3.com/");
            IWebElement element = driver.FindElement(By.Id("s"));
            element.Click();
            element.SendKeys("Printer");
            System.Threading.Thread.Sleep(2000);


            IWebElement element2 = driver.FindElement(By.Id("searchsubmit"));
            element2.Click();
            System.Threading.Thread.Sleep(2000);



        }
    }
}
