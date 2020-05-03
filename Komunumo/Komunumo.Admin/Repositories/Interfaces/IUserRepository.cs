using System.Threading.Tasks;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Models.Common;

namespace Komunumo.Admin.Repositories.Interfaces
{
    public interface IUserRepository
    {

        Task<PaginatedList<ApplicationUser>> GetUsersAsync(int currentPageNumber, int pageSize);

        #region Exists

        bool ExistsUserName(string userName);

        bool ExistsEmail(string email);

        bool ExistsPhoneNumber(string phoneNumber);

        #endregion
    }
}