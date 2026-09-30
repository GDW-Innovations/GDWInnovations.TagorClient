using System;
using GDWInnovations.TagorClient.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GDWInnovations.TagorClient.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds <see cref="ITagorClient"/> to the service collection, configured through the options pattern
        /// (<see cref="IOptions{TagorConfiguration}"/>). Configure it with <c>services.Configure&lt;TagorConfiguration&gt;(...)</c>,
        /// <c>AddOptions&lt;TagorConfiguration&gt;().BindConfiguration(...)</c> or the overload taking a delegate.
        /// This will always give the real tagor. To communicate with a fake tagor (test mode), you need to put the x-mode = test header in the http request, or in the context for MCP
        /// </summary>
        public static IServiceCollection AddTagor(this IServiceCollection services)
        {
            services.AddOptions<TagorConfiguration>();
            services.AddTransient<ITagorClient>(p => new TagorClient(
                p.GetRequiredService<ILoggerFactory>(),
                p.GetRequiredService<IOptions<TagorConfiguration>>().Value));
            return services;
        }

        /// <summary>
        /// Adds <see cref="ITagorClient"/> and configures <see cref="TagorConfiguration"/> with the given delegate.
        /// </summary>
        public static IServiceCollection AddTagor(this IServiceCollection services, Action<TagorConfiguration> configure)
        {
            services.Configure(configure);
            return services.AddTagor();
        }
    }
}
