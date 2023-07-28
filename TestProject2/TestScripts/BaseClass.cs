using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Object_Repository;

namespace TestProject2.TestScripts
{
    [TestClass]
    public class BaseClass
    {
        IWebDriver driver;
        [TestMethod]
        public void Login_Test()
        {
            driver = new ChromeDriver();
            ActiTimeLogin loginPage = new ActiTimeLogin(driver);
            
        }

    }
}
