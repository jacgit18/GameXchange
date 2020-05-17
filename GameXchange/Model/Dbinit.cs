using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Model
{
    public class Dbinit
    { 
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //ApplicationDbContext context =
            //    applicationBuilder.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            //if (!context.GameCategory.Any())
            //{
            //    context.GameCategory.AddRange(Categories.Select(c => c.Value));
            //}

            //if (!context.GameInfo.Any())
            //{
            //    context.AddRange
            //    (
            //        new GameInfo
            //        {
            //            Name = "Devil May Cry 5",
            //            GamePrice = 7.95M,
            //            GameDescription = "The Devil you know returns in this brand new entry in the over-the-top action series available on the PC.",
            //            Category = categories[""],
            //            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg",
            //            GameQuantity = true,
            //            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg"
            //        }

            //    );
            //}

            //context.SaveChanges();
        }

        private static Dictionary<string, GameCategory> categories;
        public static Dictionary<string, GameCategory> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new GameCategory[]
                    {
                        new GameCategory { CategoryName = "ESRB" },
                    };

                    categories = new Dictionary<string, GameCategory>();

                    foreach (GameCategory genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}














               
                   


  