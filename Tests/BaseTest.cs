using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Utilities;
using Utilities.PageObjects;

namespace Tests
{
	[TestFixture]
	public class BaseTest : InfrastructureObject
	{

		[SetUp]
		public void Initialize()
		{
		    WebDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
			new LoginPage().LogIn();
	    }

		[TearDown]

		public void CleanUp()
		{
			WebDriver.Close();
		}
	}
}
