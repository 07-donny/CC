using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        UserManager<User> _userManager;
        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
           var users = _userManager.Users;

            List<UserViewModel> userVM = new List<UserViewModel>();
            foreach (User user in users)
            {
                UserViewModel uvm = new UserViewModel();
                uvm.Id = user.Id;
                uvm.Email = user.Email;
                uvm.Roles = _userManager.GetRolesAsync(user).Result;

                userVM.Add(uvm);
            }

           return View(userVM);
        }

        //public IActionResult Delete(string id)
        //{

        //}
    }
}