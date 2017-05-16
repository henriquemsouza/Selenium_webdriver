using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;
    static void Main()
    {
        string url1 = "http://testing.todorvachev.com/special-elements/text-input-field/";
 
      
        driver.Navigate().GoToUrl(url1);


        textBox = driver.FindElement(By.Name("username"));
        textBox.SendKeys("teste test");
        Thread.Sleep(3000);
        Console.WriteLine(textBox.GetAttribute("value"));
        Console.WriteLine(textBox.GetAttribute("maxlength"));

        //textBox.Clear();
        Thread.Sleep(9000);

        driver.Quit();


    }
   
   

}

