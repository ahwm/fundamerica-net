using Newtonsoft.Json;
using System.Collections.Generic;

namespace FundAmerica.Objects
{
    public class OfferingType : BaseObjectType
    {
        [JsonProperty(PropertyName = "accept_investments")]
        public bool? AcceptInvestments { get; set; }

        [JsonProperty(PropertyName = "accredited_investors")]
        public bool AccreditedInvestors { get; set; }

        [JsonProperty(PropertyName = "ach_deposit_amount")]
        public string ACHDepositAmount { get; set; }

        [JsonProperty(PropertyName = "ach_deposit_max_percent")]
        public string ACHDepositMaxPercent { get; set; }

        [JsonProperty(PropertyName = "ach_deposit_release_at")]
        public string ACHDepositReleaseAt { get; set; }

        [JsonProperty(PropertyName = "ach_limit")]
        public string ACHLimit { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "bank_wire_info")]
        public string BankWireInfo { get; set; }

        [JsonProperty(PropertyName = "can_disburse")]
        public bool CanDisburse { get; set; }

        [JsonProperty(PropertyName = "check_mailing_address")]
        public string CheckMailingAddress { get; set; }

        [JsonProperty(PropertyName = "check_mailing_instructions")]
        public string CheckMailingInstructions { get; set; }

        [JsonProperty(PropertyName = "closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty(PropertyName = "delay_aml_until_funds_received")]
        public bool DelayAMLUntilFundsReceived { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "eb5")]
        public bool EB5 { get; set; }

        [JsonProperty(PropertyName = "entity_url")]
        public string EntityUrl { get; set; }

        [JsonProperty(PropertyName = "entity_id")]
        public string EntityId { get; set; }

        [JsonProperty(PropertyName = "escrow_closes_at")]
        public string EscrowClosesAt { get; set; }

        [JsonProperty(PropertyName = "escrow_status")]
        public string EscrowStatus { get; set; }

        [JsonProperty(PropertyName = "escrow_term_days")]
        public int EscrowTermDays { get; set; }

        [JsonProperty(PropertyName = "funds_disbursable")]
        public string FundsDisbursable { get; set; }

        [JsonProperty(PropertyName = "funds_in_escrow")]
        public string FundsInEscrow { get; set; }

        [JsonProperty(PropertyName = "funds_invested")]
        public string FundsInvested { get; set; }

        [JsonProperty(PropertyName = "funds_received")]
        public string FundsReceived { get; set; }

        [JsonProperty(PropertyName = "funds_refunded")]
        public string FundsRefunded { get; set; }

        [JsonProperty(PropertyName = "funds_transfer_methods")]
        public List<string> FundsTransferMethods { get; set; }

        [JsonProperty(PropertyName = "funds_unavailable")]
        public string FundsUnavailable { get; set; }

        [JsonProperty(PropertyName = "investment_increment_amount")]
        public string InvestmentIncrementAmount { get; set; }

        [JsonProperty(PropertyName = "max_amount")]
        public string MaxAmount { get; set; }

        [JsonProperty(PropertyName = "max_investment_amount")]
        public string MaxInvestmentAmount { get; set; }

        [JsonProperty(PropertyName = "min_amount")]
        public string MinAmount { get; set; }

        [JsonProperty(PropertyName = "min_investment_amount")]
        public string MinInvestmentAmount { get; set; }

        [JsonProperty(PropertyName = "minimum_met")]
        public bool MinimumMet { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "non_accredited_investors")]
        public bool NonAccreditedInvestors { get; set; }

        [JsonProperty(PropertyName = "non_us_investors")]
        public bool NonUSInvestors { get; set; }

        [JsonProperty(PropertyName = "opened_at")]
        public string OpenedAt { get; set; }

        [JsonProperty(PropertyName = "payment_reference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// <para>506c, 506b, reg_a_t1, reg_a_t2, reg_s, 4a6, us_state, other</para>
        /// <para>The only value that affects functionality is selecting <c>506c</c> as it is the only kind of offering where the <see cref="InvestmentType.ConfirmAccreditation"/> parameter for investments is allowed.</para>
        /// </summary>
        [JsonProperty(PropertyName = "regulatory_exemption")]
        public string RegulatoryExemption { get; set; }

        [JsonProperty(PropertyName = "regulatory_exemption_details")]
        public string RegulatoryExemptionDetails { get; set; }

        [JsonProperty(PropertyName = "security_url")]
        public string SecurityUrl { get; set; }

        [JsonProperty(PropertyName = "send_emails")]
        public bool SendEmails { get; set; }

        /// <summary>
        /// debt or equity, default is equity
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "us_investors")]
        public bool USInvestors { get; set; }

        [JsonProperty(PropertyName = "us_states_only")]
        public List<string> USStatesOnly { get; set; }

        [JsonProperty(PropertyName = "use_broker_dealer_service")]
        public bool UseBrokerDealerService { get; set; }

        [JsonProperty(PropertyName = "use_escrow_service")]
        public bool UseEscrowService { get; set; }

        [JsonProperty(PropertyName = "use_kyc_service")]
        public bool UseKYCService { get; set; }

        [JsonProperty(PropertyName = "wire_details")]
        public WireDetailsType WireDetails { get; set; }
    }
}