using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Smileys.Data.Models
{
    public class SmileyDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new SmileyDbContext(serviceProvider.GetRequiredService<DbContextOptions<SmileyDbContext>>());

            context.Companies.AddRange(
                new Company
                {
                    Id = 1,
                    Name = "SmartBurning Stenovnspizzaer",
                    Cvr = "DK25635214",
                    Address = "Nansengade 15, København",
                    SmileyCurrent = 1,
                    Smiley1= 1,
                    Smiley2= 2,
                    Smiley3= 1
                },
                new Company
                {
                    Id = 2,
                    Name = "CphSpisness",
                    Cvr = "DK98745632",
                    Address = "Nørgaardsvej 13, Lyngby",
                    SmileyCurrent = 1,
                    Smiley1 = 3,
                    Smiley2 = 2,
                    Smiley3 = 3
                },
                new Company
                {
                    Id = 3,
                    Name = "Erhvervs Madkadamiet",
                    Cvr = "DK25896321",
                    Address = "Landermærket 11, København",
                    SmileyCurrent = 3,
                    Smiley1 = 2,
                    Smiley2 = 2,
                    Smiley3 = 1
                }
                );
            context.SaveChanges();
        }
    }
}
