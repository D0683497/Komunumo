using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Komunumo.Admin.Controllers
{
    [Authorize]
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
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region User

        [HttpGet]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> Users(int? currentPageNumber)
        {
            int pageSize = 5;
            var users = await _userRepository.GetUsersAsync(currentPageNumber ?? 1, pageSize);

            return View(users);
        }

        [HttpGet]
        [Route("[controller]/Users/Details/{id?}")]
        public async Task<IActionResult> UserDetails(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpGet]
        [Route("[controller]/Users/Edit/{id?}")]
        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        #endregion
    }
}