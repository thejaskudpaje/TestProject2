using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Object_Repository
{
    public class ActiTimeLogin
    {
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement userNameTxtBx;

        [FindsBy(How = How.Name, Using = "pwd")]
        public IWebElement passwordTxtBx;

        [FindsBy(How = How.Id, Using = "loginButton")]
        public IWebElement submitBtn;

        public ActiTimeLogin(IWebDriver driver)
        {
          
        }
    }
}
