using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

public static class LoginPage
{
	By userNameTextbox = By.id("user-name");
	By passwordTextbox = By.id("password");
	By loginButton = By.id("login-button");

	public static void inputLogin(IWebDriver driver, string username, string password)
    {
		IWebDriver username = driver.FindElement(userNameTextbox);
		IWebDriver pswd = driver.FindElement(passwordTextbox);
		IWebDriver submit = driver.FindElement(loginButton);
		username.Click();
		username.SendKeys(username);
		pswd.Click();
		pswd.SendKeys(password);
		submit.Click();


	}
}
