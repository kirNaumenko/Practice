using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Utilities.PageObjects
{
    public class LoginPage : BasePage
    {
	    private readonly By userInputSelector = By.Id("txtUsername");
	    private readonly By passwordInputelector = By.Id("txtPassword");
		private readonly By loginButtonSelector = By.Id("gti");

	    public IWebElement UserInput => WebDriver.FindElement(userInputSelector);
	    public IWebElement PasswordInput => WebDriver.FindElement(passwordInputelector);
	    public IWebElement LoginButton => WebDriver.FindElement(loginButtonSelector);

		public void LogIn(string user = "Admin", string password = "admin123")
	    {
			UserInput.SendKeys(user);
			PasswordInput.SendKeys(password);
	    }

    }
}
