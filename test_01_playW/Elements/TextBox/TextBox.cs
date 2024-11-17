using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01_playW
{
    internal class TextBox
    {
        private readonly ILocator ElementClick;
        private readonly ILocator TextBoxClick;
        private readonly ILocator FullName;
        private readonly ILocator email;
        private readonly ILocator currentAddress;
        private readonly ILocator permanentAddress;
        private readonly ILocator btn;
        public TextBox(IPage page) 
        {
            ElementClick = page.Locator("#app > div > div > div > div:nth-child(1) > div > div > div:nth-child(1) > span > div > div.header-text");
            TextBoxClick = page.Locator("#Text Box").First;
            FullName = page.GetByPlaceholder("#Full Name");
            email = page.GetByPlaceholder("#name@example.com");
            currentAddress = page.Locator("#currentAddress");
            permanentAddress = page.Locator("#permanentAddress");
            btn = page.Locator("#submit");
        }
        public async Task TextBoxFill(string fname,string eml,string caddresss,string paddress)
        {
            await ElementClick.ClickAsync();
            await TextBoxClick.ClickAsync();
            await FullName.FillAsync(fname);
            await email.FillAsync(eml);
            await currentAddress.FillAsync(caddresss);
            await permanentAddress.FillAsync(paddress);
            await btn.ClickAsync();
        }
    }
}
