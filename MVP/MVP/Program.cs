
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//open browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//goto Url("http://localhost:5000")
driver.Navigate().GoToUrl("http://localhost:5000");
//click sign in button
IWebElement signinButton = driver.FindElement(By.XPath("//a[text()='Sign In']"));
signinButton.Click();
//Enter username and password
IWebElement usernameTextbox = driver.FindElement(By.Name("email"));
usernameTextbox.SendKeys("truptisharma105@gmail.com");
IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
passwordTextbox.SendKeys("Trisha@105");
// click on login button
IWebElement loginButton = driver.FindElement(By.XPath("//button[text()='Login']"));
loginButton.Click();
Thread.Sleep(1000);
//Check its right login
IWebElement nameCheck = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
if (nameCheck.Text == "Hi Trupti")
{
    Console.WriteLine("Test successful");
}
else
{
    Console.WriteLine("Test failed");
}
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
IWebElement addButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Add']"));
addButton.Click();
//click on skills
//click on Add New
//add value in add skill textbox
//select skill level from dropbox
//click add