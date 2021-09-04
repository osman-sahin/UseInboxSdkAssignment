using System.Threading.Tasks;
using UseInboxSdkAssignment.Models.ResultModels;

namespace UseInboxSdkAssignment.Services.ContactListService
{
    public interface IContactListService
    {
        Task<ContactListResultModel> GetAll(string token);
    }
}
