using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace test_01_playW
{
    internal class Forms : PageTest
    {
        private readonly IPage _page;
        private readonly ILocator firstname;
        private readonly ILocator lastname;
        private readonly ILocator email;
        private readonly ILocator gender;
        private readonly ILocator mobileno;
        private readonly ILocator dob;
        private readonly ILocator subjectt;
        private readonly ILocator hobby;
        private readonly ILocator address;
        private readonly ILocator state;
        private readonly ILocator city;
        private readonly ILocator btn;
        private readonly ILocator formClicker;
        private readonly ILocator practiceForm;
        private readonly ILocator CloseModal;

        //private readonly ILocator firstname;
        
        public Forms(IPage page)
        {
            formClicker = page.Locator("#app > div > div > div.home-body > div > div:nth-child(2) > div > div.card-body > h5");
            practiceForm = page.Locator("#app > div > div > div > div:nth-child(1) > div > div > div:nth-child(2) > div > ul");
            firstname = page.Locator("#firstName");
            lastname = page.Locator("#lastName");
            email = page.Locator("#userEmail");
            gender = page.GetByText("Female");
            mobileno = page.GetByPlaceholder("Mobile Number");
            dob = page.Locator("#dateOfBirthInput");
            subjectt = page.Locator("#subjectsContainer > div > div.subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3");
            hobby = page.GetByText("Reading");
            address = page.GetByPlaceholder("Current Address");
            state = page.Locator("Page.Locator(\"#react-select-3-input\")");
            city = page.Locator("#react-select-4-input");
            btn = page.Locator("#submit");
            CloseModal = page.Locator("closeLargeModal");
        }

        public async Task FillForms(string url,string name, string lname,string emaill,string Mno, string Dob,string subj, string addresss)
        {
            Page.GotoAsync(url);
            formClicker.ClickAsync();
            practiceForm.ClickAsync();
            firstname.FillAsync(name);
            lastname.FillAsync(lname);
            email.FillAsync(emaill);
            gender.ClickAsync();
            mobileno.FillAsync(Mno);
            dob.FillAsync(Dob);
            dob.PressAsync("Enter");
            subjectt.FillAsync(subj);
            subjectt.PressAsync("Enter");
            hobby.ClickAsync();
            address.FillAsync(addresss);
            state.ClickAsync();
            city.ClickAsync();
            btn.ClickAsync();
            CloseModal.ClickAsync();
        }


        //        //public async Task Form_Click()
        //        {
        //            await Page.GotoAsync("https://demoqa.com/");
        //            await Page.ClickAsync("#app > div > div > div.home-body > div > div:nth-child(2)");
        //            await Page.ClickAsync("#app > div > div > div > div:nth-child(1) > div > div > div:nth-child(2) > div > ul");
        //        }

        //        public async Task Locate_form()
        //        {
        //            Form_Click();


        //            await Page.FillAsync("#lastName", "abc");
        //            await Page.FillAsync("#userEmail", "xyz@123.com");
        //            await Page.ClickAsync("#genterWrapper > div.col-md-9.col-sm-12 > div:nth-child(2) > label");
        //            await Page.FillAsync("#userNumber", "0312345678");
        //            await Page.Locator("#dateOfBirthInput").FillAsync("12 apr 1977");
        //            await Page.PressAsync("#dateOfBirthInput", "Enter");
        //            ////await Page.FillAsync("#subjectsContainer > div > div.subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3", "Maths");
        //            //await Page.ClickAsync("#subjectsContainer > div > div.subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3");
        //            //await Page.FillAsync("#subjectsContainer > div > div.subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3", "Maths");
        //            //await Page.PressAsync("#subjectsContainer > div > div.subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3", "Enter");

        //            var subjectsInput = Page.Locator("#subjectsContainer input");

        //            // Type the subject and press Enter to select it from suggestions
        //            await subjectsInput.FillAsync("Maths");
        //            await subjectsInput.PressAsync("Enter");

        //            //await Page.ClickAsync("#hobbiesWrapper > div.col-md-9.col-sm-12 > div:nth-child(2) > label");
        //            await Page.GetByText("Reading").ClickAsync();
        //            //await Page.ClickAsync("uploadPicture");
        //            await Page.FillAsync("#currentAddress", "karachi pakistan");

        //            //await Page.SelectOptionAsync("#state > div > div.css-1wy0on6 > div > svg > path", "Haryana");
        //            //var city = Page.Locator("#state > div > div.css-1hwfws3");
        //            //await city.FillAsync("Haryana");
        //            //await city.PressAsync("Enter");

        //            await Page.Locator("#react-select-3-input").FillAsync("haryana");
        //            await Page.Locator("#react-select-3-input").PressAsync("Enter");
        //            await Page.GetByText("Select City").ClickAsync();
        //            await Page.Locator("#react-select-4-input").FillAsync("Panipat");
        //            await Page.Locator("#react-select-4-input").PressAsync("Enter");

        //            //var state = Page.Locator("#city > div > div.css-1hwfws3");
        //            //await state.FillAsync("Karnal");
        //            //await state.PressAsync("Enter");

        //            await Page.ClickAsync("#submit");

        //        }
        //        public async Task Fill_form()
        //        {
        //            Form_Click();
        //            await Page.FillAsync("#firstName", "xyz");
        //            await Page.FillAsync("#lastName", "abc");
        //            await Page.FillAsync("#userEmail", "xyz@123.com");
        //            await Page.ClickAsync("#genterWrapper > div.col-md-9.col-sm-12 > div:nth-child(2) > label");
        //            await Page.FillAsync("#userNumber", "0312345678");
        //            await Page.Locator("#dateOfBirthInput").FillAsync("12 apr 1977");
        //            await Page.PressAsync("#dateOfBirthInput", "Enter");
        //            ////await Page.FillAsync("#subjectsContainer > div > div.subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3", "Maths");
        //            //await Page.ClickAsync("#subjectsContainer > div > div.subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3");
        //            //await Page.FillAsync("#subjectsContainer > div > div.subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3", "Maths");
        //            //await Page.PressAsync("#subjectsContainer > div > div.subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3", "Enter");

        //            var subjectsInput = Page.Locator("#subjectsContainer input");

        //            // Type the subject and press Enter to select it from suggestions
        //            await subjectsInput.FillAsync("Maths");
        //            await subjectsInput.PressAsync("Enter");

        //            //await Page.ClickAsync("#hobbiesWrapper > div.col-md-9.col-sm-12 > div:nth-child(2) > label");
        //            await Page.GetByText("Reading").ClickAsync();
        //            //await Page.ClickAsync("uploadPicture");
        //            await Page.FillAsync("#currentAddress", "karachi pakistan");

        //            //await Page.SelectOptionAsync("#state > div > div.css-1wy0on6 > div > svg > path", "Haryana");
        //            //var city = Page.Locator("#state > div > div.css-1hwfws3");
        //            //await city.FillAsync("Haryana");
        //            //await city.PressAsync("Enter");

        //            await Page.Locator("#react-select-3-input").FillAsync("haryana");
        //            await Page.Locator("#react-select-3-input").PressAsync("Enter");
        //            await Page.GetByText("Select City").ClickAsync();
        //            await Page.Locator("#react-select-4-input").FillAsync("Panipat");
        //            await Page.Locator("#react-select-4-input").PressAsync("Enter");

        //            //var state = Page.Locator("#city > div > div.css-1hwfws3");
        //            //await state.FillAsync("Karnal");
        //            //await state.PressAsync("Enter");

        //            await Page.ClickAsync("#submit");

        //        }


    }
}
