using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement elementFromTheDropDownMenu;
    static IWebElement dropDownMenu;


    static void Main()
    {

        ChromeOptions options = new ChromeOptions();
        IWebDriver driver = new ChromeDriver();


        string url1 = "http://testing.todorvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nthchild(3)";



        driver.Navigate().GoToUrl(url1);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));
        Console.WriteLine(dropDownMenu.GetAttribute("value"));

        Thread.Sleep(1000);

        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector("dropDownMenuElements"));
        Console.WriteLine(elementFromTheDropDownMenu.GetAttribute("value"));
        elementFromTheDropDownMenu.Click();

        Thread.Sleep(9000);

        driver.Quit();


    }
   
   

}

