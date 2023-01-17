
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Mars.Pages;

IWebDriver driver = new ChromeDriver();
//signin page objection intialition
SigninPage signinPageObj = new SigninPage();
//signinPageObj.SigninActions(driver);
//Language page objection intialition
Language languageObj = new Language();
languageObj.AddLanguage(driver);
//Skill page objection intialition
Skill skillObj= new Skill();
skillObj.Addskill(driver);


