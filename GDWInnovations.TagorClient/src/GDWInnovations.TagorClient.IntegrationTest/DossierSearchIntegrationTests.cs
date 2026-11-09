using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Extensions;
using GDWInnovations.TagorClient.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GDWInnovations.TagorClient.IntegrationTest
{
    /// <summary>
    /// This integration test checks some fields on a production dossier. Don't run in CI.
    /// Calls a real Tagor instance configured in appsettings.json or user secrets (section "Tagor").
    /// </summary>
    public class DossierSearchIntegrationTests : IDisposable
    {
        private readonly ServiceProvider _provider;
        private readonly string _rrnForIntegrationTest;

        public DossierSearchIntegrationTests()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true)
                .AddUserSecrets<DossierSearchIntegrationTests>(optional: true)
                .Build();

            var services = new ServiceCollection();
            services.AddLogging();
            string? tagorBasePath = configuration["Tagor:BasePath"] ?? "BASE_PATH_NOT_SET";
            string? tagorApiKey = configuration["Tagor:AccessToken"] ?? "API_KEY_NOT_SET";

            services.AddTagor(o =>
            {
                o.BasePath = tagorBasePath;
                o.DefaultHeaders.Add("Authorization", tagorApiKey);
            });

            _rrnForIntegrationTest = configuration["RrnForIntegrationTest"] ?? throw new InvalidOperationException("RrnForIntegrationTest not set in appsettings.json or user secrets");

            _provider = services.BuildServiceProvider();
        }

        public void Dispose() => _provider.Dispose();

        [Fact]
        [Trait("Category", "Integration")]
        public async Task DossierSearch_ByRijksregisternr_ReturnsDossiers()
        {
            var client = _provider.GetRequiredService<ITagorClient>();

            var request = new DossierSearchRequest(new DossierSearchRequestRequest(
                dsFilter: new DsFilter(new DsFilterDsFilter(new List<DsFilterDsFilterTtFilterInner>
                {
                    new DsFilterDsFilterTtFilterInner(veld: "TPAR.Rijksregisternr", varOperator: "=", waarde: _rrnForIntegrationTest)
                }))));

            var response = await client.Dossier.DossierSearchAsync(request);

            var dossiers = response.Response.DsTDOSSearch.VarDsTDOSSearch.TtTDOSSearch;
            var dossier = Assert.Single(dossiers, d => d.Dossiernaam == "2411ECS2589S004");
            Assert.True(dossier.Subdossier);
            Assert.Equal("2411ECS2589", dossier.Hoofddossier);
        }
    }
}
