using System.Linq;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Komunumo.Admin.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
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