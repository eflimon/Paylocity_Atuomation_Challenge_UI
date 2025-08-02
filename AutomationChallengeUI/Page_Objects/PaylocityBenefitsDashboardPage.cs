using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationChallengeUI.Page_Objects
{
    public class PaylocityBenefitsDashboardPage
    {
        private readonly IWebDriver driver;

        //Constructor
        public PaylocityBenefitsDashboardPage(IWebDriver driver) 
        { 
            this.driver = driver;
        }

        //Locators
        IWebElement TitlePaylocityBenefitsDashboard => driver.FindElement(By.ClassName("navbar-brand"));
        IWebElement EmployeesTable => driver.FindElement(By.Id("employeesTable"));
        IWebElement LogoutBtn => driver.FindElement(By.LinkText("Log Out"));
        IWebElement AddEmployeeBtn => driver.FindElement(By.Id("add"));
        IWebElement UpdateEmployeeBtn => driver.FindElement(By.XPath("/html/body/div/main/div[1]/table/tbody/tr[1]/td[9]/i[1]"));
        IWebElement DeleteEmployeeBtn => driver.FindElement(By.XPath("/html/body/div/main/div[1]/table/tbody/tr[1]/td[9]/i[2]"));

        public void ClickAddEmployee()
        {
            AddEmployeeBtn.Click();
        }

        public void ClickUpdateEmployee()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            UpdateEmployeeBtn.Click();
        }

        public void ClickDeleteEmployee()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            DeleteEmployeeBtn.Click();
        }

        public int RowsCount()
        {
            var tableRows = EmployeesTable.FindElements(By.TagName("tr"));
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return tableRows.Count();

        }
    }
}
