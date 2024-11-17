using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01_playW
{
    internal class BrokenLinks : PageTest
    {
        private readonly ILocator assert01;
        private readonly ILocator ValidLink;
        private readonly ILocator BrokenLink;

        public BrokenLinks(IPage page) 
        {
            assert01 = page.GetByText("Broken image");
            ValidLink = page.Locator("#app > div > div > div > div.col-12.mt-4.col-md-6 > div:nth-child(2) > a:nth-child(11)");
            BrokenLink = page.Locator("#app > div > div > div > div.col-12.mt-4.col-md-6 > div:nth-child(2) > a:nth-child(15)");
        }

        public async Task BlinkClick()
        {
            await Assertions.Expect(assert01).ToHaveTextAsync("Broken image");
            await ValidLink.ClickAsync();
            await Page.GotoAsync("https://demoqa.com/broken");
            await BrokenLink.ClickAsync();
            await Page.GotoAsync("https://demoqa.com/broken");



        }

    }
}
