using FluentAssertions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http.Json;

namespace Decorator.Api.Tests
{
    [TestClass]
    public class CalculatorControllerShould
    {
        private readonly HttpClient _client;
        public CalculatorControllerShould()
        {
            _client = new WebApplicationFactory<Program>().CreateDefaultClient();
        }

        [TestMethod]
        public async Task DividesCorrectlyAsync()
        {
            var response = await _client.GetAsync("calculator/divide?left=2&right=1");
            var content = await response.Content.ReadFromJsonAsync<double>();

            response.IsSuccessStatusCode.Should().BeTrue();
            content.Should().Be(2);
        }

        [TestMethod]
        public async Task ReturnsZero_WhenDividingByZeroAsync()
        {
            var response = await _client.GetAsync($"calculator/divide?left=1&right=0");
            var content = await response.Content.ReadFromJsonAsync<double>();

            response.IsSuccessStatusCode.Should().BeTrue();
            content.Should().Be(0);
        }
    }
}