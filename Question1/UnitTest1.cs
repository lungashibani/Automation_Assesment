using NUnit.Framework;

namespace Question1
{
    public class Teusing NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace WebDriver_CSharp_Example
{


    [TestFixture]
    public class Chrome_Sample_test
    {
        private IWebDriver driver;
        public string newsURL;


        [Test(Description="Check the Google's news page for Headlines")]
        public void Login_is_on_home_page() 
        {
            newsURL = "https://news.google.com/";
            driver.Navigate().GoToUrl(newsURL);
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));

            IWebElement element = driver.FindElement(By.XPath("//h3[@class='ipQwMb ekueJc gEATFF RD0gLb']")) ;
            
            if(element == "")
            {
                System.out.println(“WebDriver couldn’t locate the element”);
            }
            else
            {
                Assert.AreEqual("Headlines", element.GetAttribute("text"));
            }
        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }


        [SetUp]
        public void SetupTest()
        {
            newsURL = "http://news.google.com/";
            driver = new ChromeDriver();

        }
    }
}