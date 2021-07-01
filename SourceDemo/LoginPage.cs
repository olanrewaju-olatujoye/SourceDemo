using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

public static class LoginPage
{
    static By userNameTextbox = By.Id("user-name");
    static By passwordTextbox = By.Id("password");
	static By loginButton = By.Id("login-button");

	public static void inputLogin(IWebDriver driver, string username, string password)
    {
		var usrnme = driver.FindElement(userNameTextbox);
		var pswd = driver.FindElement(passwordTextbox);
		var submit = driver.FindElement(loginButton);
		usrnme.Click();
		usrnme.SendKeys(username);
		pswd.Click();
		pswd.SendKeys(password);
		submit.Click();


	}
}
