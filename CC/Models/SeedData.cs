using CC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Carrot Icecream",
                        Price = 1.99f,
                        Category = "Icecream",
                        Description = "A delicious frozen carrot",
                        Rarity ="Common",
                    },

                    new Product
                    {
                        Name = "Veggie Hotdog",
                        Price = 3.99f,
                        Category = "Snack",
                        Description = "It's just a carrot in a bun, really",
                        Rarity = "Common",
                    },

                    new Product
                    {
                        Name = "Carrot Juice",
                        Price = 2.99f,
                        Category = "Drinks",
                        Description = "Great for the eyes",
                        Rarity = "Common",
                    },

                    new Product
                    {
                        Name = "Pointy Carrot",
                        Price = 0.99f,
                        Category = "Veggies",
                        Description = "Careful, don't poke your eye out!",
                        Rarity = "Boring",
                    },

                    new Product
                    {
                        Name = "UV Mega Carrot",
                        Price = 199.99f,
                        Category = "Radioactive Foods",
                        Description = "Disclaimer: Wear sunglasses while eating",
                        Rarity = "Legendary",
                    },

                    new Product
                    {
                        Name = "Japanese Carrot",
                        Price = 69.99f,
                        Category = "Veggies",
                        Description = "Also goes by the name Kakarot",
                        Rarity = "Rare",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
