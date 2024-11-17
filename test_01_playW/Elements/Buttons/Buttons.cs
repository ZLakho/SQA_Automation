using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01_playW
{
    internal class Buttons
    {
        private readonly ILocator button;
        private readonly ILocator Dbutton;
        private readonly ILocator Rbutton;
        private readonly ILocator Cmbutton;
        private readonly ILocator Dmessage;
        private readonly ILocator Rmessage;
        public Buttons(IPage page) 
        {
            button = page.GetByText("Buttons");
            Dbutton = page.Locator("#doubleClickBtn");
            Rbutton = page.Locator("#rightClickBtn");
            Cmbutton = page.Locator("#1FbzP");
            Dmessage = page.Locator("#doubleClickMessage");
            Rmessage = page.Locator("#dynamicClickMessage");
            
        }

        public async Task ButtonClick()
        {
            await button.ClickAsync();
            await Dbutton.DblClickAsync();
            await Assertions.Expect(Dmessage).ToHaveTextAsync("You have done a double click");
            await Rbutton.ClickAsync(new LocatorClickOptions { Button = MouseButton.Right });
            await Assertions.Expect(Rmessage).ToHaveTextAsync("You have done a dynamic click");
            await Cmbutton.ClickAsync();

        }
    }
}
