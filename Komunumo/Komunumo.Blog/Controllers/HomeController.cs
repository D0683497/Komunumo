using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Diagnostics;
using Komunumo.Blog.Models;

namespace Komunumo.Blog.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManger;

        public HomeController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManger = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Login
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            //login functionality
            var user = await _userManager.FindByNameAsync(username);

            if (user != null)
            {
                //sign in
                var signInResult = await _signInManger.PasswordSignInAsync(user, password, false, false);

                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            return View();
        }
        #endregion


        #region Register
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(string username, string password)
        {
            //Register functionality
            var user = new IdentityUser
            {
                UserName = username,
                Email = "",
            };

            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                //sign in
                var signInResult = await _signInManger.PasswordSignInAsync(user, password, false, false);

                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");

        }
        #endregion

        /*[Authorize]
        public IActionResult Secret()
        {
            return View();
        }
        */
        #region LogOut
        public async Task<IActionResult> LogOut()
        {
            await _signInManger.SignOutAsync();

            return RedirectToAction("Index");
        }
        #endregion

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
