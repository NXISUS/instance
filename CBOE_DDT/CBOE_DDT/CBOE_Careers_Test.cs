using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Windows.Forms;

namespace CBOE_DDT
{

    //[TestFixture()]

    public class CBOE_Careers
    {
       

        //[SetUp()]
        [Test()]
        public void CBOE_Careers_Test()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver wd = new ChromeDriver(options);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            var urlCBOE = @"https://www.cboe.com/";
            wd.Navigate().GoToUrl(urlCBOE);
            //wd.Manage().Cookies.DeleteAllCookies();
            //wd.Manage().Window.Maximize();


            try
            {
                NavigateCBOE(wd);
                JobSearch(wd);

                //wd.FindElement(By.CssSelector("# view_container > form > div.mbekbe.bxPAYd > div > div > div > ul > li:nth-child(1) > div > div.vdE7Oc.f3GIQ > p.uRhzae")).Click();
                //wd.SwitchTo().ActiveElement();
                //sendResume.SendKeys(filePath);

                //Actions action = new Actions(wd);
                //action.MoveToElement(wd.FindElement(By.Id("resumeDropLocalFile")));
                //action.Click();
                //action.Build().Perform();
                //SendKeys.SendWait(filePath);
                //SendKeys.SendWait(@"{Enter}");
                //action.SendKeys(@"C:\Users\Evolve Computing\Desktop\New Job\Short\Resume Valeriy Cherkashin.docx");

                //var enterValue = wd.FindElement(By.XPath("//*[@id=\"resumeDropLocalFile\"]"));
                //Actions actions = new Actions(wd);
                //actions.SendKeys(Keys.Backspace);
                //actions.SendKeys(enterValue, c).Build().Perform();

                //String script = "document.getElementByXPath('//*[@id=\"resumeDropLocalFile\"]').value='" + @"C:\Users\Evolve Computing\Desktop\New Job\Short\Resume Valeriy Cherkashin.docx" + "';";
                //((IJavaScriptExecutor)wd).ExecuteScript(script);

                PersonalInformation(wd, "FirstName", "LastName", "test@test.com");
                AddAttachments(wd);
                CurrentAddress(wd, "111 testStreet", "testCity", "12345");
                ContactInformation(wd, "1234567890", "0987654321");
                GeneralInformation(wd, "111111", "10", "No comments");
                ResidentialHistory(wd, "11/2015", "12/2015", "TestStreet", "1", "TestCity2", "12345");
                RecentEmployer(wd, "TestNameCompany", "TestSity,IL", "TestPosition", "2016-11-08", "2017-09-13", "I would like to grow like a professional", "Open", "TestPerson", "1234567890", "Planning, development and deployment of test procedures (manual and automated), analyzing and reporting results, as well as coordinating joint efforts throughout SDLC");
                SecondEmployer(wd, "TestNameCompany2", "TestSity2,IL", "TestPosition2", "2012-11-08", "2016-09-13", "Text", "123456", "TestPerson2", "1234567890", "Some text");
                EducationUniversity(wd, "University", "TestSity3, IL", "CS", "Bachelor’s degree");
                GraduateSchool(wd, "Some High School", "TestSity4, IL", "High School", "High School Diploma");
                SecuritiesIndustryLicenses(wd, "1234 567", "12345", "NO");
                AdditionalInformation(wd);
                //AdditionalInformation2(wd, clientId);
                //InternAdditionalInformation2(wd, clientId);
                BusinessReferences(wd, "Reference", "Company Reference", "Manager", "4352111111", "test@test.com", "Any time");
                BusinessReferences2(wd, "Reference2", "Company Reference2", "Manager2", "4352111444", "test2@test.com", "Any time2");
                BusinessReferences3(wd, "Reference3", "Company Reference3", "Manager3", "4352111333", "test3@test.com", "Any time3");
                ApplicantStatement(wd, "Signature", "Some comments");
            }


