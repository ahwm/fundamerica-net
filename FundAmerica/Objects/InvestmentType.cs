using Newtonsoft.Json;
using System.Collections.Generic;

namespace FundAmerica.Objects
{
    public class InvestmentType : BaseObjectType
    {
        [JsonProperty(PropertyName = "offering_url")]
        public string OfferingUrl { get; set; }

        [JsonProperty(PropertyName = "offering_id")]
        public string OfferingId { get; set; }

        [JsonProperty(PropertyName = "ach_authorization_id")]
        public string ACHAuthorizationId { get; set; }

        [JsonProperty(PropertyName = "administration_fee")]
        public string AdministrationFee { get; set; }

        [JsonProperty(PropertyName = "aml_check_investor")]
        public bool AMLCheckInvestor { get; set; }

        [JsonProperty(PropertyName = "aml_exception")]
        public bool AMLException { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "amount_in_escrow")]
        public string AmountInEscrow { get; set; }

        [JsonProperty(PropertyName = "amount_received")]
        public string AmountReceived { get; set; }

        [JsonProperty(PropertyName = "amount_refunded")]
        public string AmountRefunded { get; set; }

        [JsonProperty(PropertyName = "background_check_url")]
        public string BackgroundCheckUrl { get; set; }

        [JsonProperty(PropertyName = "bank_reference")]
        public string BankReference { get; set; }

        [JsonProperty(PropertyName = "bank_wire_info")]
        public string BankWireInfo { get; set; }

        [JsonProperty(PropertyName = "brokerage_fee")]
        public string BrokerageFee { get; set; }

        [JsonProperty(PropertyName = "ceremonial_certificate_url")]
        public string CeremonialCertificateUrl { get; set; }

        [JsonProperty(PropertyName = "check_mailing_address")]
        public string CheckMailingAddress { get; set; }

        [JsonProperty(PropertyName = "check_mailing_instructions")]
        public string CheckMailingInstructions { get; set; }

        [JsonProperty(PropertyName = "cleared")]
        public bool Cleared { get; set; }

        [JsonProperty(PropertyName = "clearing_failures")]
        public List<string> ClearingFailures { get; set; }

        [JsonProperty(PropertyName = "commission_fee")]
        public string CommissionFee { get; set; }

        [JsonProperty(PropertyName = "concession_fee")]
        public string ConcessionFee { get; set; }

        [JsonProperty(PropertyName = "confirm_accreditation")]
        public string ConfirmAccreditation { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, object> Data { get; set; }

        [JsonProperty(PropertyName = "debt_face_value")]
        public string DebtFaceValue { get; set; }

        [JsonProperty(PropertyName = "debt_interest_rate")]
        public string DebtInterestRate { get; set; }

        [JsonProperty(PropertyName = "debt_maturity_date")]
        public string DebtMaturityRate { get; set; }

        [JsonProperty(PropertyName = "debt_par_value")]
        public string DebtParValue { get; set; }

        [JsonProperty(PropertyName = "disbursed_at")]
        public string DisbursedAt { get; set; }

        [JsonProperty(PropertyName = "entity_url")]
        public string EntityUrl { get; set; }

        [JsonProperty(PropertyName = "entity_id")]
        public string EntityId { get; set; }

        [JsonProperty(PropertyName = "equity_share_count")]
        public string EquityShareCount { get; set; }

        [JsonProperty(PropertyName = "equity_share_price")]
        public string EquitySharePrice { get; set; }

        [JsonProperty(PropertyName = "face_value")]
        public string FaceValue { get; set; }

        [JsonProperty(PropertyName = "financial_adviser_name")]
        public string FinancialAdvisorName { get; set; }

        [JsonProperty(PropertyName = "funds_disbursable")]
        public decimal FundsDisbursable { get; set; }

        [JsonProperty(PropertyName = "funds_transfer_method")]
        public string FundsTransferMethod { get; set; }

        [JsonProperty(PropertyName = "in_escrow_at")]
        public string InEscrowAt { get; set; }

        [JsonProperty(PropertyName = "incomplete")]
        public bool Incomplete { get; set; }

        [JsonProperty(PropertyName = "incomplete_reason")]
        public string IncompleteReason { get; set; }

        [JsonProperty(PropertyName = "investor_url")]
        public string InvestorUrl { get; set; }

        [JsonProperty(PropertyName = "kyc_by_client")]
        public bool KYCByClient { get; set; }

        [JsonProperty(PropertyName = "par_value")]
        public string ParValue { get; set; }

        [JsonProperty(PropertyName = "payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty(PropertyName = "payment_reference")]
        public string PaymentReference { get; set; }

        [JsonProperty(PropertyName = "promo_code")]
        public string PromoCode { get; set; }

        [JsonProperty(PropertyName = "referrer")]
        public string Referrer { get; set; }

        [JsonProperty(PropertyName = "refunded_at")]
        public string RefundedAt { get; set; }

        [JsonProperty(PropertyName = "remittance_details")]
        public WireDetailsType RemittanceDetails { get; set; }

        [JsonProperty(PropertyName = "review_trade")]
        public bool ReviewTrade { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "subscription_agreement_id")]
        public string SubscriptionAgreementId { get; set; }

        [JsonProperty(PropertyName = "external_subscription_agreement")]
        public string ExternalSubscriptionAgreement { get; set; }

        [JsonProperty(PropertyName = "subscription_agreement_url")]
        public string SubscriptionAgreementUrl { get; set; }

        [JsonProperty(PropertyName = "title_iii_invested_in_last_year")]
        public string TitleIIIInvestedInLastYear { get; set; }

        [JsonProperty(PropertyName = "trade_review_status")]
        public string TradeReviewStatus { get; set; }

        [JsonProperty(PropertyName = "trade_review_url")]
        public string TradeReviewUrl { get; set; }

        [JsonProperty(PropertyName = "unit_count")]
        public string UnitCount { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "wire_details")]
        public WireDetailsType WireDetails { get; set; }
    }

    public class InvestmentRequest
    {
        [JsonProperty(PropertyName = "ach_authorization_id")]
        public string ACHAuthorizationId { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "entity_id")]
        public string EntityId { get; set; }

        [JsonProperty(PropertyName = "equity_share_count")]
        public string EquityShareCount { get; set; }

        [JsonProperty(PropertyName = "offering_id")]
        public string OfferingId { get; set; }

        [JsonProperty(PropertyName = "payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty(PropertyName = "subscription_agreement_id")]
        public string SubscriptionAgreementId { get; set; }
    }
}