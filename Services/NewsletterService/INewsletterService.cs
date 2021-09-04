using System.Threading.Tasks;
using UseInboxSdkAssignment.Models.ResultModels;

namespace UseInboxSdkAssignment.Services.NewsletterService
{
    public interface INewsletterService
    {
        Task<ListNewsletterResultModel> GetAll(string token);
    }
}