            catch (Exception e)
            {
                var screenshot = wd.TakeScreenshot();
                //The path for screenshots will be - "C:\\CBOE_Careers_Test\Screnshots\" in the you PC
                var filePath = @"C:\\CBOE_Careers_Test\Screnshots\";
                bool exists = System.IO.Directory.Exists(filePath);
                if (!exists)
                    System.IO.Directory.CreateDirectory(filePath);
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
                screenshot.SaveAsFile(filePath + "-CBOE_Careers_Test-" + timestamp + ".png", ScreenshotImageFormat.Png);
                Console.WriteLine(e.Message + "Fail the test CBOE_Careers_Test");
            }
            finally
            {
                wd.Quit();

            }
        }

        private static void ApplicantStatement(IWebDriver wd, string applicantSignature, string comments)
        {
            wd.FindElement(By.XPath("//*[@id=\"gnewotn_input_200\"]")).Click();
            wd.FindElement(By.Id("gnewotn_input_201")).Click();
            wd.FindElement(By.Id("gnewotn_input_201")).Clear();
            wd.FindElement(By.Id("gnewotn_input_201")).SendKeys(applicantSignature);
            IWebElement txtBxDatePicker = wd.FindElement(By.Id("gnewotn_input_202"));
            txtBxDatePicker.SendKeys("09/22/2017");
            wd.FindElement(By.Id("originalComments")).Click();
            wd.FindElement(By.Id("originalComments")).Clear();
            wd.FindElement(By.Id("originalComments")).SendKeys(comments);
            //wd.FindElement(By.Id("gnewotn_input_204")).Click();          
        }
        private static void BusinessReferences3(IWebDriver wd, string nameReference3, string companyReference3, string Relationship3, string phoneReference3, string eMailReference3, string bestTime3)
        {
            wd.FindElement(By.Id("gnewotn_input_194")).Click();
            wd.FindElement(By.Id("gnewotn_input_194")).Clear();
            wd.FindElement(By.Id("gnewotn_input_194")).SendKeys(nameReference3);
            wd.FindElement(By.Id("gnewotn_input_195")).Click();
            wd.FindElement(By.Id("gnewotn_input_195")).Clear();
            wd.FindElement(By.Id("gnewotn_input_195")).SendKeys(companyReference3);
            wd.FindElement(By.Id("gnewotn_input_196")).Click();
            wd.FindElement(By.Id("gnewotn_input_196")).Clear();
            wd.FindElement(By.Id("gnewotn_input_196")).SendKeys(Relationship3);
            wd.FindElement(By.Id("gnewotn_input_197")).Click();
            wd.FindElement(By.Id("gnewotn_input_197")).Clear();
            wd.FindElement(By.Id("gnewotn_input_197")).SendKeys(phoneReference3);
            wd.FindElement(By.Id("gnewotn_input_198")).Click();
            wd.FindElement(By.Id("gnewotn_input_198")).Clear();
            wd.FindElement(By.Id("gnewotn_input_198")).SendKeys(eMailReference3);
            wd.FindElement(By.Id("gnewotn_input_199")).Click();
            wd.FindElement(By.Id("gnewotn_input_199")).Clear();
            wd.FindElement(By.Id("gnewotn_input_199")).SendKeys(bestTime3);
        }
        private static void BusinessReferences2(IWebDriver wd, string nameReference2, string companyReference2, string Relationship2, string phoneReference2, string eMailReference2, string bestTime2)
        {
            wd.FindElement(By.Id("gnewotn_input_188")).Click();
            wd.FindElement(By.Id("gnewotn_input_188")).Clear();
            wd.FindElement(By.Id("gnewotn_input_188")).SendKeys(nameReference2);
            wd.FindElement(By.Id("gnewotn_input_189")).Click();
            wd.FindElement(By.Id("gnewotn_input_189")).Clear();
            wd.FindElement(By.Id("gnewotn_input_189")).SendKeys(companyReference2);
            wd.FindElement(By.Id("gnewotn_input_190")).Click();
            wd.FindElement(By.Id("gnewotn_input_190")).Clear();
            wd.FindElement(By.Id("gnewotn_input_190")).SendKeys(Relationship2);
            wd.FindElement(By.Id("gnewotn_input_191")).Click();
            wd.FindElement(By.Id("gnewotn_input_191")).Clear();
            wd.FindElement(By.Id("gnewotn_input_191")).SendKeys(phoneReference2);
            wd.FindElement(By.Id("gnewotn_input_192")).Click();
            wd.FindElement(By.Id("gnewotn_input_192")).Clear();
            wd.FindElement(By.Id("gnewotn_input_192")).SendKeys(eMailReference2);
            wd.FindElement(By.Id("gnewotn_input_193")).Click();
            wd.FindElement(By.Id("gnewotn_input_193")).Clear();
            wd.FindElement(By.Id("gnewotn_input_193")).SendKeys(bestTime2);
        }

