using Newtonsoft.Json;

namespace FundAmerica.Objects
{
    public class EntityType : BaseObjectType
    {
        [JsonProperty(PropertyName = "broker_dealer_customer")]
        public bool BrokerDealerCustomer { get; set; }

        [JsonProperty(PropertyName = "building_name")]
        public string BuildingName { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "contact_name")]
        public string ContactName { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "executive_name")]
        public string ExecutiveName { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "platform_investor_url")]
        public string PlaformInvestorUrl { get; set; }

        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        [JsonProperty(PropertyName = "region_formed_in")]
        public string RegionFormedIn { get; set; }

        [JsonProperty(PropertyName = "street_address_1")]
        public string StreetAddress1 { get; set; }

        [JsonProperty(PropertyName = "street_address_2")]
        public string StreetAddress2 { get; set; }

        [JsonProperty(PropertyName = "street_name")]
        public string StreetName { get; set; }

        [JsonProperty(PropertyName = "street_number")]
        public string StreetNumber { get; set; }

        [JsonProperty(PropertyName = "street_type")]
        public string StreetType { get; set; }

        [JsonProperty(PropertyName = "tax_id_number")]
        public string TaxIDNumber { get; set; }

        /// <summary>
        /// Can be one of: person, company, custodial
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "unit_number")]
        public string UnitNumber { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Can be one of: null, pending, accepted, denied
        /// </summary>
        [JsonProperty(PropertyName = "investor_suitability_status")]
        public string InvestorSuitabilityStatus { get; set; }
    }
}