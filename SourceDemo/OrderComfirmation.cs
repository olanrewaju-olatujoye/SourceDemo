using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

public static class OrderComfirmation
{
	public static void checkorderComfirmation(IWebDriver driver)
	{

		IWebElement body = driver.FindElement(By.TagName("body"));

		Assert.IsTrue(body.Text.Contains("THANK YOU FOR YOUR ORDER"));
	}

}
