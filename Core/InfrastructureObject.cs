using OpenQA.Selenium;

namespace Core
{
    public class InfrastructureObject
    {
	    public IWebDriver WebDriver => Browser.GetInstance();

    }
}
