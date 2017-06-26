using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;



namespace automatehiggins
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.higgins3.com/");
            System.Threading.Thread.Sleep(2000);
            


            
            //Assert try catch block to see if search box is one the page.
            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("s")).Displayed);
                Console.Write("Search box display . assert Pass");
            }
            catch (Exception e)
            {
                Console.WriteLine("Can not find Search Box . assert Fail");
                
            }
            // End Assert
            



            IWebElement element1 = driver.FindElement(By.Id("s"));
            System.Threading.Thread.Sleep(2000);
            element1.Click();
            element1.SendKeys("Printer");
            System.Threading.Thread.Sleep(2000);

           

            //Assert is button displayed.
            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("searchsubmit")).Displayed);
                Console.Write("Button display assert pass");
            }
            catch (Exception e)
            {
                Console.WriteLine("Can not find Button . assert Fail");

            }
            // End Assert



            IWebElement element2 = driver.FindElement(By.Id("searchsubmit"));
            element2.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement element3 = driver.FindElement(By.XPath("//a[contains(text(),'Datacard CD800 Card Printer')]"));
            element3.Click();
            System.Threading.Thread.Sleep(3000);
            
      
            driver.Close();
            //driver.Quit();
          


        }
    }
}
