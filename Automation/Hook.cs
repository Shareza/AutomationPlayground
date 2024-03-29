﻿using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace PlaywrightTests.Automation
{
    [Binding]
    public class Hook
    {
        public IPage Page { get; private set; } = null!;

        [BeforeScenario]
        public async Task RegisterSingleInstancePractitioner()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false,
                });

            var context = await browser.NewContextAsync();
            Page = await context.NewPageAsync();
        }
    }
}