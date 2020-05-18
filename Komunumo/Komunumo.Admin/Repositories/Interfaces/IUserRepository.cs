using System.Threading.Tasks;
using Komunumo.Admin.Models.CommonViewModels;
using Komunumo.Admin.Models.ManageViewModels;

namespace Komunumo.Admin.Repositories.Interfaces
{
    public interface IUserRepository
    {

        Task<PaginatedList<UserViewModel>> GetUsersAsync(int currentPageNumber, int pageSize);

        #region Exists

        bool ExistsUserName(string userName);

        bool ExistsEmail(string email);

        bool ExistsPhoneNumber(string phoneNumber);

        #endregion
    }
}