using System;
using System.Collections.Generic;
using System.Text;
using Core;
using OpenQA.Selenium;

namespace Utilities.PageObjects
{
    public class AdminPage : BasePage
    {
	    private readonly By userInputSelector = By.Id("txtUsername");
	    private readonly By passwordInputelector = By.Id("txtPassword");
	    private readonly By loginButtonSelector = By.Id("gti");

	    public IWebElement UserInput => WebDriver.FindElement(userInputSelector);
	    public IWebElement PasswordInput => WebDriver.FindElement(passwordInputelector);
	    public IWebElement LoginButton => WebDriver.FindElement(loginButtonSelector);
	}
}
