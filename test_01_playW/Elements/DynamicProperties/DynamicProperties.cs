using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01_playW
{
    internal class DynamicProperties
    {
        private readonly ILocator dynamicuploadClick;
        private readonly ILocator asser01;
        private readonly ILocator enable;
        private readonly ILocator color;
        private readonly ILocator visible;
        public DynamicProperties(IPage page) 
        {
            dynamicuploadClick = page.GetByText("Dynamic Properties");
            asser01 = page.Locator("#RvlNn");
            enable = page.Locator("#");
            color = page.Locator("#");
            visible = page.Locator("#");
        }

        public async Task DynamicProperties_click()
        {
            await dynamicuploadClick.ClickAsync();
            await Assertions.Expect(asser01).ToHaveTextAsync("This text has random Id");
            await enable.ClickAsync();
            await color.ClickAsync();
            await visible.ClickAsync();
        }
    }
}
