using CC.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Data
{
    public class Seed
    {
        public static void SeedUsers(UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            if (roleManager.FindByNameAsync("Admin").Result == null)
            {
                IdentityRole role = new IdentityRole { Name = "Admin" };
                roleManager.CreateAsync(role).Wait();
            }

            if(userManager.FindByEmailAsync("admin@admin.com").Result == null)
            {
                User user = new User
                {
                    Username = "admin@admin.com",
                    Email = "admin@admin.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
