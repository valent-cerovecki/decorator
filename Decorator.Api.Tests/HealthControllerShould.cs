using Decorator.Service;
using Decorator.Service.Health;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Api.Tests
{
    [TestClass]
    public class HealthControllerShould
    {
        [TestMethod]
        [DataRow(false, "Pong")]
        [DataRow(true, "OK")]
        public async Task ReturnExpected_DependingOnDecoration(bool useDecorator, string expectedOutput)
        {
            var factory = new WebApplicationFactory<Program>();
            if (useDecorator)
            {
                factory = factory.WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        services.Decorate<IHealthChecker, MyHealthChecker>();
                    });
                });
            }

            var client = factory.CreateDefaultClient();

            var response = await client.GetAsync("/health");
            var content = await response.Content.ReadAsStringAsync();

            response.IsSuccessStatusCode.Should().BeTrue();
            content.Should().Be(expectedOutput);
        }
    }
}
