using System;
using System.Net;
using Polly;
using RestSharp;

namespace GDWInnovations.TagorClient.Client
{
    /// <summary>
    /// Retry settings for requests to Tagor. Transient failures are retried with exponential backoff
    /// (<see cref="BaseDelay"/>, then 2x, 4x, ...). Set <see cref="MaxRetryAttempts"/> to 0 to disable retries.
    /// </summary>
    public class TagorRetryConfiguration
    {
        /// <summary>
        /// Number of retries after the first attempt. Defaults to 3; 0 disables retries.
        /// </summary>
        public int MaxRetryAttempts { get; set; } = 3;

        /// <summary>
        /// Delay before the first retry; doubles on every next retry. Defaults to 1 second.
        /// </summary>
        public TimeSpan BaseDelay { get; set; } = TimeSpan.FromSeconds(1);

        /// <summary>
        /// Connection failures (no response received) and 401/403/429/502/503/504.
        /// 401/403 are retried because the Tagor service is unstable and returns them spuriously.
        /// Timeouts and 500 are not retried: most Tagor endpoints are non-idempotent POSTs.
        /// </summary>
        internal static bool IsTransient(RestResponse response) =>
            (response.StatusCode == 0 && response.ResponseStatus == ResponseStatus.Error)
            || response.StatusCode is HttpStatusCode.Unauthorized
                or HttpStatusCode.Forbidden
                or HttpStatusCode.TooManyRequests
                or HttpStatusCode.BadGateway
                or HttpStatusCode.ServiceUnavailable
                or HttpStatusCode.GatewayTimeout;

        private TimeSpan Backoff(int attempt) => BaseDelay * Math.Pow(2, attempt - 1);

        /// <summary>Synchronous retry policy, or null when retries are disabled.</summary>
        internal Policy<RestResponse> CreatePolicy() => MaxRetryAttempts <= 0 ? null
            : Policy.HandleResult<RestResponse>(IsTransient).WaitAndRetry(MaxRetryAttempts, Backoff);

        /// <summary>Asynchronous retry policy, or null when retries are disabled.</summary>
        internal AsyncPolicy<RestResponse> CreateAsyncPolicy() => MaxRetryAttempts <= 0 ? null
            : Policy.HandleResult<RestResponse>(IsTransient).WaitAndRetryAsync(MaxRetryAttempts, Backoff);
    }
}
