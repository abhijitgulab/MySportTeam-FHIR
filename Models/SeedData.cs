using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySportTeam.Data;
using System;
using System.Linq;

namespace MySportTeam.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MySportTeamContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MySportTeamContext>>()))
            {
                // Look for any movies.
                if (context.Athlete.Any())
                {
                    return;   // DB has been seeded
                }

                context.Athlete.AddRange(
                    new Athlete
                    {
                        Family="EVERYWOMAN",
                        Given="EVE",
                        Gender="female",
                        birthDate=DateTime.Parse("10-May-1957"),
                        Identifier="www.mypatientidentifier.com|201903141247-P-BBB",
                        Team="Toronto Lions",
                        Position="Midfielder"
                        
                    },

                    new Athlete
                    {
                        Family="Smith",
                        Given="Maria",
                        Gender="female",
                        birthDate=DateTime.Parse("12-Sep-1909"),
                        Identifier="http://hl7.org/fhir/sid/us-ssn|999-26-8666",
                        Team="Toronto Lions",
                        Position="Defense"
                        
                    },
                    new Athlete
                    {
                        Family="Jones",
                        Given="Seema",
                        Gender="male",
                        birthDate=DateTime.Parse("12-Sep-1909"),
                        Identifier="http://hospital.smarthealthit.org|d8d38a4f-4938-42b2-af18-61b5fddbcf3",
                        Team="Toronto Lions",
                        Position="Midfielder"
                        
                    },
                       new Athlete
                    {
                        Family="Jackman",
                        Given="Michael",
                        Gender="male",
                        birthDate=DateTime.Parse("03-Sep-1975"),
                        Identifier="urn:uuid:53fefa32-fcbb-4ff8-8a92-55ee120877b7|1717",
                        Team="Toronto Lions",
                        Position="Defense"
                        
                    }


                );
                context.SaveChanges();
            }
        }
    }
}