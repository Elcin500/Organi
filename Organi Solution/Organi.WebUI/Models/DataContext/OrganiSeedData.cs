using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Organi.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.Models.DataContext
{
    static public class OrganiSeedData
    {
        static public IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope=app.ApplicationServices.CreateScope())
            {
               var db= scope.ServiceProvider.GetRequiredService<OrganiDbContext>();

                db.Database.Migrate(); //update -database


                InitCategories(db);

               // InitProducts(db);

                InitAppInfo(db);

               // InitPost(db);
            }

            return app;
        }

        private static void InitPost(OrganiDbContext db)
        {
            //if (!db.Posts.Any())
            //{
            //    var category
            //    for (int i = 1; i <=6 ; i++)
            //    {
            //        db.Posts.Add(new Post
            //        {
            //            ImagePath = $"blog-{i}.jpg",
            //            Name = $"{i}Sed porttitor lectus nibh. Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui. Curabitur",
            //            Body= " Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Sed porttitor lectus nibh. Donec sollicitudin molestie malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Donec sollicitudin molestie malesuada. Nulla quis lorem ut libero malesuada feugiat. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem.",
            //            Author="Elcin"
            //        });
            //    }
            //    db.SaveChanges();
            //}
        }

        private static void InitAppInfo(OrganiDbContext db)
        {
            if (!db.AppInfos.Any())
            {
                db.AppInfos.Add(new AppInfo { 
                AppTitle="Organi",
                Address="Address: 60-49 Road 11378 New York",
                Email="info@organi.az",
                Phone="+994 50 245 44 44",
                LogoPath="logo.png",
                HashTag="#developerleri#qoruyaq",
                FacebookLink="http://facebook.com",
                InstagramLink = "http://instagram.com",
                TwitterLink= "http://twitter.com",
                OpenTime="10:00 am to 23:00 pm"
                
                });
                db.SaveChanges();
            }
        }

        private static void InitProducts(OrganiDbContext db)
        {

            if (!db.Products.Any())
            {
                for (int i = 1; i <= 12; i++)
                {

                    int categoryId = 1;
                    if (i%2==0)
                    {
                        categoryId = 2;
                    }
                    else if (i%3==0)
                    {
                        categoryId = 3;
                    }

                    var product = new Product
                    {
                        CategoryId = categoryId,
                        Name = $"{i}Vetgetable’s Package",
                        price = (5+i),
                        Quantity = 1,
                        Unit = "kq",
                        ShortDescription = $"{i}Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui. Sed porttitor lectus nibh. Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui. Proin eget tortor risus."
                    };

                    product.Images = new List<ProductImage>();
                    product.Images.Add(new ProductImage { 
                    IsMain=true,
                    Path=$"product-{i}.jpg"
                   //ProductId=product.Id Bu avtamatik goturulur
                    });
                    product.Images.Add(new ProductImage
                    {
                        IsMain = false,
                        Path = "thumb-1.jpg"
                    });
                    product.Images.Add(new ProductImage
                    {
                        IsMain = false,
                        Path = "thumb-2.jpg"
                    });
                    product.Images.Add(new ProductImage
                    {
                        IsMain = false,
                        Path = "thumb-3.jpg"
                    });
                    product.Images.Add(new ProductImage
                    {
                        IsMain = false,
                        Path = "thumb-4.jpg"
                    });

                    db.Products.AddRange(product);
                }
               

                db.SaveChanges();
            }
        }

        private static void InitCategories(OrganiDbContext db)
        {
            if (!db.Categories.Any())
            {
                db.Categories.AddRange(new Category
                {
                    Name = "Fresh Fruit",
                    IsFeaturedFilter = true

                },
                new Category
                {
                    Name = "Dried Fruit",
                    IsFeaturedFilter = true


                },
                 new Category
                 {
                     Name = "Fastfood",
                     IsFeaturedFilter = true

                 },
                new Category
                {
                    Name = "Vegetables",
                    IsFeaturedFilter = true
                });

                db.SaveChanges();
            }
        }
    }
}
