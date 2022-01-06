using NUnit.Framework;
using static Testing;

namespace JasonTaylorCleanArch.Application.IntegrationTests
{
    public class TestBase
    {
        [SetUp]
        public async Task TestSetUp()
        {
            await ResetState();
        }
    }
}