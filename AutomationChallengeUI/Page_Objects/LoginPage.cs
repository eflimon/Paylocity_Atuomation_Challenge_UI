using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationChallengeUI.Page_Objects;

namespace AutomationChallengeUI.Page_Objects
{
    public class LoginPage
    {
        
        private readonly IWebDriver driver;
        PaylocityBenefitsDashboardPage pay;

        //Constructor
        public LoginPage(IWebDriver driver) 
        {
            this.driver = driver;
        }


        //Locators
        IWebElement Username => driver.FindElement(By.Id("Username"));
        IWebElement Password => driver.FindElement(By.Id("Password"));
        IWebElement LoginBtn => driver.FindElement(By.ClassName("btn-primary"));
        IWebElement EmployeesTable => driver.FindElement(By.Id("employeesTable"));
        IWebElement ErrorMessage => driver.FindElement(By.XPath("//body/div/main/div/div/form/div[@class='text-danger validation-summary-errors']/ul/li"));

        public void ClickLogin()
        {
            LoginBtn.Click();
        }

        public void Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            LoginBtn.Click();
        }

        public bool LoginSucceessfull()
        {
            
            return EmployeesTable.Displayed;
        }

        public string GetErrorMessage()
        {
            string errorMessage;
            errorMessage = ErrorMessage.Text;
            return errorMessage;
        }
    }
}
