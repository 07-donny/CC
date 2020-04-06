using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class UsersController : Controller
    {
        UserManager<User> _userManager;
        RoleManager<IdentityRole> _roleManager;
        public UsersController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
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
        public async Task<IActionResult> ModifyRoles(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;

            UserViewModel uvm = new UserViewModel();
            uvm.Id = user.Id;
            uvm.Email = user.Email;
            uvm.Roles = _userManager.GetRolesAsync(user).Result;

            ViewBag.Roles = _roleManager.Roles;
            return View(uvm);
        }

        [HttpPost]
        public async Task<IActionResult> ModifyRoles(string id, string[] SelectedRoles)
        {
            var user = _userManager.FindByIdAsync(id).Result;

            string[] allRoles = _roleManager.Roles.Select(r => r.Name).ToArray();

            foreach (string role in allRoles)
            {
                await _userManager.RemoveFromRoleAsync(user, role);
            }

            foreach (string role in SelectedRoles)
            {
               await _userManager.AddToRoleAsync(user, role);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _userManager.FindByIdAsync(id).Result;

            UserViewModel uvm = new UserViewModel();
            uvm.Id = user.Id;
            uvm.Email = user.Email;
            uvm.Roles = _userManager.GetRolesAsync(user).Result;

            return View(uvm);
        }

        public IActionResult Details(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var user = _userManager.FindByIdAsync(id).Result;

            UserViewModel uvm = new UserViewModel();
            uvm.Id = user.Id;
            uvm.Email = user.Email;
            uvm.Roles = _userManager.GetRolesAsync(user).Result;

            return View(uvm);
        }

        public async Task<IActionResult> DeleteAsync(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            await _userManager.DeleteAsync(user);

            return RedirectToAction("Index");
        }


    }
}