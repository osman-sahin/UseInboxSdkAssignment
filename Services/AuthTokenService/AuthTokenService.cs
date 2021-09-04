using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;
using UseInboxSdkAssignment.Models.ResultModels;

namespace UseInboxSdkAssignment.Services.AuthTokenService
{
    public class AuthTokenService : IAuthTokenService
    {
        public Task<AuthTokenResultModel> GetAccessToken(string username, string password)
        {
            var client = new RestClient("https://useapi.useinbox.com/token/");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{'EmailAddress':" + $"'{username}'" + ", 'Password': "+ $"'{password}'" + "}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = Task.FromResult(JsonConvert.DeserializeObject<AuthTokenResultModel>(response.Content));
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
