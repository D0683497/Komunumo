using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Models.CommonViewModels;
using Komunumo.Admin.Models.ManageViewModels;
using Komunumo.Admin.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Komunumo.Admin.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserRepository(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<PaginatedList<UserViewModel>> GetUsersAsync(int currentPageNumber, int pageSize)
        {
            var users = await _userManager.Users.Skip((currentPageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            var count = await _userManager.Users.CountAsync();

            var items = _mapper.Map<List<ApplicationUser>, List<UserViewModel>>(users);

            var result = new PaginatedList<UserViewModel>(items, count, currentPageNumber ,pageSize);

            return result;
        }

        public async Task<List<ApplicationUser>> SearchUsersAsync(string searchString)
        {
            var users = _userManager.Users as IQueryable<ApplicationUser>;

            var result = await users.Where(user => user.UserName.Contains(searchString) || user.Email.Contains(searchString)).ToListAsync();

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