using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;
    static void Main()
    {
        string url1 = "http://testing.todorvachev.com/special-elements/check-button-test-3/";
        string option = "3";

        driver.Navigate().GoToUrl(url1);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) >  input[type=\"checkbox\"]:nth-child("+ option + ")"));
        // element = driver.FindElement(By.XPath("//*[@id=\"post-33\"]/div/p[7]/input[" +option + "]"));

        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("This checkbox is  checked!");
        }
        else
        {
            Console.WriteLine("This checkbox is Not checked!");
        }

        checkBox.Click();//clica
        Thread.Sleep(9000);

        driver.Quit();


    }
   
   

}

