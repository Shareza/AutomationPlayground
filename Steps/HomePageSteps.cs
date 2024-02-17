using Microsoft.Playwright;
using TechTalk.SpecFlow;
using PlaywrightTests.Pages;
using PlaywrightTests.Automation;


namespace PlaywrightTests.Steps
{
    [Binding]
    public class HomePageSteps
    {
        private readonly IPage Page;
        private readonly HomePage homePage;

        public HomePageSteps(Hook hook)
        {
            Page = hook.Page;
            homePage = new HomePage(hook);
        }

        [When("User navigates to home page")]
        public async Task GivenUserNavigatesToHomePage()
        {
            await Page.GotoAsync(Constants.HomePageUrl);
        }

        [Then(@"Test quote should be visible")]
        public async Task ThenTestQuoteShouldBeVisible()
        {
            await Assertions.Expect(homePage.QuoteText).ToBeVisibleAsync();
        }

        [Then(@"Test quote should read '(.*)'")]
        public async void ThenTestQuoteShouldRead(string text)
        {
            await Assertions.Expect(homePage.QuoteText).ToHaveTextAsync(text);
        }
    }
}
