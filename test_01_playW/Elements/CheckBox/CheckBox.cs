using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01_playW
{
    internal class CheckBox
    {
        private readonly ILocator CheckBoxx;
        private readonly ILocator ExpandHome;
        private readonly ILocator Notes;
        private readonly ILocator React;
        private readonly ILocator General;
        private readonly ILocator FileDoc;
        public CheckBox(IPage page) 
        {
            CheckBoxx = page.GetByText("Check Box");
            ExpandHome = page.Locator(".rct-icon rct-icon-expand-all");
            Notes = page.GetByText("Notes");
            React = page.GetByText("React");
            General = page.GetByText("General");
            FileDoc = page.GetByText("Excel File.doc"); 
        }

        public async Task CheckBoxClick()
        {
            await CheckBoxx.ClickAsync();
            await ExpandHome.ClickAsync();
            await Notes.ClickAsync();
            await React.ClickAsync();
            await General.ClickAsync();
            await FileDoc.ClickAsync();

        }
    }
}
