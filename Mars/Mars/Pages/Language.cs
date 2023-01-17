using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Mars.Pages
{
    public class Language
    {
        
        public void AddLanguage(IWebDriver driver)
        {
            Thread.Sleep(1000);
            //click on Languages
            IWebElement languagesTab = driver.FindElement(By.XPath("//h3[text()='Languages']"));
            languagesTab.Click();
            //click Add New
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();
            //get textbox for langaues and add value
            IWebElement addlangauesTextbox = driver.FindElement(By.Name("name"));
            addlangauesTextbox.SendKeys("english");
            //choose Language level from dropbox
            IWebElement chooselanguageDropbox = driver.FindElement(By.XPath("//select[@name='level']"));
            chooselanguageDropbox.Click();
            IWebElement basicOption = driver.FindElement(By.XPath("//select[@name='level']/option[text()='Basic']"));
            basicOption.Click();
            Thread.Sleep(500);
            //click add
            IWebElement addlanguageButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Add']"));
            addlanguageButton.Click();
        }
    }
}
