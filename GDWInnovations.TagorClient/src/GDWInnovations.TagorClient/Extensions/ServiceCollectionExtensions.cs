using System;
using GDWInnovations.TagorClient.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GDWInnovations.TagorClient.Extensions
{
    /// <summary>
    /// Extensions to abstract the service registerion of the TagorClient
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds <see cref="ITagorClient"/> to the service collection, configured through the options pattern
        /// (<see cref="IOptions{TagorConfiguration}"/> and <see cref="IOptions{TagorRetryConfiguration}"/>). Configure it with
        /// <c>services.Configure&lt;TagorConfiguration&gt;(...)</c>, <c>AddOptions&lt;TagorRetryConfiguration&gt;().BindConfiguration(...)</c>
        /// or the overload taking delegates. Without retry configuration, the <see cref="TagorRetryConfiguration"/> defaults apply.
        /// This will always give the real tagor. To communicate with a fake tagor (test mode), you need to put the x-mode = test header in the http request, or in the context for MCP
        /// </summary>
        public static IServiceCollection AddTagor(this IServiceCollection services)
        {
            services.AddOptions<TagorConfiguration>();
            services.AddOptions<TagorRetryConfiguration>();
            services.AddTransient<ITagorClient>(p => new TagorClient(
                p.GetRequiredService<ILoggerFactory>(),
                p.GetRequiredService<IOptions<TagorConfiguration>>().Value,
                p.GetRequiredService<IOptions<TagorRetryConfiguration>>().Value));
            return services;
        }

        /// <summary>
        /// Adds <see cref="ITagorClient"/> and configures <see cref="TagorConfiguration"/> and, optionally,
        /// <see cref="TagorRetryConfiguration"/> with the given delegates.
        /// </summary>
        public static IServiceCollection AddTagor(this IServiceCollection services, Action<TagorConfiguration> configure, Action<TagorRetryConfiguration> configureRetry = null)
        {
            services.Configure(configure);
            if (configureRetry != null)
            {
                services.Configure(configureRetry);
            }
            return services.AddTagor();
        }
    }
}
