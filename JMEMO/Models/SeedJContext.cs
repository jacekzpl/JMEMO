using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JMEMO.Models
{
    public static class SeedJContext
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new JContext(serviceProvider.GetRequiredService<DbContextOptions<JContext>>()))
            {
                context.Database.EnsureCreated();

                // Look for any movies.
                if (context.Tasks.Any())
                {
                    return;   // DB has been seeded
                }

                User user = new User { Email = "1234@gmail.com", Password = "1234", Nick = "Jacek" };
                Language pl = new Language { LanguageCode = LanguageType.PL };
                Language en = new Language { LanguageCode = LanguageType.EN };
                Language es = new Language { LanguageCode = LanguageType.ES };
                Text textpl = new Text { TextBody = "Coś po polsku", Language = pl };
                Text texten = new Text { TextBody = "Something in english", Language = en };
                Text textes = new Text { TextBody = "Algo en espanol", Language = es };
                Task task = new Task { 
                    User = user, 
                    PL = textpl, EN = texten, ES = textes, 
                    RepetitionDayPLEN = DateTime.Today, LevelPLEN = 50,
                    RepetitionDayPLES = DateTime.Today, LevelPLES = 50,
                    RepetitionDayENPL = DateTime.Today, LevelENPL = 50,
                    RepetitionDayENES = DateTime.Today, LevelENES = 50,
                    RepetitionDayESPL = DateTime.Today, LevelESPL = 50,
                    RepetitionDayESEN = DateTime.Today, LevelESEN = 50
                };

                context.Users.Add(user);
                context.Languages.AddRange(pl, en, es);
                context.Texts.AddRange(textpl, texten, textes);
                context.Tasks.AddRange(task);
                context.SaveChanges();
            }
        }
    }
}
