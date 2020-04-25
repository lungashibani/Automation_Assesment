using NUnit.Framework;
using MbUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PageObjectModel
{
    [Test]
    public static class ControlProperties
    {
        public static By signupClick = By.XPath("//a[@class='header-signInCta_register ']");
        public static By username = By.XPath("UserName");
        public static By email = By.Name("Email");
        public static By password = By.Id("Password");
        public static By confirmPassword = By.Name("ConfirmPassword");
        public static By nextClick = By("//button[@class='modal-button_next']");
        public static By previousClick = By("//button[@class='modal-button_previous']");
        public static By firstName = By.Name("FirstName");
        public static By lastName = By.Name("LastName");

        public static By dayOfBirthDropdown = By.XPath("//select[@name='DateOfBirth_Day']");

        public static By monthOfBirthDropdown = By.XPath("//select[@name='DateOfBirth_Month']");

        public static By yearOfBirthDropdown = By.XPath("//select[@name='DateOfBirth_Year']");

        public static By genderDropdown = By.Id("Gender");
        //public static By genderDropdown = By.Id("Gender");
        public static By currencyDropdown = By.Id("Currency");
        public static By countryNameDropdown = By.Id("Country");
        public static By postCode = By.Id("ZipCode");
        public static By addressLine1 = By.XPath("//input[@name='Address1']");
        public static By addressLine2 = By.XPath("//input[@name='Address2']");
        public static By city = By.XPath("//input[@name='City']");
        public static By stateDropdown = By.XPath("//select[@class='modalInput-input_small modalInput-region
        valid']");
        public static By mobile = By.Id("MobileTelephoneNumber");
        public static By dailyDepLimitDropdown = By.XPath("//select[@id='dailyDepLimit]");
        public static By weeklyDepLimitDropdown = By.XPath("//select[@id='weeklyDepLimit']");
        public static By monthlyDepLimitDropdown = By.XPath("id=monthlyDepLimit");
        public static By iAcceptTerms = By.XPath("//label[@id='TermsAndConditionsAccepted_Label']");
        public static By iAgreeToReceiveTerms = By.XPath("//input[@id='OptInSOB']");
        public static By offersTickBoxes = By.XPath("//*[@class='check']");

        public static By registerButton = By.XPath("//button[@id='register-submit-button']");
    }

    public class PageObjectModelMethods
    {
        IWebDriver webDriver;
        public PageObjectModelMethods(IWebDriver driver);
        {
            this.webDriver = driver;
        }

        public void SignUpClick()
        {
            webDriver.FindElement(ControlProperties.signupClick).Click();
            WaitTime();
        }

        public void EnterUserName(string userName)
        {
            webDriver.FindElement(ControlProperties.username).Clear();
            webDriver.FindElement(ControlProperties.username).SendKeys(userName);
            WaitTime();
        }

        public void EnterEmail(string userEmail)
        {
            webDriver.FindElement(ControlProperties.email).Clear();
            webDriver.FindElement(ControlProperties.email).SendKeys(userEmail);
            WaitTime();
        }

        public void EnterPassword(string userPassword)
        {
            webDriver.FindElement(ControlProperties.password).Clear();
            webDriver.FindElement(ControlProperties.password).SendKeys(userPassword);
            WaitTime();
        }

        public void EnterConfirmPassword(string userConfirmPassword)
        {
            webDriver.FindElement(ControlProperties.confirmPassword).Clear();
            webDriver.FindElement(ControlProperties.confirmPassword).SendKeys(userConfirmPassword);
            WaitTime();
        }

        public void NextButtonClick()
        {
            webDriver.FindElement(ControlProperties.nextClick).Click();
            WaitTime();
        }

        public void PreviousButtonClick()
        {
            webDriver.FindElement(ControlProperties.previousClick).Click();
            WaitTime();
        }

        public void FirstName(string userFirstName)
        {
            webDriver.FindElement(ControlProperties.firstName).Clear();
            webDriver.FindElement(ControlProperties.firstName).SendKeys(userFirstName);
            WaitTime();
        }

        public void LastName(string userLastName)
        {
            webDriver.FindElement(ControlProperties.lastName).Clear();
            webDriver.FindElement(ControlProperties.lastName).SendKeys(userLastName);
            WaitTime();
        }

        public void UserDayOfBirthDropdown(string dayOfBirth)
        {
            IWebElement day = webDriver.FindElement(ControlProperties.dayOfBirthDropdown);
            countryDrop.Click();
            SelectElement select = new SelectElement(day);
            select.SelectByValue(dayOfBirth);
            WaitTime();
        }

        public void UserMonthOfBirthDropdown(string monthOfBirth)
        {
            IWebElement month = webDriver.FindElement(ControlProperties.monthOfBirthDropdown);
            countryDrop.Click();
            SelectElement select = new SelectElement(month);
            select.SelectByValue(monthOfBirth);
            WaitTime();
        }

        public void UserYearOfBirthDropdown(string yearOfBirth)
        {
            IWebElement year = webDriver.FindElement(ControlProperties.yearOfBirthDropdown);
            countryDrop.Click();
            SelectElement select = new SelectElement(year);
            select.SelectByValue(yearOfBirth);
            WaitTime();
        }

        public void GenderTypeDropdown(string userGender)
        {
            IWebElement gender = webDriver.FindElement(ControlProperties.genderDropdown);
            countryDrop.Click();
            SelectElement select = new SelectElement(gender);
            select.SelectByValue(userGender);
            WaitTime();
        }

        public void UserCurrencyDropdown(string userCurrency)
        {
            IWebElement currency = webDriver.FindElement(ControlProperties.currencyDropdown);
            countryDrop.Click();
            SelectElement select = new SelectElement(currency);
            select.SelectByValue(userCurrency);
            WaitTime();
        }

        public void CountryNameDopDown(string countryName)
        {
            IWebElement country = webDriver.FindElement(ControlProperties.countryNameDropdown);
            countryDrop.Click();
            SelectElement select = new SelectElement(country);
            select.SelectByValue(countryName);
            WaitTime();
        }

        public void PostCode(string userPostCode)
        {
            webDriver.FindElement(ControlProperties.postCode).Clear();
            webDriver.FindElement(ControlProperties.postCode).SendKeys(userPostCode);
            WaitTime();
        }

        public void UserAddressLine1(string userAddressLine1)
        {
            webDriver.FindElement(ControlProperties.addressLine1).Clear();
            webDriver.FindElement(ControlProperties.addressLine1).SendKeys(userAddressLine1);
            WaitTime();
        }

        public void UserAddressLine2(string userAddressLine2)
        {
            webDriver.FindElement(ControlProperties.addressLine2).Clear();
            webDriver.FindElement(ControlProperties.addressLine2).SendKeys(userAddressLine2);
            WaitTime();
        }

        public void CityNameDropdown(string cityName)
        {
            webDriver.FindElement(ControlProperties.city).Clear();
            webDriver.FindElement(ControlProperties.city).SendKeys(cityName);
            WaitTime();
        }

        public void StateDropdown(string stateName)
        {
            IWebElement state = webDriver.FindElement(ControlProperties.stateDropdown);
            countryDrop.Click();
            SelectElement select = new SelectElement(state);
            select.SelectByValue(stateName);
            WaitTime();
        }

        public void MobileNumber(string mobileNumber)
        {
            webDriver.FindElement(ControlProperties.mobile).Clear();
            webDriver.FindElement(ControlProperties.mobile).SendKeys(mobileNumber);
            WaitTime();
        }

        public void UserDailyDepLimitDropdown(string dailyDepLimit)
        {
            IWebElement daily = webDriver.FindElement(ControlProperties.dailyDepLimitDropdown);
            countryDrop.Click();
            SelectElement select = new SelectElement(daily);
            select.SelectByValue(dailyDepLimit);
            WaitTime();
        }

        public void UserWeeklyDepLimitDropdown(string weeklyDepLimit)
        {
            IWebElement weekly = webDriver.FindElement(ControlProperties.weeklyDepLimit);
            countryDrop.Click();
            SelectElement select = new SelectElement(weekly);
            select.SelectByValue(weeklyDepLimit);
            WaitTime();
        }

        public void UserMonthlylyDepLimitDropdown(string monthlylyDepLimit)
        {
            IWebElement monthly = webDriver.FindElement(ControlProperties.monthlyDepLimit);
            countryDrop.Click();
            SelectElement select = new SelectElement(monthly);
            select.SelectByValue(monthlylyDepLimit);
            WaitTime();
        }

        public void IAcceptTermsTick()
        {
            webDriver.FindElement(ControlProperties.iAcceptTerms).Click();
            WaitTime();
        }

        public void IAgreeToReceiveTermsTick()
        {
            webDriver.FindElement(ControlProperties.iAgreeToReceiveTerms).Click();
            WaitTime();
        }

        public void OffersTickBoxes()
        {
            webDriver.FindElement(ControlProperties.offersTickBoxes).Click();
            WaitTime();
        }

        public void RegisterButton()
        {
            webDriver.FindElement(ControlProperties.registerButton).Click();
            WaitTime();
        }

        public void WaitTime()
        {
            WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
    }
    [TestClass] 
    public class DriverInitialization 
    { 
        IWebDriver Webdriver; 
        public DriverInitialization() 
        { 
            ChromeOptions chromeOptions = new ChromeOptions(); 
            chromeOptions.AddArgument("disable-infobars"); 
            Webdriver = new ChromeDriver(@"D:\chromedriver_win32", chromeOptions); 
            Webdriver.Navigate().GoToUrl("https://www.hippodromeonline.com/"); 
            Webdriver.Manage().Window.Maximize(); 
            WebDriverWait webDriverWait = new WebDriverWait(Webdriver, TimeSpan.FromSeconds(40));   
        } 
        [TestMethod] 
        public void UserRegistration() 
        { 
            // Four User Login Data. 
            PageObjectModelMethods register = new PageObjectModelMethods(Webdriver); 
            register.SignUpClick(); 
            register.EnterUserName("Bill54");
            register.EnterEmail("lunga65@gmail.com"); 
            register.EnterPassword("Bill1234");
            register.EnterConfirmPassword("Bill1234");
            register.NextButtonClick();
            register.PreviousButtonClick();
            register.FirstName("Bill"); 
            register.LastName("Grant"); 
            register.UserDayOfBirthDropdown("30");  
            register.UserMonthOfBirthDropdown("11");  
            register.UserYearOfBirthDropdown("1995");  
            register.GenderTypeDropdown("Male"); 
            register.UserCurrencyDropdown("US Dollar");
            register.NextButtonClick();
            register.CountryNameDopDown("South Africa");
            register.PostCode("7043"); 
            register.UserAddressLine1("3125 Jim Street"); 
            register.UserAddressLine1("Avon Place"); 
            register.CityNameDropdown("Cape Town"); 
            register.StateDropdown("Western Cape"); 
            register.MobileNumber("123456");
            register.UserDailyDepLimitDropdown("20");
            register.UserWeeklyDepLimitDropdown("100");
            register.UserMonthlylyDepLimitDropdown("450");
            register.IAcceptTermsTick(); 
            register.IAgreeToReceiveTermsTick(); 
            register.OffersTickBoxes(); 
            register.RegisterButton(); 
        } 
    }
}

