using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "elyamine",
                    Email = "elyamine@gmail.com"
                };
                
                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }
            if(context.Products.Any()) return;
            
            var products = new List<Product>{
                new Product
                {
                    Name = "Cable 6mm cuiver",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/auto-1.png",
                    Brand = "Italy",
                    Type = "Cable",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Cable 8mm cuiver",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/auto-2.jpeg",
                    Brand = "Italy",
                    Type = "Cable",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ram-stage1",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/auto-3.jpg",
                    Brand = "Italy",
                    Type = "Ema1",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tendeur-A1 ",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/auto-4.jpg",
                    Brand = "Germany",
                    Type = "Tend1",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tendeur-A2",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/auto-5.png",
                    Brand = "Germany",
                    Type = "Tend1",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tendeur-A3",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/auto-6.jpg",
                    Brand = "Germany",
                    Type = "Tend2",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ram-stage2",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/auto-7.png",
                    Brand = "china",
                    Type = "Rooc",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ram-lp",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/auto-8.jpg",
                    Brand = "China",
                    Type = "Rooc",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Full kit lpg",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/auto-9.jpg",
                    Brand = "Italy",
                    Type = "Eurolp",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Full kit lpg-ch",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/auto-10.jpg",
                    Brand = "China",
                    Type = "Ema1",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tank soupap-A1",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/auto-11.jpg",
                    Brand = "Italy",
                    Type = "Eurolp",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tank soupap-A2",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/auto-12.jpg",
                    Brand = "China",
                    Type = "Ema1",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Injecteurs lpg",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/auto-13.jpg",
                    Brand = "Italy",
                    Type = "Eurolp",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Switch fuel",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/auto-14.jpg",
                    Brand = "Italy",
                    Type = "Eurolp",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ram-Stage 2",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/auto-15.png",
                    Brand = "Germany",
                    Type = "Tend2",
                    QuantityInStock = 100
                },
                
            };
            foreach(var product in products){
                context.Products.Add(product);
            }
         // context.Products.RemoveRange(context.Products);
            context.SaveChanges();
        }
    }
}