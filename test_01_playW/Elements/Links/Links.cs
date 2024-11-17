using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01_playW
{
    
    internal class Links
    {
        private readonly ILocator LinkClick;
        private readonly ILocator Assert01;
        private readonly ILocator simpleLink;
        private readonly ILocator Unauthorized;
        private readonly ILocator Assert02;
        public Links(IPage page) 
        {
            LinkClick = page.GetByText("Links");
            Assert01 = page.Locator("#linkWrapper > h5:nth-child(2) > strong");
            simpleLink = page.Locator("#simpleLink");
            Unauthorized = page.Locator("#unauthorized");
            Assert01 = page.Locator("#linkResponse");
        }

        public async Task LinkClicker()  
        {
            await LinkClick.ClickAsync();
            await Assertions.Expect(Assert01).ToHaveTextAsync("Following links will open new tab");
            await simpleLink.ClickAsync();

            await Unauthorized.ClickAsync();
            await Unauthorized.WaitForAsync();
            await Assertions.Expect(Assert02).ToHaveTextAsync("Link has responded with staus 401 and status text Unauthorized");

        }
    }
}
