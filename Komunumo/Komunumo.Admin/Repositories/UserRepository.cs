using System.Linq;
using System.Threading.Tasks;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Models.Common;
using Komunumo.Admin.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Komunumo.Admin.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<PaginatedList<ApplicationUser>> GetUsersAsync(int currentPageNumber, int pageSize)
        {
            var users = _userManager.Users as IQueryable<ApplicationUser>;

            var result = await PaginatedList<ApplicationUser>.CreateAsync(users.AsNoTracking(), currentPageNumber, pageSize);

            return result;
        }

        #region Exists

        public bool ExistsUserName(string userName)
        {
            return _userManager.Users.Any(user => user.UserName.Equals(userName));
        }

        public bool ExistsEmail(string email)
        {
            return _userManager.Users.Any(user => user.Email.Equals(email));
        }

        public bool ExistsPhoneNumber(string phoneNumber)
        {
            return _userManager.Users.Any(user => user.PhoneNumber.Equals(phoneNumber));
        }

        #endregion
    }
}