using BoDi;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class BaiduAdvancedSearchSteps
    {
        private IWebDriver driver;

        [BeforeFeature]
        public static async Task BeforeFeature(IObjectContainer container)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            IWebDriver driver = new ChromeDriver(options);
        }

        [Given(@"打开百度首页")]
        public void Given打开百度首页()
        {
            driver.Navigate().GoToUrl("https://www.baidu.com");
        }

        [When(@"鼠标悬停在“设置”按钮")]
        public void When鼠标悬停在设置按钮()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@name='tj_settingicon' and @class='pf']"));
            element.Click();
        }

        [When(@"点击设置菜单上的“高级搜索“按钮")]
        public void When点击设置菜单上的高级搜索按钮()
        {
            throw new PendingStepException();
        }

        [Then(@"弹出高级搜索页面")]
        public void Then弹出高级搜索页面()
        {
            throw new PendingStepException();
        }

        [Given(@"输入关键词""([^""]*)""")]
        public void Given输入关键词(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"点击高级搜索页面上的“高级搜索""按钮")]
        public void When点击高级搜索页面上的高级搜索按钮()
        {
            throw new PendingStepException();
        }

        [Then(@"搜索框显示关键词""([^""]*)""")]
        public void Then搜索框显示关键词(string p0)
        {
            throw new PendingStepException();
        }
    }
}
