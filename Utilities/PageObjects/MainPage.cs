using System;
using System.Collections.Generic;
using System.Text;
using Core;
using OpenQA.Selenium;

namespace Utilities.PageObjects
{
    public class MainPage :BasePage
    {
	    private readonly By directoryPAgeLinkSelector = By.Id("menu_directory_viewDirectory");

	    public IWebElement DirectoryLink => WebDriver.FindElement(directoryPAgeLinkSelector);


	    public DirectoryPage NavigateToDirectoryPage()
	    {
			this.DirectoryLink.Click();
		    return new DirectoryPage();
	    }


	}
}
