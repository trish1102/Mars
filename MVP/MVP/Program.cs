
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