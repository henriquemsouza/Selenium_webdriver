using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        string url1 = "http://testing.todorvachev.com/selectors/class-name/";
        string classname1 = "testClass";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url1);

        IWebElement element = driver.FindElement(By.ClassName(classname1));

        GreenMessage(element.Text);

        Thread.Sleep(6000);

        driver.Quit();


    }
   
    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

}

