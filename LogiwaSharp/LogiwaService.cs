using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LogiwaSharp.Dto;
using Newtonsoft.Json;

namespace LogiwaSharp
{
    public class LogiwaService
    {
        public readonly LogiwaApiClient ApiClient;

        public LogiwaService(string baseUri, string accessToken)
        {
            ApiClient = new LogiwaApiClient(baseUri, accessToken);
        }

        public void UpdateAccessToken(string accessToken)
        {
            ApiClient.AccessToken = accessToken;
        }

        public async Task<string> GenerateAccessToken(string username, string password)
        {
            var usernamePasswordList = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
            };

            using (var httpClient = new HttpClient())
            {
                using (var content = new FormUrlEncodedContent(usernamePasswordList))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    content.Headers.Add("grant_type", "password");

                    var response = await httpClient.PostAsync($"{ApiClient.BaseUri}token", content);
                    var result = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(result);
                    }

                    var token = JsonConvert.DeserializeObject<AuthResult>(result);
                    if (token != null)
                    {
                        ApiClient.AccessToken = token.AccessToken;
                        return token.AccessToken;
                    }

                    throw new Exception("Invalid Credentials : Unauthorized operation performed");
                }
            }
        }

        public async Task<LogiwaLookups> GetLookups()
        {
            return await ApiClient.ExecuteAsync<LogiwaLookups>(HttpMethod.Post, Consts.LogiwaLookupUrl);
        }

        public async Task<List<LogiwaProduct>> GetAllLogiwaProducts()
        {
            var products = new List<LogiwaProduct>();
            var filter = new ProductRequestFilter
            {
                SelectedPageIndex = 1,
                PageSize = 200,
            };
            while (true)
            {
                var allProducts = await ApiClient.ExecuteAsync<GetAllProducts>(HttpMethod.Post, Consts.LogiwaGetArticlesUrl, filter);
                products.AddRange(allProducts.Data);
                filter.SelectedPageIndex++;

                if (allProducts.Data.Length < 200) break;
            }
            return products;
        }

        public async Task<List<Stock>> GetAllLogiwaStock()
        {
            var stocks = new List<Stock>();
            var stockRequest = new StockRequest
            {
                SelectedPageIndex = 1,
                PageSize = 200
            };
            while (true)
            {
                var stockQueryResponse = await ApiClient.ExecuteAsync<StockResponse>(HttpMethod.Post, Consts.LogiwaInventoryUrl, stockRequest);
                stocks.AddRange(stockQueryResponse.Data);
                stockRequest.SelectedPageIndex++;

                if (stockQueryResponse.Data.Length < 200) break;
            }

            return stocks;
        }

        public async Task<List<Order>> GetAllLogiwaOrders(long warehouseId, DateTime lastSyncTime)
        {
            var orders = new List<Order>();
            var filter = new OrderRequestFilter
            {
                SelectedPageIndex = 1,
                PageSize = 200,
                WarehouseId = warehouseId,
                IsGetOrderDetails = true,
                LastModifiedDateStart = lastSyncTime.AddHours(-6).ToString("MM.dd.yyyy HH:mm:ss")
            };
            while (true)
            {
                var allOrders = await ApiClient.ExecuteAsync<GetOrderResponse>(HttpMethod.Post, Consts.LogiwaGetOrdersUrl, filter);
                orders.AddRange(allOrders.Data);
                filter.SelectedPageIndex++;

                if (allOrders.Data.Length < 200) break;
            }
            return orders;
        }
    }
}
