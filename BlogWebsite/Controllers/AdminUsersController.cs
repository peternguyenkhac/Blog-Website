using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogWebsite.Models;
using BlogWebsite.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace BlogWebsite.Controllers
{
    
    public class AdminUsersController : Controller
    {
        private readonly UsersService _usersService;

        public AdminUsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [Authorize(Roles = "Admin")]
        [Route("Admin/Users")]
        public async Task<IActionResult> Index()
        {
            var users = _usersService.GetUsers();
            return View(users);
        }

        [Authorize]
        [Route("Admin/Profile/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            int authorId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if(authorId == id)
            {
                var user = _usersService.DetailsUser(id);
                return View(user);
            }

            return Redirect($"/Admin/Profile/{authorId}");
        }

        [Authorize]
        [HttpPost]
        [Route("Admin/Profile/{id}")]
        public async Task<IActionResult> Details([Bind("Id,UserName,UserEmail,UserLogin")]User updateUser)
        {
            
            int authorId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if(authorId == updateUser.Id)
            {
                TempData["Message"] = "Sửa thông tin thành công";
                _usersService.ChangeProfile(updateUser);
            }
            return Redirect($"/Admin/Profile/{updateUser.Id}");
        }

        [Authorize]
        [HttpPost]
        [Route("Admin/ChangePassword")]
        public async Task<IActionResult> ChangePassword(int id, string oldPassword, string newPassword)
        {
            int authorId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if(authorId == id && _usersService.CheckPassWord(id, oldPassword))
            {
                TempData["Message"] = "Đổi mật khẩu thành công";
                _usersService.ChangePassword(id, newPassword);
            }
            return Redirect($"/Admin/Profile/{id}");
        }

        [AllowAnonymous]
        [Route("Admin/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Admin/Login")]
        public IActionResult Login(string name, string password)
        {
            var user = _usersService.Login(name, password);
            if (user == null)
            {
                return BadRequest("Sai thong tin dang nhap");
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.UserRole.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            var authProperties = new AuthenticationProperties { };
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authProperties);
            TempData["Message"] = "Đăng nhập thành công";
            return Redirect("/Admin/Articles");
        }

        [Authorize]
        [Route("Admin/Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Admin/Login");
        }

        [Authorize(Roles = "Admin")]
        [Route("Admin/CreateUser")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("Admin/CreateUser")]
        public async Task<IActionResult> Create([Bind("UserName,UserEmail,UserLogin,UserPassword,UserRole")] User user)
        {
            _usersService.CreateUser(user);
            TempData["Message"] = "Thêm người viết thành công";
            return Redirect("/Admin/Users");
        }


        [Authorize(Roles = "Admin")]
        [Route("Admin/EditUser/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var user = _usersService.DetailsUser(id);
            return View(user);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("Admin/EditUser/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,UserEmail,UserLogin,UserPassword,UserRole")] User updateUser)
        {

           _usersService.UpdateUser(updateUser);
            TempData["Message"] = "Sửa thông tin thành công";
            return Redirect("/Admin/Users");
        }

        [Authorize(Roles = "Admin")]
        [Route("Admin/DeleteUser/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _usersService.DeleteUser(id);
            TempData["Message"] = "Xoá thành công";
            return Redirect("/Admin/Users");
        }

    }
}
