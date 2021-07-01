using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

public static class ShoppingCart
{
	static By removeButton = By.Id("remove-sauce-labs-onesie");
	static By continueButton = By.Id("continue-shopping");
	static By checkoutButton = By.Id("checkout");

	public static void checkSelectedProduct(IWebDriver driver)
	{
		IWebElement body = driver.FindElement(By.TagName("body"));

		Assert.IsTrue(body.Text.Contains("Sauce Labs Onesie"));

		Assert.IsTrue(body.Text.Contains("Sauce Labs Bike Light"));

		Assert.IsTrue(body.Text.Contains("Sauce Labs Bolt T-Shirt"));

	}

	public static void removeItem(IWebDriver driver)
    {
		var remove = driver.FindElement(removeButton);
		remove.Click();
	}

	public static void clickContinueShopping(IWebDriver driver)
	{
		var continueShopping = driver.FindElement(continueButton);
		continueShopping.Click();
	}

	public static void clickCheckout(IWebDriver driver)
	{
		var checkout = driver.FindElement(checkoutButton);
		checkout.Click();
	}
}


