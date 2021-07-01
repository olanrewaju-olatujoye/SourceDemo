using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

public static class ProductPage
{
	static By dropDown = By.XPath("//*[@id='header_container']/div[2]/div[2]/span/select");
	static By sauce_labs_onesie = By.Id("add-to-cart-sauce-labs-onesie");
	static By sauce_labs_bike_light = By.Id("add-to-cart-sauce-labs-bike-light");
	static By sauce_labs_bolt_t_shirt = By.Id("add-to-cart-sauce-labs-bolt-t-shirt");
	static By shoppingcart = By.Id("shopping_cart_container");
	static By sauce_labs_backpack = By.Id("add-to-cart-sauce-labs-backpack");

	public static void sort_lowest(IWebDriver driver)
	{
		IWebElement drpdown = driver.FindElement(dropDown);
		OpenQA.Selenium.Support.UI.SelectElement drpdown_state = new SelectElement(drpdown);
		drpdown_state.SelectByValue("lohi");
	}

	public static void selectProduct(IWebDriver driver)
    {
		var onesie = driver.FindElement(sauce_labs_onesie);
		var bike_light = driver.FindElement(sauce_labs_bike_light);
		var bolt_t_shirt = driver.FindElement(sauce_labs_bolt_t_shirt);
		onesie.Click();
		bike_light.Click();
		bolt_t_shirt.Click();
	}

	public static void clickShoppingCart(IWebDriver driver)
	{
		var shpcrt = driver.FindElement(shoppingcart);
		shpcrt.Click();
	}

	public static void selectAProduct(IWebDriver driver)
	{
		var backpack = driver.FindElement(sauce_labs_backpack);
		backpack.Click();
	}
}

