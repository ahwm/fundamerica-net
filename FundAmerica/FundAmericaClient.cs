using FundAmerica.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FundAmerica
{
    public class FundAmericaClient : IDisposable
    {
        private readonly HttpClient httpClient;

        public FundAmericaClient(string key, string productName, string productVersion, bool useSandbox = false)
        {
            httpClient = new HttpClient();
            if (useSandbox)
                httpClient.BaseAddress = new Uri("https://sandbox.fundamerica.com/api/");
            else httpClient.BaseAddress = new Uri("https://apps.fundamerica.com/api/");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{key}:")));
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(productName, productVersion));
        }

        public async Task<ResponseType<OfferingType>> GetOfferingsAsync(int? per = null, int? page = null)
        {
            List<string> @params = new List<string>();
            if (per != null)
                @params.Add($"per={per}");
            if (page != null)
                @params.Add($"page={page}");
            var response = await httpClient.GetAsync($"offerings{(@params.Count > 0 ? $"?{String.Join("&", @params)}" : "")}");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<ResponseType<OfferingType>>();
        }

        public async Task<OfferingType> GetOfferingAsync(string id)
        {
            var response = await httpClient.GetAsync($"offerings/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<OfferingType>();
        }

        public async Task<OfferingType> CreateOfferingAsync(OfferingType offeringType)
        {
            var offeringData = JsonConvert.SerializeObject(offeringType, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            using (var content = new StringContent(offeringData, Encoding.UTF8, "application/json"))
            {
                var response = await httpClient.PostAsync("offerings", content);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                return await response.Content.ReadAsAsync<OfferingType>();
            }
        }

        public async Task<OfferingType> UpdateOfferingAsync(OfferingType offeringType)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(offeringType, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }), Encoding.UTF8, "application/json"))
            using (var request = new HttpRequestMessage(new HttpMethod("PATCH"), $"offerings/{offeringType.Id}")
            {
                Content = content
            })
            {
                
                var response = await httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                return await response.Content.ReadAsAsync<OfferingType>();
            }
        }

        public async Task<ResponseType<EntityType>> GetEntitiesAsync(int? per = null, int? page = null)
        {
            List<string> @params = new List<string>();
            if (per != null)
                @params.Add($"per={per}");
            if (page != null)
                @params.Add($"page={page}");
            var response = await httpClient.GetAsync($"entities{(@params.Count > 0 ? $"?{String.Join("&", @params)}" : "")}");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<ResponseType<EntityType>>();
        }

        public async Task<EntityType> GetEntityAsync(string id)
        {
            var response = await httpClient.GetAsync($"entities/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<EntityType>();
        }

        public async Task<EntityType> CreateEntityAsync(EntityType entityType)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(entityType, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }), Encoding.UTF8, "application/json"))
            {
                var response = await httpClient.PostAsync("entities", content);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                return await response.Content.ReadAsAsync<EntityType>();
            }
        }

        public async Task<EntityType> UpdateEntityAsync(EntityType entityType)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(entityType, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }), Encoding.UTF8, "application/json"))
            using (var request = new HttpRequestMessage(new HttpMethod("PATCH"), $"entities/{entityType.Id}")
            {
                Content = content
            })
            {
                var response = await httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                return await response.Content.ReadAsAsync<EntityType>();
            }
        }

        public async Task<ResponseType<InvestmentType>> GetInvestmentsAsync(int? per = null, int? page = null)
        {
            List<string> @params = new List<string>();
            if (per != null)
                @params.Add($"per={per}");
            if (page != null)
                @params.Add($"page={page}");
            var response = await httpClient.GetAsync($"investments{(@params.Count > 0 ? $"?{String.Join("&", @params)}" : "")}");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<ResponseType<InvestmentType>>();
        }

        public async Task<InvestmentType> GetInvestmentAsync(string id)
        {
            var response = await httpClient.GetAsync($"investments/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<InvestmentType>();
        }

        public async Task<ResponseType<InvestmentType>> GetOfferingInvestmentsAsync(string id)
        {
            var response = await httpClient.GetAsync($"offerings/{id}/investments");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<ResponseType<InvestmentType>>();
        }

        public async Task<InvestmentType> CreateInvestmentAsync(InvestmentRequest investmentType)
        {
            string invData = JsonConvert.SerializeObject(investmentType, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            using (var content = new StringContent(invData, Encoding.UTF8, "application/json"))
            {
                var response = await httpClient.PostAsync("investments", content);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                return await response.Content.ReadAsAsync<InvestmentType>();
            }
        }

        public async Task<InvestmentType> UpdateInvestmentAsync(string investmentId, string agreementId)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(new { subscription_agreement_id = agreementId }, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }), Encoding.UTF8, "application/json"))
            using (var request = new HttpRequestMessage(new HttpMethod("PATCH"), $"investments/{investmentId}")
            {
                Content = content
            })
            {
                var response = await httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                return await response.Content.ReadAsAsync<InvestmentType>();
            }
        }

        public async Task CancelInvestmentAsync(string id)
        {
            using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), $"investments/{id}"))
            {
                var response = await httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
            }
        }

        public async Task<ResponseType<SubscriptionAgreement>> GetSubscriptionAgreementsAsync(int? per = null, int? page = null)
        {
            List<string> @params = new List<string>();
            if (per != null)
                @params.Add($"per={per}");
            if (page != null)
                @params.Add($"page={page}");
            var response = await httpClient.GetAsync($"subscription_agreements{(@params.Count > 0 ? $"?{String.Join("&", @params)}" : "")}");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<ResponseType<SubscriptionAgreement>>();
        }

        public async Task<SubscriptionAgreement> GetSubscriptionAgreementAsync(string id)
        {
            var response = await httpClient.GetAsync($"subscription_agreements/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<SubscriptionAgreement>();
        }

        public async Task<SubscriptionAgreement> CreateSubscriptionAgreement(SubscriptionRequest subData)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(subData, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }), Encoding.UTF8, "application/json"))
            {
                var response = await httpClient.PostAsync("subscription_agreements", content);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                return await response.Content.ReadAsAsync<SubscriptionAgreement>();
            }
        }

        public async Task<ElectronicSignature> UpdateSignatureAsync(ElectronicSignature signature)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(signature, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }), Encoding.UTF8, "application/json"))
            using (var request = new HttpRequestMessage(new HttpMethod("PATCH"), $"electronic_signatures/{signature.Id}")
            {
                Content = content
            })
            {
                var response = await httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                return await response.Content.ReadAsAsync<ElectronicSignature>();
            }
        }

        public async Task<ACHAuthorization> CreateACHAuthorizationAsync(ACHAuthorizationRequest subData)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(subData, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }), Encoding.UTF8, "application/json"))
            {
                var response = await httpClient.PostAsync("ach_authorizations", content);
                if (!response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                    throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                return await response.Content.ReadAsAsync<ACHAuthorization>();
            }
        }

        public async Task<Dictionary<string, string>> GetAgreementTextAsync()
        {
            var response = await httpClient.GetAsync("ach_authorizations/agreement_html");
            if (!response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<Dictionary<string, object>>();
                throw new Exception(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
            return await response.Content.ReadAsAsync<Dictionary<string, string>>();
        }

        public void Dispose()
        {
            httpClient.Dispose();
        }
    }
}