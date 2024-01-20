using System.Text.Json.Serialization;

namespace ATMConsoleApp.Models
{
    class ATMBaseLog
    {
        public ATMBaseLog()
        {
            Id = Guid.NewGuid().ToString();
            ProcessDate = DateTime.Now;
        }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("processDate")]
        public DateTime ProcessDate { get; set; }
        [JsonPropertyName("logType")]
        public ATMLogTypeEnum LogType { get; set; }
    }
}