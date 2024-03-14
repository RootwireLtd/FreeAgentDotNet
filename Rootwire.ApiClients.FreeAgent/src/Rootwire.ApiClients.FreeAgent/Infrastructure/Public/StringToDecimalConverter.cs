using System.Text.Json;
using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.FreeAgent.Infrastructure.Public;

public class StringToDecimalConverter : JsonConverter<decimal>
{
    public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            string stringValue = reader.GetString();
            if (decimal.TryParse(stringValue, out var value))
            {
                return value;
            }
        }

        throw new JsonException("Value is not a valid decimal string.");
    }

    public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}