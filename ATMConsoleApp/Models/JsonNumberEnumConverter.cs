using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ATMConsoleApp.Models
{
    public class JsonNumberEnumConverter<TEnum> : JsonConverter<TEnum> where TEnum : Enum
    {
        public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException($"Unexpected token type: {reader.TokenType}");
            }

            return (TEnum)Enum.ToObject(typeof(TEnum), reader.GetInt32());
        }

        public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(Convert.ToInt32(value));
        }
    }
}
