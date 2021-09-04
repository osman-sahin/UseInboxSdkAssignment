using System.Threading.Tasks;
using UseInboxSdkAssignment.Models.ResultModels;
using UseInboxSdkAssignment.Services.AuthTokenService;
using UseInboxSdkAssignment.Services.ContactListService;
using UseInboxSdkAssignment.Services.NewsletterService;

namespace UseInboxSdkAssignment
{
    public class InboxSdk
    {
        private readonly string accessToken;

        public InboxSdk(string username, string password)
        {
            accessToken = GetAccessToken(username, password).Result;
        }

        public async Task<ListNewsletterResultModel> GetNewsletters()
        {
            INewsletterService newsletterService = new NewsletterService();
            var response = await newsletterService.GetAll(accessToken);
            return response; 
        }

        public async Task<ContactListResultModel> GetContactLists()
        {
            IContactListService contactListService = new ContactListService();
            var response = await contactListService.GetAll(accessToken);
            return response;
        }

        internal async Task<string> GetAccessToken(string username, string password)
        {
            IAuthTokenService authTokenService = new AuthTokenService();
            var response = await authTokenService.GetAccessToken(username, password);

            return response.ResultObject.Access_Token;
        }

    }
}
