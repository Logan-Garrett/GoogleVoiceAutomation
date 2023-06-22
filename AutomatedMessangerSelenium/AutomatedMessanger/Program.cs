using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

Console.WriteLine("Hello, World!");

var service = @"E:\git\localhost-data";

var options = new ChromeOptions();
options.AddArguments("--no-sandbox");
options.AddArguments("--disable-dev-shm-usage");
options.AddArguments("--remote-debugging-port=9222");
options.DebuggerAddress = "127.0.0.1:9222";

//options.AddArgument("headless");
//chrome.exe --remote-debugging-port=9222 --user-data-dir="E:\git\localhost-data"
IWebDriver driver = new ChromeDriver(service, options);
driver.Navigate().GoToUrl("https://voice.google.com/u/3/messages");
Thread.Sleep(2000);

driver.FindElement(By.XPath("//*[@class='signUpLink']")).Click();
Thread.Sleep(2000);

driver.FindElement(By.XPath("//*[@aria-label='Email or phone']")).SendKeys("gaggiftaffiliates@gmail.com");
driver.FindElement(By.XPath("//*[@class='VfPpkd-RLmnJb']")).Click();
var ContactList = new List<string>();
/*
ContactList = (List<string>)driver.FindElement(By.XPath("//div[@class='md-ink-ripple layout-align-start-center layout-row gmat-body-2 gvThreadItem-root']"));
for (int i = 0; i < ContactList.Count; i++)
{
    Console.WriteLine(ContactList[i]);
}
*/
Console.ReadLine();