using System;
using Newtonsoft.Json;
using Xunit;

using GDWInnovations.TagorClient.Client;
using GDWInnovations.TagorClient.Model;

namespace GDWInnovations.TagorClient.Test.Client
{
    public class DateOnlyDeserializationTests
    {
        // Tagor returns some 'date' fields with a time part (e.g. Verschijningsdatum).
        [Theory]
        [InlineData("\"2020-06-12\"")]
        [InlineData("\"2020-06-12T10:00:00\"")]
        [InlineData("\"2020-06-12T10:00:00+02:00\"")]
        [InlineData("\"2020-06-12T23:30:00.000+02:00\"")]
        public void DeserializesDateOnlyFromDateOrDateTime(string value)
        {
            var json = "{\"Verschijningsdatum\":" + value + "}";

            var result = JsonConvert.DeserializeObject<DsTDOSSearchDsTDOSSearchTtTDOSSearchInner>(json, new ApiClient().SerializerSettings);

            Assert.Equal(new DateOnly(2020, 6, 12), result.Verschijningsdatum);
        }

        [Theory]
        [InlineData("null")]
        [InlineData("\"\"")]
        public void DeserializesEmptyNullableDateOnlyAsNull(string value)
        {
            var json = "{\"Verschijningsdatum\":" + value + "}";

            var result = JsonConvert.DeserializeObject<DsTDOSSearchDsTDOSSearchTtTDOSSearchInner>(json, new ApiClient().SerializerSettings);

            Assert.Null(result.Verschijningsdatum);
        }
    }
}
