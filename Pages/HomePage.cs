using Microsoft.Playwright;
using PlaywrightTests.Automation;

namespace PlaywrightTests.Pages
{
    public class HomePage
    {
        private readonly IPage Page;
        public ILocator QuoteText => Page.Locator("//blockquote[@class = 'blockquote']");

        public HomePage(Hook hook)
        {
            Page = hook.Page;
        }
    }
}
