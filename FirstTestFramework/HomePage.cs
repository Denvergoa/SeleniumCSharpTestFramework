using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FirstTestFramework
{
    public class HomePage
    {
        static string Url = "http://rozetka.com.ua";

        private static string PageTitle =
            "Интернет-магазин ROZETKA™: фототехника, видеотехника, аудиотехника, компьютеры и компьютерные комплектующие";

        [FindsBy(How = How.LinkText, Using = "Ноутбуки, планшеты и компьютеры")]
        private IWebElement notebookLink;

        [FindsBy(How = How.LinkText, Using = "Бюджетные")]
        private IWebElement tabletLink;

        [FindsBy(How = How.XPath, Using = ".//*[@id='sort_producer']")]
        private IList<IWebElement> producerName;

        [FindsBy(How = How.Id, Using = "price[max]")]
        private IWebElement maxPriceField;


        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectNotebookType(string notebookName)
        {
            notebookLink.Click();
            var notebookType = Browser.Driver.FindElement(By.LinkText("Планшеты"));
            notebookType.Click();
        }

        public bool IsAtTabletPage(string notebookName)
        {
            var notebookPage = new NotebookPage();
            PageFactory.InitElements(Browser.Driver, notebookPage);
            return notebookPage.NotebookName == notebookName;
        }

        public void SelectTabletType(string tabletName)
        {
            tabletLink.Click();
        }

        public void SelectSpecificTablet()
        {
            maxPriceField.SendKeys("4000");
            producerName[3].Click();
            
        }
    }
}