        private static void BusinessReferences(IWebDriver wd, string nameReference, string companyReference, string Relationship, string phoneReference, string eMailReference, string bestTime)
        {
            wd.FindElement(By.Id("gnewotn_input_130")).Click();
            wd.FindElement(By.Id("gnewotn_input_130")).Clear();
            wd.FindElement(By.Id("gnewotn_input_130")).SendKeys(nameReference);
            wd.FindElement(By.Id("gnewotn_input_183")).Click();
            wd.FindElement(By.Id("gnewotn_input_183")).Clear();
            wd.FindElement(By.Id("gnewotn_input_183")).SendKeys(companyReference);
            wd.FindElement(By.Id("gnewotn_input_184")).Click();
            wd.FindElement(By.Id("gnewotn_input_184")).Clear();
            wd.FindElement(By.Id("gnewotn_input_184")).SendKeys(Relationship);
            wd.FindElement(By.Id("gnewotn_input_185")).Click();
            wd.FindElement(By.Id("gnewotn_input_185")).Clear();
            wd.FindElement(By.Id("gnewotn_input_185")).SendKeys(phoneReference);
            wd.FindElement(By.Id("gnewotn_input_186")).Click();
            wd.FindElement(By.Id("gnewotn_input_186")).Clear();
            wd.FindElement(By.Id("gnewotn_input_186")).SendKeys(eMailReference);
            wd.FindElement(By.Id("gnewotn_input_187")).Click();
            wd.FindElement(By.Id("gnewotn_input_187")).Clear();
            wd.FindElement(By.Id("gnewotn_input_187")).SendKeys(bestTime);
        }


        //public  void InternAdditionalInformation2(IWebDriver wd)
        //{
        //    var clientIds = new int[] { 4, 5, 8, 9, 13, 14, 17 };
        //    foreach (var clientId in clientIds)
        //        AdditionalInformation2(wd, clientId);
        //}

        //private static void AdditionalInformation2(IWebDriver wd, int clientId)
        //{
        //    var entryPoint = string.Format("#gnewtoncrim > dl > dd > div:nth-child({0}) > div.gnewtonQuestionInputClass > label:nth-child(5)", clientId);

        //    wd.FindElement(By.CssSelector(entryPoint)).Click();
        //}


        private static void AdditionalInformation(IWebDriver wd)
        {

            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(4) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(5) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(8) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(9) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(13) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(14) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(17) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(18) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(23) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(24) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(25) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(26) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(27) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(28) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(29) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(30) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(34) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(35) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(36) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(37) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(38) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(41) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(42) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(46) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(47) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(48) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(49) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(50) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(51) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(52) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(55) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(59) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(60) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(65) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(66) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(67) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(68) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(73) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(74) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(75) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(76) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(79) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(80) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(83) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(84) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(87) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(88) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(91) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(92) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(97) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(98) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
            wd.FindElement(By.CssSelector("#gnewtoncrim > dl > dd > div:nth-child(99) > div.gnewtonQuestionInputClass > label:nth-child(5)")).Click();
        }

        private static void SecuritiesIndustryLicenses(IWebDriver wd, string numberNASD_CRD, string securityLicenses, string otherLicensesNASD_CRD)
        {
            wd.FindElement(By.Id("gnewotn_input_127")).Click();
            wd.FindElement(By.Id("gnewotn_input_127")).Clear();
            wd.FindElement(By.Id("gnewotn_input_127")).SendKeys(numberNASD_CRD);
            wd.FindElement(By.Id("gnewotn_input_128")).Click();
            wd.FindElement(By.Id("gnewotn_input_128")).Clear();
            wd.FindElement(By.Id("gnewotn_input_128")).SendKeys(securityLicenses);
            wd.FindElement(By.Id("gnewotn_input_129")).Click();
            wd.FindElement(By.Id("gnewotn_input_129")).Clear();
            wd.FindElement(By.Id("gnewotn_input_129")).SendKeys(otherLicensesNASD_CRD);
        }

