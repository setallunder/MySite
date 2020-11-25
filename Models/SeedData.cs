using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySite.Data;

namespace MySite.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MySiteContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MySiteContext>>()))
            {
                // Look for any company.
                if (context.Company.Any())
                {
                    return;   // DB has been seeded
                }

                context.Company.AddRange(
                    new Company
                    {
                        Title = "Зоопарку требуется помощь",
                        Description = "Зоопарку нужно собрать деньги на ремонт",
                        Tags = "#зоопарк",
                        Images = "",
                        Video = "",
                        Topic = "Зоопарк",
                        ExpiryDate = DateTime.Parse("2021-3-13"),
                        Rating = "R"
                    },

                    new Company
                    {
                        Title = "Помогите спасти часовню",
                        Description = "Помогите спасти жемчужину Пскова",
                        Tags = "#часовня",
                        Images = "",
                        Video = "",
                        Topic = "Часовня",
                        ExpiryDate = DateTime.Parse("2021-3-13"),
                        Rating = "R"
                    },

                    new Company
                    {
                        Title = "RAMMSTEIN - тур 2021",
                        Description = "",
                        Tags = "#RAMMSTEIN",
                        Images = "",
                        Video = "",
                        Topic = "RAMMSTEIN",
                        ExpiryDate = DateTime.Parse("2021-3-13"),
                        Rating = "R"
                    },

                    new Company
                    {
                        Title = "Помогите вернуть тигра домой",
                        Description = "",
                        Tags = "#тигр",
                        Images = "",
                        Video = "",
                        Topic = "Тигр",
                        ExpiryDate = DateTime.Parse("2021-3-13"),
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
