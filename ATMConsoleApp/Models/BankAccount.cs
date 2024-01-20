using System.Text.Json.Serialization;

namespace ATMConsoleApp
{
    class BankAccount
    {
        public BankAccount()
        {
            Id = Guid.NewGuid().ToString();
        }
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;
        [JsonPropertyName("iban")]
        public string IBAN { get; set; } = null!;
        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; } = null!;
        [JsonPropertyName("lastName")]
        public string LastName { get; set; } = null!;
        [JsonPropertyName("balance")]
        public decimal Balance { get; set; } = 0;
    }
}