using Newtonsoft.Json;

namespace FundAmerica.Objects
{
    public class ACHAuthorizationRequest
    {
        [JsonProperty(PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "account_type")]
        public string AccountType { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "check_type")]
        public string CheckType { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        [JsonProperty(PropertyName = "contact_name")]
        public string ContactName { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "entity_id")]
        public string EntityId { get; set; }

        [JsonProperty(PropertyName = "ip_address")]
        public string IPAddress { get; set; }

        [JsonProperty(PropertyName = "literal")]
        public string Literal { get; set; }

        [JsonProperty(PropertyName = "name_on_account")]
        public string NameOnAccount { get; set; }

        [JsonProperty(PropertyName = "routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "use_for_investor_payments")]
        public bool UseForInvestorPayments { get; set; }

        [JsonProperty(PropertyName = "user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty(PropertyName = "zip_code")]
        public string ZipCode { get; set; }
    }

    public class ACHAuthorization : BaseObjectType
    {
        [JsonProperty(PropertyName = "account_number_short")]
        public string AccountNumberShort { get; set; }

        [JsonProperty(PropertyName = "agreement_html")]
        public string AgreementHtml { get; set; }

        [JsonProperty(PropertyName = "bank_transfer_method_url")]
        public string BankTransferMethodUrl { get; set; }

        [JsonProperty(PropertyName = "cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty(PropertyName = "entity_url")]
        public string EntityUrl { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "name_on_account")]
        public string NameOnAccount { get; set; }

        [JsonProperty(PropertyName = "routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "verified")]
        public bool Verified { get; set; }
    }
}