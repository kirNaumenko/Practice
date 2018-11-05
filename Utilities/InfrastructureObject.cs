using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Utilities
{
    public class InfrastructureObject
    {
	    public IWebDriver WebDriver => Browser.GetInstance();

    }
}
