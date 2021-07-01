using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


public class Browser_Operation
{
    IWebDriver driver;
        public void Init_Browser()
        {
           driver = new ChromeDriver(@"C:\Users\Lanre\Downloads\chromedriver_win32 (5)");
            driver.Manage().Window.Maximize();
        }

        public IWebDriver getDriver()
        { 
        return driver;

        }
    
        public string Title
        {
            get { return driver.Title; }
        }
        public void Goto(string url)
        {
            driver.Url = url;
        }
        public string Geturl
        {
            get { return driver.Url; }
        }
        public void Close()
        {
            driver.Quit();
        }
}

