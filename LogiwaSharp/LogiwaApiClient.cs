using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LogiwaSharp.Dto;
using Newtonsoft.Json;

namespace LogiwaSharp
{
    public class LogiwaApiClient
    {
        public string BaseUri;
        public string AccessToken;

        public LogiwaApiClient(string baseUri, string accessToken)
        {
            BaseUri = baseUri;
            AccessToken = accessToken;
        }

        public async Task<T> ExecuteAsync<T>(HttpMethod method, string requestUrl, object data = null)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + AccessToken);
                var requestMessage = new HttpRequestMessage(method, $"{BaseUri}{requestUrl}");
                if (data != null)
                {
                    var json = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                }

                var response = await client.SendAsync(requestMessage);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    var exception = JsonConvert.DeserializeObject<LogiwaException>(result);
                    exception.ApiResponse = result;
                    exception.StatusCode = response.StatusCode;
                    throw exception;
                }

                var responseObj = JsonConvert.DeserializeObject<T>(result);
                return responseObj;
            }
        }
    }
}
