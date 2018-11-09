using NUnit.Framework;

namespace Core
{
	[TestFixture]
	public class BaseTest : InfrastructureObject
	{

		[SetUp]
		public void Initialize()
		{
		    WebDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
	    }

		[TearDown]

		public void CleanUp()
		{
			WebDriver.Close();
		}
	}
}
