using OpenQA.Selenium;

namespace Core.Elements
{
    public abstract class BaseElement : InfrastructureObject
    {

	    private IWebElement element;

		public IWebElement WebElement { get; set; }

    }
}
