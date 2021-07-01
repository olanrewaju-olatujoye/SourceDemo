using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

public static class CheckoutInformation
{
	static By firstNameTextbox = By.Id("first-name");
	static By lastNameTextbox = By.Id("last-name");
	static By ZipCodeTextbox = By.Id("postal-code");
	static By continueButton = By.Id("continue");

	public static void inputInfo(IWebDriver driver)
	{
		var first = driver.FindElement(firstNameTextbox);
		var last = driver.FindElement(lastNameTextbox);
		var zip = driver.FindElement(ZipCodeTextbox);
		var contnue = driver.FindElement(continueButton);
		first.Click();
		first.SendKeys("Olanrewaju");
		last.Click();
		last.SendKeys("Olatujoye");
		zip.Click();
		zip.SendKeys("07106");
		contnue.Click();


	}
}
