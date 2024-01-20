using System.Text.Json.Serialization;

namespace ATMConsoleApp
{
    [JsonConverter(typeof(JsonNumberEnumConverter<ATMLogTypeEnum>))]
    public enum ATMLogTypeEnum
    {
        InvalidLogin = 1,
        Transaction = 2
    }
}