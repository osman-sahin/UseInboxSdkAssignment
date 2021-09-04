using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;
using UseInboxSdkAssignment.Models.ResultModels;

namespace UseInboxSdkAssignment.Services.NewsletterService
{
    public class NewsletterService : INewsletterService
    {
        public Task<ListNewsletterResultModel> GetAll(string token)
        {
            var client = new RestClient("https://useapi.useinbox.com/inbox/v1/newsletters");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("authorization", "Bearer " + token);
            var body = @"";
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = Task.FromResult(JsonConvert.DeserializeObject<ListNewsletterResultModel>(response.Content));
                return result;
            }
            else
            {
                var failResponse = JsonConvert.DeserializeObject<BaseResultModel>(response.Content);
                throw new Exception(failResponse.ResultMessage);
            }
        }
    }
}
