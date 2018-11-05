using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.PageObjects;

namespace Utilities
{
    public abstract class BasePage : InfrastructureObject
	{
		public void Refresh()
		{
			this.WebDriver.Navigate().Refresh();
		}

		public void Open(Uri url)
		{
			this.WebDriver.Navigate().GoToUrl(url);
		}

		public void BackNavigation()
		{
			this.WebDriver.Navigate().Back();
		}
	}
}
