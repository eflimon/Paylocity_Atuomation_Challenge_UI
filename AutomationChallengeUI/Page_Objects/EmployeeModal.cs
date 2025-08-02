using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationChallengeUI.Page_Objects
{
    public class EmployeeModal
    {
        private readonly IWebDriver driver;

        //Constructor
        public EmployeeModal(IWebDriver driver) 
        { 
            this.driver = driver;
        }

        IWebElement AddEmployeeTitle => driver.FindElement(By.ClassName("modal-title"));
        IWebElement FirstNameTextbox => driver.FindElement(By.Id("firstName"));
        IWebElement LastNameTextbox => driver.FindElement(By.Id("lastName"));
        IWebElement DependantsTextbox => driver.FindElement(By.Id("dependants"));
        IWebElement UpdateEmployeeBtn => driver.FindElement(By.Id("updateEmployee"));
        IWebElement CancelBtn => driver.FindElement(By.ClassName("btn-secondary"));
        IWebElement AddEmployeeBtn => driver.FindElement(By.Id("addEmployee"));
        IWebElement DeleteBtn => driver.FindElement(By.Id("deleteEmployee"));
        IWebElement UpdateBtn => driver.FindElement(By.Id("updateEmployee"));

        public void AddEmployee(string firstName, string lastName, int dependants)
        {
            FirstNameTextbox.SendKeys(firstName);
            LastNameTextbox.SendKeys(lastName);
            DependantsTextbox.SendKeys(dependants.ToString());
            AddEmployeeBtn.Click();

        }

        public void ClickDeleteBtn()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            DeleteBtn.Click();

        }

        public void UpdateEmployee(string firstName, string lastName, int dependants)
        {
            FirstNameTextbox.SendKeys(firstName);
            LastNameTextbox.SendKeys(lastName);
            DependantsTextbox.SendKeys(dependants.ToString());
            UpdateBtn.Click();
        }

    }
}
