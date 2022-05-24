using Newtonsoft.Json;
using System.Collections.Generic;

namespace FundAmerica.Objects
{
    public class SubscriptionAgreement : BaseObjectType
    {
        [JsonProperty(PropertyName = "offering_url")]
        public string OfferingUrl { get; set; }

        [JsonProperty(PropertyName = "archived_pdf_url")]
        public string ArchivedPDFUrl { get; set; }

        [JsonProperty(PropertyName = "body_html")]
        public string BodyHtml { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty(PropertyName = "electronic_signatures")]
        public List<ElectronicSignature> ElectronicSignatures { get; set; }

        [JsonProperty(PropertyName = "signed")]
        public bool Signed { get; set; }

        [JsonProperty(PropertyName = "signing_links")]
        public SigningLinks SigningLinks { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "data")]
        public SubscriptionData Data { get; set; }

        [JsonProperty(PropertyName = "investment")]
        public InvestmentType Investment { get; set; }

        [JsonProperty(PropertyName = "issuer_signed")]
        public bool IssuerSigned { get; set; }

        [JsonProperty(PropertyName = "subscriber_signed")]
        public bool SubscriberSigned { get; set; }

        [JsonProperty(PropertyName = "template_url")]
        public string TemplateUrl { get; set; }
    }

    public class ElectronicSignature : BaseObjectType
    {
        [JsonProperty(PropertyName = "anchor_id")]
        public string AnchorID { get; set; }

        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

        [JsonProperty(PropertyName = "document_url")]
        public string DocumentUrl { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "literal")]
        public string Literal { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "signable")]
        public bool Signable { get; set; }

        [JsonProperty(PropertyName = "signed")]
        public bool Signed { get; set; }

        [JsonProperty(PropertyName = "signed_at")]
        public string SignedAt { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "ip_address")]
        public string IPAddress { get; set; }

        [JsonProperty(PropertyName = "user_agent")]
        public string UserAgent { get; set; }
    }

    public class SigningLinks
    {
        [JsonProperty(PropertyName = "issuer_signature")]
        public SigningLink IssuerSignature { get; set; }

        [JsonProperty(PropertyName = "subscriber_signature")]
        public SigningLink SubscriberSignature { get; set; }
    }

    public class SigningLink
    {
        [JsonProperty(PropertyName = "electronic_signature_id")]
        public string ElectronicSignatureId { get; set; }

        [JsonProperty(PropertyName = "expires")]
        public string Expires { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }

    public class SubscriptionRequest
    {
        [JsonProperty(PropertyName = "debt_par_value")]
        public string DebtParValue { get; set; }

        [JsonProperty(PropertyName = "equity_share_count")]
        public string EquityShareCount { get; set; }

        [JsonProperty(PropertyName = "offering_id")]
        public string OfferingId { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, string> Data { get; set; }

        [JsonProperty(PropertyName = "vesting_amount")]
        public string VestingAmount { get; set; }

        [JsonProperty(PropertyName = "vesting_as")]
        public string VestingAs { get; set; }

        [JsonProperty(PropertyName = "vesting_as_email")]
        public string VestingAsEmail { get; set; }
    }

    public class SubscriptionData
    {
        [JsonProperty(PropertyName = "debt_interest_rate")]
        public string DebtIntresetRate { get; set; }

        [JsonProperty(PropertyName = "debt_maturity_date")]
        public string DebtMaturityDate { get; set; }

        [JsonProperty(PropertyName = "equity_share_price")]
        public string EquitySharePrice { get; set; }

        [JsonProperty(PropertyName = "offering_target_amount")]
        public string OfferingTargetAmount { get; set; }

        [JsonProperty(PropertyName = "debt_par_value")]
        public string DebtParValue { get; set; }

        [JsonProperty(PropertyName = "equity_share_count")]
        public string EquityShareCount { get; set; }

        [JsonProperty(PropertyName = "issuer_signature")]
        public IssuerSignature IssuerSignature { get; set; }

        [JsonProperty(PropertyName = "vesting_amount")]
        public string VestingAmount { get; set; }

        [JsonProperty(PropertyName = "vesting_as")]
        public string VestingAs { get; set; }

        [JsonProperty(PropertyName = "vesting_as_email")]
        public string VestingAsEmail { get; set; }

        [JsonProperty(PropertyName = "par_value")]
        public string ParValue { get; set; }

        [JsonProperty(PropertyName = "unit_count")]
        public string UnitCount { get; set; }
    }

    public class IssuerSignature
    {
        [JsonProperty(PropertyName = "signable_document_id")]
        public string SignableDocumentId { get; set; }

        [JsonProperty(PropertyName = "anchor_id")]
        public string AnchorId { get; set; }

        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

        [JsonProperty(PropertyName = "signed_at")]
        public string SignedAt { get; set; }

        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "ip_address")]
        public string IPAddress { get; set; }

        [JsonProperty(PropertyName = "literal")]
        public string Literal { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty(PropertyName = "auto_signed")]
        public bool AutoSigned { get; set; }
    }
}