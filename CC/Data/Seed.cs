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
            //Create Roles
            if(roleManager.FindByNameAsync("Player").Result == null)
            {
                IdentityRole playerRole = new IdentityRole("Player");
                roleManager.CreateAsync(playerRole).Wait();
            }

            if (roleManager.FindByNameAsync("Moderator").Result == null)
            {
                IdentityRole moderatorRole = new IdentityRole("Moderator");
                roleManager.CreateAsync(moderatorRole).Wait();
            }

            if (roleManager.FindByNameAsync("Admin").Result == null)
            {
                IdentityRole role = new IdentityRole { Name = "Admin" };
                roleManager.CreateAsync(role).Wait();
            }


            //Create standard Player user
            if (userManager.FindByEmailAsync("player@CC.com").Result == null)
            {
                User user = new User
                {
                    UserName = "player@CC.com",
                    Email = "player@CC.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Player").Wait();
                }
            }

            //Create standard Moderator user
            if (userManager.FindByEmailAsync("moderator@CC.com").Result == null)
            {
                User user = new User
                {
                    UserName = "moderator@CC.com",
                    Email = "moderator@CC.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Moderator").Wait();
                }
            }

            //Create standard Admin user
            if (userManager.FindByEmailAsync("admin@CC.com").Result == null)
            {
                User user = new User
                {
                    UserName = "admin@CC.com",
                    Email = "admin@CC.com"
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
