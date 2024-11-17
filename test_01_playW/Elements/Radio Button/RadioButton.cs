using Microsoft.Playwright;

namespace test_01_playW
{
    internal class RadioButton
    {

        private readonly ILocator RadioButtonClick;
        private readonly ILocator optionSelector;
        private readonly ILocator assert;


        public RadioButton(IPage page)
        {
            RadioButtonClick = page.GetByText("Radio Button");
            optionSelector = page.GetByText("Impressive");
            assert = page.Locator("#app > div > div > div > div.col-12.mt-4.col-md-6 > div:nth-child(3) > p");

        }
        public async Task RadioButtonClicker()
        {
            await RadioButtonClick.ClearAsync();
            await optionSelector.ClearAsync();
            await assert.WaitForAsync();
            //await assert.ExpectToHaveTextAsync("You have selected Impressive");
            await Assertions.Expect(assert).ToHaveTextAsync("You have selected Impressive");
            }


    }
}
