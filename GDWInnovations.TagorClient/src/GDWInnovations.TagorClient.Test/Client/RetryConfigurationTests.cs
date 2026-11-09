using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

using GDWInnovations.TagorClient.Client;

namespace GDWInnovations.TagorClient.Test.Client
{
    public class RetryConfigurationTests
    {
        [Theory]
        [InlineData(401, 3)]
        [InlineData(403, 3)]
        [InlineData(503, 3)]
        [InlineData(503, 1)]
        [InlineData(503, 0)]
        public async Task RetriesTransientFailureThenReturnsLastResponse(int statusCode, int maxRetryAttempts)
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();

            using var server = new HttpListener();
            server.Prefixes.Add($"http://localhost:{port}/");
            server.Start();

            var hits = 0;
            _ = Task.Run(async () =>
            {
                while (server.IsListening)
                {
                    var context = await server.GetContextAsync();
                    Interlocked.Increment(ref hits);
                    context.Response.StatusCode = statusCode;
                    context.Response.Close();
                }
            });

            var config = new TagorConfiguration { BasePath = $"http://localhost:{port}" };
            var retry = new TagorRetryConfiguration { MaxRetryAttempts = maxRetryAttempts, BaseDelay = System.TimeSpan.Zero };
            var response = await new ApiClient(config.BasePath, retry).GetAsync<string>("/x", new RequestOptions(), config);

            Assert.Equal(1 + maxRetryAttempts, hits);
            Assert.Equal((HttpStatusCode)statusCode, response.StatusCode);
        }
    }
}
