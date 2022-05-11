using Newtonsoft.Json;

namespace FundAmerica.Objects
{
    public class WireDetailsType
    {
        [JsonProperty(PropertyName = "bank_address")]
        public string BankAddress { get; set; }

        [JsonProperty(PropertyName = "bank_name")]
        public string BankName { get; set; }

        [JsonProperty(PropertyName = "bank_phone")]
        public string BankPhone { get; set; }

        [JsonProperty(PropertyName = "routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty(PropertyName = "swift_code")]
        public string SwiftCode { get; set; }

        [JsonProperty(PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "beneficiary_name")]
        public string BeneficiaryName { get; set; }

        [JsonProperty(PropertyName = "beneficiary_address")]
        public string BenficiaryAddress { get; set; }
    }
}