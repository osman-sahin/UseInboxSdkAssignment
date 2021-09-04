using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;
using UseInboxSdkAssignment.Models.ResultModels;

namespace UseInboxSdkAssignment.Services.ContactListService
{
    public class ContactListService : IContactListService
    {
        public Task<ContactListResultModel> GetAll(string token)
        {
            var client = new RestClient("https://useapi.useinbox.com/inbox/v1/contactlists");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("authorization", "Bearer " + token);
            var body = @"";
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = Task.FromResult(JsonConvert.DeserializeObject<ContactListResultModel>(response.Content));
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
