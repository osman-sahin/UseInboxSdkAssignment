using System.Threading.Tasks;
using UseInboxSdkAssignment.Models.ResultModels;

namespace UseInboxSdkAssignment.Services.AuthTokenService
{
    public interface IAuthTokenService
    {
        Task<AuthTokenResultModel> GetAccessToken(string username, string password);
    }
}
