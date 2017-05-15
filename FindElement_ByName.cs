using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");


        IWebElement element = driver.FindElement(By.Name("myName"));
        if (element.Displayed)
        {
            GreenMessage("Y, I CAN SEE");
        }
        else
        {
            RedMessage("I coudn't see  the element");
        }
        driver.Quit();
    }
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

}

