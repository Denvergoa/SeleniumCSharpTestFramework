using System;
using FirstTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void Can_Go_To_Tablet_Page()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectNotebookType("Планшеты");
            Assert.IsTrue(Pages.HomePage.IsAtTabletPage("Планшеты"));
        }

        [TestMethod]
        public void Can_Select_Budget_Tablet()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectNotebookType("Планшеты");
            Pages.HomePage.SelectTabletType("Бюджетные");
            Pages.HomePage.SelectSpecificTablet();

        }

       [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }

    }
}
