using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

public static class CheckOut
{
	static By finishbutton = By.Id("finish");
	public static void checkProductPresence(IWebDriver driver)
	{
		IWebElement body = driver.FindElement(By.TagName("body"));

		Assert.IsTrue(body.Text.Contains("Sauce Labs Bolt T-Shirt"));

		Assert.IsTrue(body.Text.Contains("Sauce Labs Bike Light"));

		Assert.IsTrue(body.Text.Contains("Sauce Labs Backpack"));


	}

	public static void checkTotalPrice(IWebDriver driver)
	{
		Assert.That(driver.PageSource, Does.Contain("$60.45"));
	}

	public static void clickFinish(IWebDriver driver)
	{
		var finish = driver.FindElement(finishbutton);
		finish.Click();
	}
}
