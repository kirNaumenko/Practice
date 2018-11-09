using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Core
{
    public class Browser
    {
	    private static IWebDriver driver;

	    public static IWebDriver GetInstance()
	    {
		    if (driver == null)
		    {
			    driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
		    }

		    return driver;
		}
	}
}
