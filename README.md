# FundAmerica for .NET

API Docs: https://docs.fundamerica.com/

Sandbox: https://my-sandbox.fundamerica.com/

## Usage

```csharp
string key = "api-key";
bool useSandbox = true;
var client = new FundAmericaClient(key, useSandbox);
var offering = await client.CreateOfferingAsync(new OfferingType
{
    Name = content.Name,
    AccreditedInvestors = true,
    Amount = amount,
    EntityId = issuerId,
    MaxAmount = maxAmount,
    RegulatoryExemption = "us_state",
    RegulatoryExemptionDetails = "-",
    MinAmount = minAmount,
    EscrowClosesAt = "2022-10-10",
    EscrowTermDays = 35,
    MinInvestmentAmount = minInvestmentAmount,
    FundsTransferMethods = new List<string>
    {
        "ach",
        "wire",
        "check"
    },
    Type = "equity",
    NonUSInvestors = true,
    USInvestors = true,
    NonAccreditedInvestors = true,
    UseBrokerDealerService = false
});
```

## Contributing

Pull requests are welcome. Some features aren't built as this started as an integration for a client and those features weren't in use.
