using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FirstTestFramework
{
    public class NotebookPage
    {
        [FindsBy(How = How.XPath, Using = ".//*/header/h1")]
        private IWebElement notebookName;
        public string NotebookName
        { 
            get { return notebookName.Text; }
            
        }
    }
}