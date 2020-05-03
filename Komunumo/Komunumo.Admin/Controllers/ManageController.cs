using System.Threading.Tasks;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Komunumo.Admin.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class ManageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepository;

        public ManageController(IUserRepository userRepository, UserManager<ApplicationUser> userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }

        #region Index

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region User

        [HttpGet]
        public async Task<IActionResult> Users(int? currentPageNumber, int? pageSize)
        {
            var users = await _userRepository.GetUsersAsync(currentPageNumber ?? 1, pageSize ?? 5);

            return View(users);
        }

        #endregion
    }
}