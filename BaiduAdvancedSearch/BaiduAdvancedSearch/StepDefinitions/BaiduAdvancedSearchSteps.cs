using BoDi;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class BaiduAdvancedSearchSteps
    {
        private static IWebDriver driver;

        [BeforeFeature]
        public static async Task BeforeFeature(IObjectContainer container)
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            driver = new ChromeDriver(options);
        }

        [Given(@"打开百度首页")]
        public void Given打开百度首页()
        {
            driver.Navigate().GoToUrl("https://www.baidu.com");
        }

        [When(@"鼠标悬停在“设置”按钮")]
        public void When鼠标悬停在设置按钮()
        {
            var element = driver.FindElement(By.Id("s-usersetting-top"));
            var text = element.Text;
            Console.WriteLine(text);
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }

        [When(@"点击设置菜单上的“高级搜索“按钮")]
        public void When点击设置菜单上的高级搜索按钮()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[contains(text(), '高级搜索')]"));
            element.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement popupElement = wait.Until(c=>c.FindElement(By.CssSelector(".bdlayer.s-isindex-wrap.new-pmd.pfpanel")));
        }

        [Then(@"弹出高级搜索页面")]
        public void Then弹出高级搜索页面()
        {

        }

        [Given(@"输入关键词""([^""]*)""")]
        public void Given输入关键词(string p0)
        {
            IWebElement element = driver.FindElement(By.Id("adv_keyword"));
            element.SendKeys("人生若只如初见");
        }

        [When(@"点击高级搜索页面上的“高级搜索""按钮")]
        public void When点击高级搜索页面上的高级搜索按钮()
        {
            IWebElement element = driver.FindElement(By.CssSelector("input.advanced-search-btn.c-btn.c-btn-primary.switch-button"));
            element.Click();
            Thread.Sleep(2000);
        }

        [Then(@"搜索框显示关键词""([^""]*)""")]
        public void Then搜索框显示关键词(string p0)
        {
            //throw new PendingStepException();
        }

        [AfterFeature]
        public static void TearDown()
        {
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
