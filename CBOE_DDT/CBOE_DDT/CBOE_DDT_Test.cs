using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using excel = Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.CSharp.RuntimeBinder;

namespace CBOE_DDT
{
    [TestClass]
    public class CBOE_DDT_Test
    {
        [TestMethod]
        public void CBOE_DDT()
        {
            excel.Application x1app = new excel.Application();
            excel.Workbook x1workbook = x1app.Workbooks.Open(@"C:\Users\Evolve Computing\Desktop\demo.xlsx");
            excel._Worksheet x1worksheet = x1workbook.Sheets[1];
            excel.Range x1range = x1worksheet.UsedRange;

            string website;
            for (int i=1;i<=3;i++)
            {
                website = x1range.Cells[i][1].value2;

                IWebDriver wd = new ChromeDriver();
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
                wd.Navigate().GoToUrl(website);
                wd.Quit();


            }



        }
    }
}