        private static void GraduateSchool(IWebDriver wd, string nameSchool, string sitySchool, string nameCourseSchool, string degree)
        {
            wd.FindElement(By.Id("gnewotn_input_117")).Click();
            wd.FindElement(By.Id("gnewotn_input_117")).Clear();
            wd.FindElement(By.Id("gnewotn_input_117")).SendKeys(nameSchool);
            wd.FindElement(By.Id("gnewotn_input_118")).Click();
            wd.FindElement(By.Id("gnewotn_input_118")).Clear();
            wd.FindElement(By.Id("gnewotn_input_118")).SendKeys(sitySchool);
            wd.FindElement(By.Id("gnewotn_input_119")).Click();
            wd.FindElement(By.Id("gnewotn_input_119")).Clear();
            wd.FindElement(By.Id("gnewotn_input_119")).SendKeys(nameCourseSchool);
            SelectElement selectState3 = new SelectElement(wd.FindElement(By.Id("gnewton_section_80_question_120_answer")));
            selectState3.SelectByText("4");
            wd.FindElement(By.Id("gnewotn_input_121")).Click();
            wd.FindElement(By.Id("gnewotn_input_121")).Clear();
            wd.FindElement(By.Id("gnewotn_input_121")).SendKeys(degree);
            wd.FindElement(By.CssSelector("#gnewtonEduHist > dl > dd > div:nth-child(15) > div.gnewtonFieldInputClass > label:nth-child(3)")).Click();
        }

