using BidvestMobilitySurveyFrontEnd.Models;
using Refit;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BidvestMobilitySurveyFrontEnd.Helpers
{
    public static class Extensions
    {
        private static JsonSerializerOptions jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };
        public static Response? ToResponse(this string json)
        {
            return JsonSerializer.Deserialize<Response>(json, jsonOptions);
        }

    public static RefitSettings GetRefitSettings()
    {
        // override default jsonserializer to serialeze enum as int instead of string
        var serializerOptions = SystemTextJsonContentSerializer.GetDefaultJsonSerializerOptions();
        serializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        serializerOptions.PropertyNameCaseInsensitive = true;

        var converters = serializerOptions.Converters;
        int count = converters.Count;

        for (int i = count - 1; i > 0; i--)
        {
            if (converters[i] is JsonStringEnumConverter jstrCon)
                converters.Remove(jstrCon);

        };
        return new() { ContentSerializer = new SystemTextJsonContentSerializer(serializerOptions) };
    }
    }

}
