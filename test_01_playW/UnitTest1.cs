using Microsoft.Playwright.NUnit;

namespace test_01_playW
{
    [TestFixture]
    public class Basepage : PageTest
    {

        [Test]
        public void Test1()
        {

            Forms form = new Forms(Page);
            TextBox tbox = new TextBox(Page);
            CheckBox cbox = new CheckBox(Page);
            RadioButton rbtn = new RadioButton(Page);
            WebTables wtable = new WebTables(Page);
            Buttons btn = new Buttons(Page);
            Links link = new Links(Page);
            BrokenLinks b_link = new BrokenLinks(Page);
            UploadAndDownload uad = new UploadAndDownload(Page);
            DynamicProperties dp = new DynamicProperties(Page);

            Login login = new Login(Page);

            // forms
            form.FillForms("https://demoqa.com/", "abc", "xyz", "abcxyz@gmail.com", "1234512345", "12 apr 2013", "Maths", "karachi pakistan");
            
            // text box
            tbox.TextBoxFill("xyz", "xyz@gmail.com", "karachi", "paksitan");

            // check box
            cbox.CheckBoxClick();

            // radio button 
            rbtn.RadioButtonClicker();
            
            // web tables
            wtable.WebtablesClicker("acd","xyz","xyz@gmail.com","34","2389","cs","tyu");

            // buttons
            btn.ButtonClick();

            // links
            // link.LinkClicker();

            // brooken links
            b_link.BlinkClick();

            // upload and downlaod
            uad.UaD_click();

            // dynamic properties
            dp.DynamicProperties_click();

            // login
            login.LoginPerform("abcxyz", "abcxyz123", "abc", "xyz", "abcxyz", "Abcxyz@12");
        }
    }
}