using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any Scriptures.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi",                     
                        CreatedDate = DateTime.Parse("2020-6-3"),
                        Chapter = "1",
                        Verse = "1",
                        Notes = "Having been born of goodly parents."
                    },

                    new Scripture
                    {
                        Book = "2 Nephi",
                        CreatedDate = DateTime.Parse("2020-6-3"),
                        Chapter = "2",
                        Verse = "1",
                        Notes = "Afflictions will be to our gain."
                    },

                    new Scripture
                    {
                        Book = "Mosiah",
                        CreatedDate = DateTime.Parse("2020-6-3"),
                        Chapter = "5",
                        Verse = "2",
                        Notes = "Mighty change of heart."
                    },

                    new Scripture
                    {
                        Book = "Alma",
                        CreatedDate = DateTime.Parse("2020-6-3"),                        
                        Chapter = "7",
                        Verse = "11-12",
                        Notes = "The Savior will take upon himself our infirmities so as to know how to succor us."
                    },

                    new Scripture
                    {
                        Book = "Helaman"
                    }
                  
                );
                context.SaveChanges();
            }
        }
    }
}