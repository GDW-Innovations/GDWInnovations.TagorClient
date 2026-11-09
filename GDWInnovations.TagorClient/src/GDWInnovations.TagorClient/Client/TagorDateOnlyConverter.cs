using System;
using System.Globalization;
using Newtonsoft.Json;

namespace GDWInnovations.TagorClient.Client
{
    /// <summary>
    /// Reads <see cref="DateOnly"/> values that Tagor sometimes sends with a time part
    /// (e.g. "2020-06-12T10:00:00"). The date is taken as written, without timezone conversion.
    /// Writing falls back to Newtonsoft's default ("yyyy-MM-dd").
    /// </summary>
    public class TagorDateOnlyConverter : JsonConverter
    {
        /// <inheritdoc />
        public override bool CanWrite => false;

        /// <inheritdoc />
        public override bool CanConvert(Type objectType) =>
            objectType == typeof(DateOnly) || objectType == typeof(DateOnly?);

        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var nullable = objectType == typeof(DateOnly?);

            switch (reader.TokenType)
            {
                case JsonToken.Null:
                case JsonToken.String when string.IsNullOrWhiteSpace((string)reader.Value):
                    if (nullable)
                        return null;
                    throw new JsonSerializationException($"Cannot convert empty value to DateOnly. Path '{reader.Path}'.");

                case JsonToken.String:
                    var s = ((string)reader.Value).Trim();
                    // ISO date or date-time: keep the date as written, ignore time and offset.
                    if (s.Length >= 10 && DateOnly.TryParseExact(s.Substring(0, 10), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
                        return date;
                    if (DateTime.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateTime))
                        return DateOnly.FromDateTime(dateTime);
                    throw new JsonSerializationException($"Cannot convert '{s}' to DateOnly. Path '{reader.Path}'.");

                // Only reached when DateParseHandling is not None (e.g. caller replaced SerializerSettings).
                case JsonToken.Date when reader.Value is DateTimeOffset dateTimeOffset:
                    return DateOnly.FromDateTime(dateTimeOffset.DateTime);
                case JsonToken.Date when reader.Value is DateTime dt:
                    return DateOnly.FromDateTime(dt);

                default:
                    throw new JsonSerializationException($"Unexpected token {reader.TokenType} when reading DateOnly. Path '{reader.Path}'.");
            }
        }

        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) =>
            throw new NotSupportedException();
    }
}
