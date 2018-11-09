using System;

namespace Core
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