        private static void EducationUniversity(IWebDriver wd, string nameUniversity, string sityUniversity, string nameCourseUniversity, string degree)
        {
            wd.FindElement(By.Id("gnewotn_input_112")).Click();
            wd.FindElement(By.Id("gnewotn_input_112")).Clear();
            wd.FindElement(By.Id("gnewotn_input_112")).SendKeys(nameUniversity);
            wd.FindElement(By.Id("gnewotn_input_113")).Click();
            wd.FindElement(By.Id("gnewotn_input_113")).Clear();
            wd.FindElement(By.Id("gnewotn_input_113")).SendKeys(sityUniversity);
            wd.FindElement(By.Id("gnewotn_input_114")).Click();
            wd.FindElement(By.Id("gnewotn_input_114")).Clear();
            wd.FindElement(By.Id("gnewotn_input_114")).SendKeys(nameCourseUniversity);
            SelectElement selectState3 = new SelectElement(wd.FindElement(By.Id("gnewton_section_80_question_50_answer")));
            selectState3.SelectByText("4");
            wd.FindElement(By.Id("gnewotn_input_116")).Click();
            wd.FindElement(By.Id("gnewotn_input_116")).Clear();
            wd.FindElement(By.Id("gnewotn_input_116")).SendKeys(degree);
            wd.FindElement(By.CssSelector("#gnewtonEduHist > dl > dd > div:nth-child(7) > div.gnewtonFieldInputClass > label:nth-child(3)")).Click();

        }
        private static void SecondEmployer(IWebDriver wd, string name2Company, string sity2, string jobTitle2, string startData2, string endData2, string reason2, string solary2, string supervisor2, string companyPhone2, string responsibilities2)
        {
            wd.FindElement(By.Id("gnewotn_input_79")).Click();
            wd.FindElement(By.Id("gnewotn_input_79")).Clear();
            wd.FindElement(By.Id("gnewotn_input_79")).SendKeys(name2Company);
            wd.FindElement(By.Id("gnewotn_input_80")).Click();
            wd.FindElement(By.Id("gnewotn_input_80")).Clear();
            wd.FindElement(By.Id("gnewotn_input_80")).SendKeys(sity2);
            wd.FindElement(By.Id("gnewotn_input_81")).Click();
            wd.FindElement(By.Id("gnewotn_input_81")).Clear();
            wd.FindElement(By.Id("gnewotn_input_81")).SendKeys(jobTitle2);
            wd.FindElement(By.Id("gnewotn_input_82")).Click();
            wd.FindElement(By.Id("gnewotn_input_82")).Clear();
            wd.FindElement(By.Id("gnewotn_input_82")).SendKeys(startData2);
            wd.FindElement(By.Id("gnewotn_input_83")).Click();
            wd.FindElement(By.Id("gnewotn_input_83")).Clear();
            wd.FindElement(By.Id("gnewotn_input_83")).SendKeys(endData2);
            SelectElement selectReason = new SelectElement(wd.FindElement(By.Id("gnewton_section_70_question_220_answer")));
            selectReason.SelectByText("Promoted");
            wd.FindElement(By.Id("gnewotn_input_85")).Click();
            wd.FindElement(By.Id("gnewotn_input_85")).Clear();
            wd.FindElement(By.Id("gnewotn_input_85")).SendKeys(reason2);
            wd.FindElement(By.Id("gnewotn_input_86")).Click();
            wd.FindElement(By.Id("gnewotn_input_86")).Clear();
            wd.FindElement(By.Id("gnewotn_input_86")).SendKeys(solary2);
            wd.FindElement(By.Id("gnewotn_input_87")).Click();
            wd.FindElement(By.Id("gnewotn_input_87")).Clear();
            wd.FindElement(By.Id("gnewotn_input_87")).SendKeys(supervisor2);
            wd.FindElement(By.Id("gnewotn_input_88")).Click();
            wd.FindElement(By.Id("gnewotn_input_88")).Clear();
            wd.FindElement(By.Id("gnewotn_input_88")).SendKeys(companyPhone2);
            wd.FindElement(By.CssSelector("#gnewtonEmpHist > dl > dd > div:nth-child(28) > div.gnewtonFieldInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.CssSelector("#gnewtonEmpHist > dl > dd > div:nth-child(29) > div.gnewtonQuestionInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.Id("gnewotn_input_89")).Click();
            wd.FindElement(By.Id("gnewotn_input_89")).Clear();
            wd.FindElement(By.Id("gnewotn_input_89")).SendKeys(responsibilities2);
        }

        private static void RecentEmployer(IWebDriver wd, string nameCompany, string sity, string jobTitle, string startData, string endData, string reason, string solary, string supervisor, string companyPhone, string responsibilities)
        {
            wd.FindElement(By.XPath("//*[@id=\"gnewtonEmpHist\"]/dl/dd/div[2]/div[2]/label[1]")).Click();
            wd.FindElement(By.Id("gnewotn_input_65")).Click();
            wd.FindElement(By.Id("gnewotn_input_65")).Clear();
            wd.FindElement(By.Id("gnewotn_input_65")).SendKeys(nameCompany);
            wd.FindElement(By.Id("gnewotn_input_67")).Click();
            wd.FindElement(By.Id("gnewotn_input_67")).Clear();
            wd.FindElement(By.Id("gnewotn_input_67")).SendKeys(sity);
            wd.FindElement(By.Id("gnewotn_input_68")).Click();
            wd.FindElement(By.Id("gnewotn_input_68")).Clear();
            wd.FindElement(By.Id("gnewotn_input_68")).SendKeys(jobTitle);
            wd.FindElement(By.Id("gnewotn_input_69")).Click();
            wd.FindElement(By.Id("gnewotn_input_69")).Clear();
            wd.FindElement(By.Id("gnewotn_input_69")).SendKeys(startData);
            wd.FindElement(By.Id("gnewotn_input_70")).Click();
            wd.FindElement(By.Id("gnewotn_input_70")).Clear();
            wd.FindElement(By.Id("gnewotn_input_70")).SendKeys(endData);
            SelectElement selectReason = new SelectElement(wd.FindElement(By.Id("gnewton_section_70_question_80_answer")));
            selectReason.SelectByText("Currently Employed");
            wd.FindElement(By.Id("gnewotn_input_72")).Click();
            wd.FindElement(By.Id("gnewotn_input_72")).Clear();
            wd.FindElement(By.Id("gnewotn_input_72")).SendKeys(reason);
            wd.FindElement(By.Id("gnewotn_input_73")).Click();
            wd.FindElement(By.Id("gnewotn_input_73")).Clear();
            wd.FindElement(By.Id("gnewotn_input_73")).SendKeys(solary);
            wd.FindElement(By.Id("gnewotn_input_74")).Click();
            wd.FindElement(By.Id("gnewotn_input_74")).Clear();
            wd.FindElement(By.Id("gnewotn_input_74")).SendKeys(supervisor);
            wd.FindElement(By.Id("gnewotn_input_75")).Click();
            wd.FindElement(By.Id("gnewotn_input_75")).Clear();
            wd.FindElement(By.Id("gnewotn_input_75")).SendKeys(companyPhone);
            wd.FindElement(By.CssSelector("#gnewtonEmpHist > dl > dd > div:nth-child(13) > div.gnewtonFieldInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.CssSelector("#gnewtonEmpHist > dl > dd > div:nth-child(14) > div.gnewtonQuestionInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.Id("gnewotn_input_76")).Click();
            wd.FindElement(By.Id("gnewotn_input_76")).Clear();
            wd.FindElement(By.Id("gnewotn_input_76")).SendKeys(responsibilities);
        }

        private static void ResidentialHistory(IWebDriver wd, string startResidential, string finishtResidential, string street, string apt, string testCity1, string postCode)
        {
            wd.FindElement(By.Id("gnewotn_input_25")).Click();
            wd.FindElement(By.Id("gnewotn_input_25")).Clear();
            wd.FindElement(By.Id("gnewotn_input_25")).SendKeys(startResidential);
            wd.FindElement(By.Id("gnewotn_input_26")).Click();
            wd.FindElement(By.Id("gnewotn_input_26")).Clear();
            wd.FindElement(By.Id("gnewotn_input_26")).SendKeys(finishtResidential);
            wd.FindElement(By.Id("gnewotn_input_27")).Click();
            wd.FindElement(By.Id("gnewotn_input_27")).Clear();
            wd.FindElement(By.Id("gnewotn_input_27")).SendKeys(street);
            wd.FindElement(By.Id("gnewotn_input_28")).Click();
            wd.FindElement(By.Id("gnewotn_input_28")).Clear();
            wd.FindElement(By.Id("gnewotn_input_28")).SendKeys(apt);
            wd.FindElement(By.Id("gnewotn_input_29")).Click();
            wd.FindElement(By.Id("gnewotn_input_29")).Clear();
            wd.FindElement(By.Id("gnewotn_input_29")).SendKeys(testCity1);
            SelectElement selectState3 = new SelectElement(wd.FindElement(By.Id("gnewton_section_60_question_70_answer_state")));
            selectState3.SelectByValue("IL");
            wd.FindElement(By.Id("gnewotn_input_31")).Click();
            wd.FindElement(By.Id("gnewotn_input_31")).Clear();
            wd.FindElement(By.Id("gnewotn_input_31")).SendKeys(postCode);
            SelectElement selectCountry3 = new SelectElement(wd.FindElement(By.Id("gnewton_section_60_question_90_answer_country")));
            selectCountry3.SelectByValue("US");
        }

        private static void GeneralInformation(IWebDriver wd, string recentSalary, string recentBonus, string comments)
        {
            wd.FindElement(By.CssSelector("#gnewtonGenInf > dl > dd > div:nth-child(1) > div.gnewtonQuestionInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.CssSelector("#gnewtonGenInf > dl > dd > div:nth-child(2) > div.gnewtonQuestionInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.CssSelector("#gnewtonGenInf > dl > dd > div:nth-child(3) > div.gnewtonQuestionInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.Id("gnewotn_input_15")).Click();
            wd.FindElement(By.Id("gnewotn_input_15")).Clear();
            wd.FindElement(By.Id("gnewotn_input_15")).SendKeys(recentSalary);
            wd.FindElement(By.Id("gnewotn_input_19")).Click();
            wd.FindElement(By.Id("gnewotn_input_19")).Clear();
            wd.FindElement(By.Id("gnewotn_input_19")).SendKeys(recentBonus);
            wd.FindElement(By.CssSelector("#gnewtonGenInf > dl > dd > div:nth-child(7) > div.gnewtonQuestionInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.CssSelector("#gnewtonGenInf > dl > dd > div:nth-child(8) > div.gnewtonQuestionInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.CssSelector("#gnewtonGenInf > dl > dd > div:nth-child(9) > div.gnewtonQuestionInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.CssSelector("#gnewtonGenInf > dl > dd > div:nth-child(10) > div.gnewtonQuestionInputClass > label:nth-child(3)")).Click();
            wd.FindElement(By.Id("gnewotn_input_20")).Click();
            wd.FindElement(By.Id("gnewotn_input_20")).Clear();
            wd.FindElement(By.Id("gnewotn_input_20")).SendKeys(comments);
        }

        private static void ContactInformation(IWebDriver wd, string cellPhone, string hPhone)
        {
            wd.FindElement(By.Id("gnewotn_input_13")).Click();
            wd.FindElement(By.Id("gnewotn_input_13")).Clear();
            wd.FindElement(By.Id("gnewotn_input_13")).SendKeys(cellPhone);
            wd.FindElement(By.Id("gnewotn_input_14")).Click();
            wd.FindElement(By.Id("gnewotn_input_14")).Clear();
            wd.FindElement(By.Id("gnewotn_input_14")).SendKeys(hPhone);
        }

        private static void CurrentAddress(IWebDriver wd, string address1, string city, string zipCode)
        {
            SelectElement selectCountry = new SelectElement(wd.FindElement(By.Id("country")));
            selectCountry.SelectByValue("US");
            wd.FindElement(By.Id("address1")).Click();
            wd.FindElement(By.Id("address1")).Clear();
            wd.FindElement(By.Id("address1")).SendKeys(address1);
            wd.FindElement(By.Id("city")).Click();
            wd.FindElement(By.Id("city")).Clear();
            wd.FindElement(By.Id("city")).SendKeys(city);
            SelectElement selectState2 = new SelectElement(wd.FindElement(By.Id("state")));
            selectState2.SelectByValue("IL");
            wd.FindElement(By.Id("zipCode")).Click();
            wd.FindElement(By.Id("zipCode")).Clear();
            wd.FindElement(By.Id("zipCode")).SendKeys(zipCode);
        }

        private static void AddAttachments(IWebDriver wd)
        {
            wd.FindElement(By.Id("converLetterOptional")).SendKeys(@"C:\Users\Evolve Computing\Desktop\New Job\CV\Cover  Latter Valeriy Cherkashin.docx");
        }

        private static void PersonalInformation(IWebDriver wd, string fname, string lname, string eMail)
        {
            wd.FindElement(By.Id("firstName")).Click();
            wd.FindElement(By.Id("firstName")).Clear();
            wd.FindElement(By.Id("firstName")).SendKeys(fname);
            wd.FindElement(By.Id("lastName")).Click();
            wd.FindElement(By.Id("lastName")).Clear();
            wd.FindElement(By.Id("lastName")).SendKeys(lname);
            wd.FindElement(By.Id("email")).Click();
            wd.FindElement(By.Id("email")).Clear();
            wd.FindElement(By.Id("email")).SendKeys(eMail);

        }

        private static void JobSearch(IWebDriver wd)
        {
            wd.SwitchTo().Frame("gnewtonIframe");
            wd.FindElement(By.Id("gnewtonKeyword")).Click();
            wd.FindElement(By.Id("gnewtonKeyword")).Clear();
            wd.FindElement(By.Id("gnewtonKeyword")).SendKeys("Software Engineer");
            SelectElement selectDepartment = new SelectElement(wd.FindElement(By.Id("gnewtonDepartment")));
            selectDepartment.SelectByValue("8a788267552e49bf01553674d259028c");
            SelectElement selectState = new SelectElement(wd.FindElement(By.Id("gnewtonState")));
            selectState.SelectByValue("IL");
            SelectElement selectSities = new SelectElement(wd.FindElement(By.Id("gnewtonCity")));
            selectSities.SelectByValue("Chicago");
            wd.FindElement(By.Id("gnewtonSearchButtonCell")).Click();
            wd.FindElement(By.XPath("//*[@id=\"gnewtonCareerHome\"]/tbody/tr[4]/td/div[2]/div[1]/a")).Click();
            wd.FindElement(By.XPath("//*[@id=\"gnewtonJobDescriptionBtn\"]/div[1]")).Click();
        }

        private static void NavigateCBOE(IWebDriver wd)
        {
            wd.FindElement(By.PartialLinkText("About CBOE")).Click();
            wd.FindElement(By.PartialLinkText("Careers")).Click();
            wd.FindElement(By.PartialLinkText("Job Search")).Click();
        }


    }
}
