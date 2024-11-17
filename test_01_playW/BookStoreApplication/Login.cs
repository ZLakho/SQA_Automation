using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test_01_playW
{
    internal class Login
    {
        private readonly IPage page;
        private readonly ILocator assert01;
        private readonly ILocator username;
        private readonly ILocator password;
        private readonly ILocator incorrectId;
        private readonly ILocator loginButton;
        private readonly ILocator registerButton;
        private readonly ILocator FirstName;
        private readonly ILocator Lastname;
        private readonly ILocator NewUser;
        private readonly ILocator NewPassword;
        private readonly ILocator assert02;
        private readonly ILocator captcha;
        private readonly ILocator RegisterUser;
        private readonly ILocator BackToLogin;
        private readonly ILocator afterLoginAssert;
        private readonly ILocator logout;

        public Login(IPage _page)
        {
            page = _page;
            assert01 = page.Locator("#userForm > div:nth-child(1) > h5");
            username = page.GetByPlaceholder("UserName");
            password = page.GetByPlaceholder("Password");
            incorrectId = page.Locator("#name");
            loginButton = page.Locator("#login");
            registerButton = page.Locator("#newUser");
            FirstName = page.GetByPlaceholder("First Name");
            Lastname = page.GetByPlaceholder("Last Name");
            NewUser = page.GetByPlaceholder("UserName");
            NewPassword = page.GetByPlaceholder("Password");
            assert02 = page.Locator("#userForm > div:nth-child(1) > h4");
            captcha = page.Locator("#recaptcha-anchor > div.recaptcha-checkbox-border");
            RegisterUser = page.Locator("#register");
            afterLoginAssert = page.Locator("#userName-label").First;
            BackToLogin = page.Locator("#gotologin");
            logout = page.GetByText("Log out");
        }

        public async Task LoginPerform(string Uname, string Passw, string Fname, string Lname, string Nuser, string NPass)
        {
            await Assertions.Expect(assert01).ToHaveTextAsync("Login in Book Store");
            await username.FillAsync(Uname);
            await password.FillAsync(Passw);

            await loginButton.ClickAsync();

            string errorMessage = await incorrectId.InnerTextAsync();
            if (errorMessage.Contains("Invalid username or password!"))
            {
                await Register(Fname, Lname, Nuser, NPass);
                await AgainLoginPerform(Nuser,NPass);
            }
            else
            {
                await Assertions.Expect(afterLoginAssert).ToHaveTextAsync("Books : ");
                logout.ClickAsync();
            }

        }


        public async Task Register( string Fname, string Lname, string Nuser, string NPass)
        {
            await registerButton.ClickAsync();
            await Assertions.Expect(assert02).ToHaveTextAsync("Register to Book Store");
            FirstName.FillAsync(Fname);
            Lastname.FillAsync(Lname);
            NewUser.FillAsync(Nuser);
            NewPassword.FillAsync(NPass);
            captcha.ClickAsync();
            RegisterUser.ClickAsync();

            // page alert handle hoga yahan

            page.Dialog += async (_, dialog) =>
            {
                await dialog.AcceptAsync();
            };


        }

        public async Task AgainLoginPerform(string Uname, string Passw)
        {
            await BackToLogin.ClearAsync();
            await Assertions.Expect(assert01).ToHaveTextAsync("Login in Book Store");
            await username.FillAsync(Uname);
            await password.FillAsync(Passw);

            await loginButton.ClickAsync();

        }


    }
}
