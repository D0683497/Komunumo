using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Diagnostics;
using Komunumo.Blog.Models;

namespace Komunumo.Blog.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly UserManager<BlogUser> _userManager;
        private readonly SignInManager<BlogUser> _signInManger;

        public HomeController(
            UserManager<BlogUser> userManager,
            SignInManager<BlogUser> signInManager)
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
            if (username == null)
            {
                return View();
            }
            //login functionality
            var user = await _userManager.FindByNameAsync(username);

            if (user != null)
            {
                //sign in
                var signInResult = await _signInManger.PasswordSignInAsync(user, password, false, false);

                if (signInResult.Succeeded)
                {
                    return Redirect("/BlogPage/Index");
                }
            }
            return View();
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
        public async Task<IActionResult> Register(string password, [Bind("UserName,Email,PhoneNumber,Department,Degree,College")]BlogUser blogUser )
        {
            //Register functionality

            var result = await _userManager.CreateAsync(blogUser, password);

            System.Diagnostics.Debug.WriteLine(result);
            if (result.Succeeded)
            {
                //sign in
                var signInResult = await _signInManger.PasswordSignInAsync(blogUser, password, false, false);

                if (signInResult.Succeeded)
                {
                    return Redirect("/BlogPage/Index");
                }
            }

            return View();
        }
        #endregion

        #region LogOut
        public async Task<IActionResult> LogOut()
        {
            await _signInManger.SignOutAsync();

            return Redirect("/BlogPage/Index");
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
