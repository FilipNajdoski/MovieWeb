using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieWeb.Data;
using MovieWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                var genres = new Genre[]
                {
                      #region Genres 
                   new Genre { GenreName = "Action" },
                   new Genre { GenreName = "Drama" },
                   new Genre { GenreName = "Thriller" },
                   new Genre { GenreName = "Comedy" },
                   new Genre { GenreName = "Romance" },
                   new Genre { GenreName = "Crime" },
                   new Genre { GenreName = "Biography" },
                   new Genre { GenreName = "Adventure" },
                   new Genre { GenreName = "Sci-fi" },
                   new Genre { GenreName = "Fantasy" },
                   new Genre { GenreName = "War" }
                   #endregion
                };

                for (int i = 0; i < genres.Length; i++)
                {
                    context.Genre.Add(genres[i]); ;
                    context.SaveChanges();
                }


                var people = new Person[]
                {
                    #region 1-5 Movie People 
                       new Person
                       {
                           PersonName = "Todd Phillips",
                           Biography = "Todd Phillips was born on December 20, 1970 in Brooklyn, New York City, New York, USA as Todd Bunzl. He is a producer " +
                           "and director, known for Joker (2019), Old School (2003) and Due Date (2010).",
                           Gender = "Male",
                           PlaceOfBirth = "Brooklyn, New York City, New York, USA",
                           DateOfBirth = new DateTime(1970, 12, 20),
                           IMDBPersonLink = @"https://www.imdb.com/name/nm0680846/?ref_=tt_ov_dr"
                       },
                       new Person
                       {
                           PersonName = "Scott Silver",
                           Biography = "Scott Silver is a writer, known for Joker (2019), The Fighter (2010) and Johns (1996).",
                           Gender = "Male",
                           IMDBPersonLink = @"https://www.imdb.com/name/nm0798788/?ref_=tt_ov_wr"
                       },
                       new Person
                       {
                           PersonName = "Joaquin Phoenix",
                           Biography = "Joaquin Phoenix was born Joaquin Rafael Bottom in San Juan, Puerto Rico, to Arlyn (Dunetz) and John Bottom, and is the " +
                           "middle child in a brood of five. His parents, from the continental United States, were then serving as Children of God missionaries. " +
                           "His mother is from a Jewish family from New York, while his father, from California, is of mostly...Joaquin Phoenix was born Joaquin " +
                           "Rafael Bottom in San Juan, Puerto Rico, to Arlyn (Dunetz) and John Bottom, and is the middle child in a brood of five. His parents, " +
                           "from the continental United States, were then serving as Children of God missionaries. His mother is from a Jewish family from New York, " +
                           "while his father, from California, is of mostly...",
                           Gender = "Male",
                           PlaceOfBirth = "Brooklyn, New York City, New York, USA",
                           DateOfBirth = new DateTime(1974, 10, 28),
                           IMDBPersonLink = @"https://www.imdb.com/name/nm0001618/?ref_=tt_ov_st_sm"
                       },
                       new Person
                       {
                           PersonName = "Robert De Niro",
                           Biography = "One of the greatest actors of all time, Robert De Niro was born on August 17, 1943 in Manhattan, New York City, to artists " +
                           "Virginia (Admiral) and Robert De Niro Sr. His paternal grandfather was of Italian descent, and his other ancestry is Irish, English, Dutch, " +
                           "German, and French. He was trained at the Stella Adler Conservatory and the American ... ",
                           Gender = "Male",
                           PlaceOfBirth = "New York City, New York, USA",
                           DateOfBirth = new DateTime(1943, 08, 17),
                           IMDBPersonLink = @"https://www.imdb.com/name/nm0000134/?ref_=tt_ov_st_sm"
                       },
                       new Person
                       {
                           PersonName = "Zazie Beetz",
                           Biography = "Zazie Beetz (born c. 1991) is a German-American actress known for the role of Vanessa on Atlanta (2016), as well as for starring " +
                           "in Deadpool 2 (2018), Applesauce (2015), and Still Here. Born in Berlin, Germany, to a German father and an African-American mother, she was " +
                           "raised in Manhattan (New York City) speaking both German and English at home. ... ",
                           Gender = "Female",
                           PlaceOfBirth = "Mitte, Berlin, Germany",
                           DateOfBirth = new DateTime(1991, 05, 25),
                           IMDBPersonLink = @"https://www.imdb.com/name/nm5939164/?ref_=tt_ov_st_sm"
                       },
                    #endregion
                    #region 6-10 Movie People
                       new Person
                       {
                           PersonName = "Garth Davis",
                           Biography = "Garth Davis is a renowned film, television and commercials director whose feature directorial debut Lion was nominated for six Academy " +
                           "Awards including Best Picture. For the first time in the history of the Directors Guild of America, Davis was nominated twice in the same year for " +
                           "Lion - for the DGA Award for Outstanding Directorial Achievement in...",
                           Gender = "Male",
                           PlaceOfBirth = "Australia",
                           IMDBPersonLink = @"https://www.imdb.com/name/nm0204628/?ref_=tt_ov_dr"
                       },
                       new Person
                       {
                           PersonName = "Helen Edmundson",
                           Biography = "Helen Edmundson is a writer and actress, known for Mary Magdalene (2018), The Suspicions of Mr Whicher (2011) and An Inspector Calls (2015). ",
                           Gender = "Female",
                           IMDBPersonLink = @"https://www.imdb.com/name/nm1779951/?ref_=tt_ov_wr"
                       },
                       new Person
                       {
                           PersonName = "Philippa Goslett",
                           Biography = "Philippa Goslett is a writer and actress, known for Little Ashes (2008), How To Talk To Girls At Parties (2017) and Holy Money (2009). ",
                           Gender = "Female",
                           IMDBPersonLink = @"https://www.imdb.com/name/nm1514357/?ref_=tt_ov_wr"
                       },
                       new Person
                       {
                           PersonName = "Rooney Mara",
                           Biography = "Actress and philanthropist Rooney Mara was born on April 17, 1985 in Bedford, New York. She made her screen debut in the slasher film Urban " +
                            "Legends: Bloody Mary (2005), went on to have a supporting role in the independent coming-of-age drama Tanner Hall (2009), and has since starred in the " +
                            "horror remake A Nightmare on Elm Street (2010), the ...",
                           Gender = "Female",
                           DateOfBirth = new DateTime(1985, 04, 17),
                           PlaceOfBirth = "Bedford, New York, USA",
                           IMDBPersonLink = @"https://www.imdb.com/name/nm1913734/?ref_=tt_ov_st_sm"
                       },
                    #endregion
                    #region 11-15 Movie People
                        new Person
                        {
                            PersonName = "Chiwetel Ejiofor",
                            Biography = "English actor, writer and director Chiwetel Ejiofor is renowned for his portrayal of Solomon Northup in 12 Years a Slave (2013), for which " +
                            "he received Academy Award and Golden Globe Award nominations, along with the BAFTA Award for Best Actor. He is also known for playing Okwe in Dirty " +
                            "Pretty Things (2002), the Operative in Serenity (2005), Lola ...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1977, 07, 10),
                            PlaceOfBirth = "Forest Gate, London, England, UK",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0252230/?ref_=tt_ov_st_sm"
                        },
                        new Person
                        {
                            PersonName = "Christopher Nolan",
                            Biography = "Best known for his cerebral, often nonlinear, storytelling, acclaimed writer-director Christopher Nolan was born on July 30, 1970, in London," +
                            " England. Over the course of 15 years of filmmaking, Nolan has gone from low-budget independent films to working on some of the biggest blockbusters ever made." +
                            " At 7 years old, Nolan began making short movies ...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1970, 07, 30),
                            PlaceOfBirth = "London, England, UK",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0634240/?ref_=tt_ov_dr"
                        },
                        new Person
                        {
                            PersonName = "Leonardo DiCaprio",
                            Biography = "Few actors in the world have had a career quite as diverse as Leonardo DiCaprio's. DiCaprio has gone from relatively humble beginnings, " +
                            "as a supporting cast member of the sitcom Growing Pains (1985) and low budget horror movies, such as Critters 3 (1991), to a major teenage heartthrob in the 1990s," +
                            " as the hunky lead actor in movies such as Romeo +...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1974, 11, 11),
                            PlaceOfBirth = "Hollywood, Los Angeles, California, USA",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0000138/?ref_=tt_ov_st_sm"
                        },
                        new Person
                        {
                            PersonName = "Joseph Gordon-Levitt",
                            Biography = "Joseph Gordon-Levitt has completed production on the untitled Henry Joost/Ariel Schulman sci-fi film for Netflix in which he stars opposite Jamie Foxx " +
                            "and on the independent thriller, 7500, written and directed by Patrick Vollarth. Among his other projects, he is in development on a variety of feature films including Fraggle Rock." +
                            " Gordon-Levitt's ...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1981, 02, 17),
                            PlaceOfBirth = "Los Angeles, California, USA",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0330687/?ref_=tt_ov_st_sm"
                        },
                        new Person
                        {
                            PersonName = "Ellen Page",
                            Biography = "Ellen Grace Philpotts-Page was born on February 21, 1987, in Halifax, Nova Scotia, to Martha Philpotts, a teacher, and Dennis Page, a graphic designer. " +
                            "Page wanted to start acting at an early age and attended the Neptune Theater School. She began her career at the age of 10 on the award-winning television series Pit Pony (1999), for which she ...",
                            Gender = "Female",
                            DateOfBirth = new DateTime(1987, 02, 21),
                            PlaceOfBirth = "Halifax, Nova Scotia, Canada",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0680983/?ref_=tt_ov_st_sm"
                        },
                        new Person
                        {
                            PersonName = "Christian Bale",
                            Biography = "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer - Jenny (James) and David Bale. His mother was a circus performer " +
                            "and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal,...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1974, 01, 30),
                            PlaceOfBirth = "Haverfordwest, Pembrokeshire, Wales, UK",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0000288/?ref_=tt_ov_st_sm"
                        },
                    #endregion
                    #region 16-20 Movie People
                        new Person
                        {
                            PersonName = "Heath Ledger",
                            Biography = "When hunky, twenty-year-old heart-throb Heath Ledger first came to the attention of the public in 1999, it was all too easy to tag him as a pretty boy and an actor of little depth. " +
                            "He spent several years trying desperately to sway this image, but this was a double-edged sword. His work comprised nineteen films, including 10 Things I Hate About ...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1979, 04, 04),
                            DateOfDeath = new DateTime(2008, 01, 22),
                            PlaceOfBirth = "Perth, Western Australia, Australia",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0005132/?ref_=tt_ov_st_sm"
                        },
                        new Person
                        {
                            PersonName = "Aaron Eckhart",
                            Biography = "Aaron Eckhart was born on March 12, 1968 in Cupertino, California, USA as Aaron Edward Eckhart. He is an actor and producer, known for The Dark Knight (2008), " +
                            "Thank You for Smoking (2005) and In the Company of Men (1997).",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1968, 03, 12),
                            PlaceOfBirth = "Cupertino, California, USA",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0001173/?ref_=tt_ov_st_sm"
                        },
                        new Person
                        {
                            PersonName = "Jonathan Nolan",
                            Biography = "Attended Loyola Academy in Wilmette, Illinois, graduating in 1994. Graduated from Georgetown University in Washington, D.C. in 1999. Majored in English. " +
                            "Shortly after graduating from Georgetown University, Jonathan Nolan served as a production assistant on Memento (2000). Wrote the short story, Memento Mori, on which the film Memento (2000) is ...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1976, 06, 06),
                            PlaceOfBirth = "London, England, UK",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0634300/?ref_=tt_ov_wr"
                        },
                        new Person
                        {
                            PersonName = "Peter Farrelly",
                            Biography = "Peter Farrelly was born on December 17, 1956 in Phoenixville, Pennsylvania, USA as Peter John Farrelly. He is a producer and writer, known for Green Book (2018), " +
                            "There's Something About Mary (1998) and Dumb and Dumber (1994). He has been married to Melinda Farrelly since December 31, 1996. They have two children.",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1956, 12, 17),
                            PlaceOfBirth = "Phoenixville, Pennsylvania, USA",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0268380/?ref_=tt_ov_dr"
                        },
                        new Person
                        {
                            PersonName = "Nick Vallelonga",
                            Biography = "Nick Vallelonga won two Academy Awards and two Golden Globes for Original Screenplay and Best Picture for Green Book. Nick wrote and produced Green Book" +
                            " with Peter Farrelly and Brian Hayes Currie, based on the true story of Nick's father Tony Lip, who went on tour of the south with the brilliant pianist Dr. Donald Shirley in 1962. Directed by ...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1959, 09, 13),
                            PlaceOfBirth = "Bronx, New York, USA",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0885014/?ref_=tt_ov_wr"
                        },
                    #endregion
                    #region 21-25 Movie People
                        new Person
                        {
                            PersonName = "Brian Hayes Currie",
                            Biography = "Brian Hayes Currie was born in 1961. He is an actor and writer, known for Green Book (2018), Armageddon (1998) and Con Air (1997).",
                            Gender = "Male",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0192942/?ref_=tt_ov_wr"
                        },
                        new Person
                        {
                            PersonName = "Viggo Mortensen",
                            Biography = "Since his screen debut as a young Amish farmer in Peter Weir's Witness (1985), Viggo Mortensen's career has been marked by a steady string of well-rounded performances. " +
                            "Mortensen was born in New York City, to Grace Gamble (Atkinson) and Viggo Peter Mortensen, Sr. His father was Danish, his mother was American, and his maternal grandfather was ...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1958, 10, 20),
                            PlaceOfBirth = "Manhattan, New York City, New York, USA",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0001557/?ref_=tt_ov_st_sm"
                        },
                        new Person
                        {
                            PersonName = "Mahershala Ali",
                            Biography = "Mahershala Ali is fast becoming one of the freshest and most in-demand faces in Hollywood with his extraordinarily diverse skill set and wide-ranging background in film, " +
                            "television, and theater. This past fall, Ali wrapped A24's Brad Pitt and Adele Romanski produced independent feature film, Moonlight, as well as reprising his role in The Hunger ...",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1974, 02, 16),
                            PlaceOfBirth = "Oakland, California, USA",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0991810/?ref_=tt_ov_st_sm"
                        },
                        new Person
                        {
                            PersonName = "Linda Cardellini",
                            Biography = "Linda Edna Cardellini was born in Redwood City, California, to Lorraine (Hernan) and Wayne David Cardellini, a businessman. She is of Italian (from her paternal grandfather), " +
                            "Irish (from her mother), German, English, and Scottish descent. Linda grew up in the San Francisco Bay area, California, the youngest of four children. She became interested ... ",
                            Gender = "Female",
                            DateOfBirth = new DateTime(1975, 06, 25),
                            PlaceOfBirth = "Redwood City, California, USA",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm0004802/?ref_=tt_ov_st_sm"
                        },
                        new Person
                        {
                            PersonName = "Barry Jenkins",
                            Biography = "Barry Jenkins was born on November 19, 1979 in Miami, Florida, USA. He is a director and producer, known for If Beale Street Could Talk (2018), Moonlight (2016) and Medicine for Melancholy (2008).",
                            Gender = "Male",
                            DateOfBirth = new DateTime(1976, 11, 17),
                            PlaceOfBirth = "Miami, Florida, USA",
                            IMDBPersonLink = @"https://www.imdb.com/name/nm1503575/?ref_=tt_ov_dr"
                        },
                    #endregion
                    #region 26-30 Movie People
                         new Person
                         {
                             PersonName = "Naomie Harris",
                             Biography = "British actress Naomie Harris was born in London, England, the only child of television scriptwriter Lisselle Kayla. Her father is from Trinidad and her mother is from Jamaica." +
                             " They separated before she was born, and Harris was raised by her mother and has no relationship with her father. She showed an interest in acting from an early age and ...",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1976, 09, 06),
                             PlaceOfBirth = "London, England, UK",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0365140/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Trevante Rhodes",
                             Biography = "Trevante Rhodes was born as Trevante Nemour Rhodes. He is an actor, known for Moonlight (2016), The Predator (2018) and Bird Box (2018).",
                             Gender = "Male",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm5218990/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "David Ayer",
                             Biography = "David Ayer is an American film director, producer, and screenwriter. David Ayer was born in Champaign, Illinois and grew up in Bloomington, Minnesota, " +
                             "and Bethesda, Maryland, where he was kicked out of his house by his parents as a teenager. Ayer then lived with his cousin in Los Angeles, California, where his experiences in South Central Los ... ",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1968, 01, 18),
                             PlaceOfBirth = "Champaign, Illinois, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0043742/?ref_=tt_ov_dr"
                         },
                         new Person
                         {
                             PersonName = "Max Landis",
                             Biography = "Max Landis was born on August 3, 1985 in Los Angeles County, California, USA. He is a writer and producer, known for Mr. Right (2015), Dirk Gently's Holistic Detective Agency (2016) and Bright (2017).",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1985, 08, 03),
                             PlaceOfBirth = "Los Angeles County, California, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0484840/?ref_=tt_ov_wr"
                         },
                         new Person
                         {
                             PersonName = "Will Smith",
                             Biography = "Willard Carroll Will Smith, Jr. (born September 25, 1968) is an American actor, comedian, producer, rapper, and songwriter. He has enjoyed success in television, film, and music. In April 2007," +
                             " Newsweek called him the most powerful actor in Hollywood. Smith has been nominated for five Golden Globe Awards, two Academy Awards, and has won four ...",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1968, 09, 25),
                             PlaceOfBirth = "Philadelphia, Pennsylvania, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0000226/?ref_=tt_ov_st_sm"
                         },
                    #endregion
                    #region 31-35 Movie People
                         new Person
                         {
                             PersonName = "Joel Edgerton",
                             Biography = "Joel Edgerton was born on June 23, 1974 in Blacktown, New South Wales, Australia, to Marianne (van Dort) and Michael Edgerton, who is a solicitor and property developer. " +
                             "His brother is filmmaker Nash Edgerton. His mother is a Dutch immigrant. Joel went to Hills Grammar School in the Western Suburbs of Sydney, and after leaving, he attended Nepean ...",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1974, 06, 23),
                             PlaceOfBirth = "Blacktown, New South Wales, Australia",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0249291/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Noomi Rapace",
                             Biography = "Swedish actress Noomi Rapace was born in Hudiksvall, Gävleborgs län, Sweden to Swedish actress Nina Norén and Spanish Flamenco singer Rogelio Durán. Her parents did not stay together," +
                             " and when she was five she moved to Iceland with her mother and stepfather, where she lived for three years. When she was eight she was cast in a small role in the ...",
                             Gender = "Female",
                             DateOfBirth = new DateTime(1979, 12, 28),
                             PlaceOfBirth = "Hudiksvall, Gävleborgs län, Sweden",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0636426/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Roar Uthaug",
                             Biography = "Roar Uthaug is a Norwegian film director. He is best known for Tomb Raider (2018), The Wave (2015), Cold Prey (2006) and Escape (2012). Uthaug was born in August 25, 1973. " +
                             "In 2002 he graduated from the Norwegian Film School. His directorial debut was Cold Prey/Fritt Vilt in 2006. In 2018 he directed the Tomb Raider reboot starring Alicia Vikander.",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1973, 08, 23),
                             PlaceOfBirth = "Lørenskog, Norway",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm1012385/?ref_=tt_ov_dr"
                         },
                         new Person
                         {
                             PersonName = "Geneva Robertson-Dworet",
                             Biography = "No biography available",
                             Gender = "Female",
                             DateOfBirth = new DateTime(1985, 05, 08),
                             PlaceOfBirth = "Los Angeles, California, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm4039044/?ref_=tt_ov_wr"
                         },
                         new Person
                         {
                             PersonName = "Alicia Vikander",
                             Biography = "Alicia Vikander is a Swedish actress, dancer and producer. She was born and raised in Gothenburg, Västra Götalands län, Sweden, to Maria Fahl-Vikander," +
                             " an actress of stage and screen, and Svante Vikander, a psychiatrist. She is of Swedish and one quarter Finnish descent. Alicia began acting as a child in minor stage productions at The Göteborg ...",
                             Gender = "Female",
                             DateOfBirth = new DateTime(1988, 10, 03),
                             PlaceOfBirth = "Gothenburg, Västra Götalands län, Sweden",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm2539953/?ref_=tt_ov_st_sm"
                         },
                    #endregion
                    #region 36-40 Movie People
                         new Person
                         {
                             PersonName = "Dominic West",
                             Biography = "Dominic West was born on October 15, 1969 in Sheffield, Yorkshire, England as Dominic Gerard Francis Eagleton West." +
                             " He is an actor and producer, known for The Wire (2002), Chicago (2002) and 300 (2006). He has been married to Catherine Fitzgerald since June 26, 2010. They have four children. ",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1969, 10, 15),
                             PlaceOfBirth = "Sheffield, Yorkshire, England, UK",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0922035/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Walton Goggins",
                             Biography = "Walton Goggins is an actor of considerable versatility and acclaim who has delivered provocative performances in a multitude of feature films and television series. " +
                             "He won a Critics' Choice Award for his performance in the HBO comedy series 'Vice Principals' and landed an Emmy nomination for his role of 'Boyd Crowder' on FX's Justified, among ...",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1971, 11, 10),
                             PlaceOfBirth = "Birmingham, Alabama, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0324658/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Quentin Tarantino",
                             Biography = "Quentin Jerome Tarantino was born in Knoxville, Tennessee. His father, Tony Tarantino, is an Italian-American actor and musician from New York, and his mother," +
                             " Connie (McHugh), is a nurse from Tennessee. Quentin moved with his mother to Torrance, California, when he was four years old. In January of 1992, first-time writer-director Tarantino's ... ",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1963, 03, 27),
                             PlaceOfBirth = "Knoxville, Tennessee, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0000233/?ref_=tt_ov_dr"
                         },
                         new Person
                         {
                             PersonName = "Brad Pitt",
                             Biography = "An actor and producer known as much for his versatility as he is for his handsome face, Golden Globe-winner Brad Pitt's most widely recognized role may be " +
                             "Tyler Durden in Fight Club (1999). However, his portrayals of Billy Beane in Moneyball (2011), and Rusty Ryan in the remake of Ocean's Eleven (2001) and its sequels, also loom large in his ...",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1963, 12, 18),
                             PlaceOfBirth = "Shawnee, Oklahoma, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0000093/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Diane Kruger",
                             Biography = "Diane Kruger was born Diane Heidkrüger in Algermissen, near Hildesheim, Germany, to Maria-Theresa, a bank employee, and Hans-Heinrich Heidkrüger, a computer specialist. " +
                             "She studied ballet with the Royal Ballet in London before an injury ended her career. She returned to Germany and became a top fashion model. She later pursued acting and relocated...",
                             Gender = "Female",
                             DateOfBirth = new DateTime(1976, 07, 15),
                             PlaceOfBirth = "Algermissen, Lower Saxony, West Germany",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm1208167/?ref_=tt_ov_st_sm"
                         },

                    #endregion
                    #region 41-45 Movie People
                         new Person
                         {
                             PersonName = "Eli Roth",
                             Biography = "Eli Raphael Roth was born in Newton, Massachusetts, to Cora (Bialis), a painter, and Sheldon H. Roth, a psychoanalyst, psychiatrist, and clinical professor. " +
                             "His family is Jewish (from Austria, Hungary, Russia, and Poland). He began shooting Super 8 films at the age of eight, after watching Ridley Scott's Alien (1979) and vomiting, and deciding he ...",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1972, 04, 18),
                             PlaceOfBirth = "Boston, Massachusetts, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0744834/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Matthew McConaughey",
                             Biography = "American actor and producer Matthew David McConaughey was born in Uvalde, Texas. His mother, Mary Kathleen (McCabe), is a substitute school teacher originally from New Jersey." +
                             " His father, James Donald McConaughey, was a Mississippi-born gas station owner who ran an oil pipe supply business. He is of Irish, Scottish, English, German, and Swedish ... ",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1969, 11, 04),
                             PlaceOfBirth = "Uvalde, Texas, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0000190/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Anne Hathaway",
                             Biography = "Anne Jacqueline Hathaway was born in Brooklyn, New York, to Kate McCauley Hathaway, an actress, and Gerald T. Hathaway, a lawyer, both originally from Philadelphia. " +
                             "She is of mostly Irish descent, along with English, German, and French. Her first major role came in the short-lived television series Get Real (1999). She gained widespread ...  ",
                             Gender = "Female",
                             DateOfBirth = new DateTime(1982, 11, 12),
                             PlaceOfBirth = "Brooklyn, New York City, New York, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0004266/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Jessica Chastain",
                             Biography = "Jessica Michelle Chastain was born in Sacramento, California, and was raised in a middle-class household in a northern California suburb. Her mother, Jerri Chastain, " +
                             "is a vegan chef whose family is originally from Kansas, and her stepfather is a fireman. She discovered dance at the age of nine and was in a dance troupe by age thirteen. She began ... ",
                             Gender = "Female",
                             DateOfBirth = new DateTime(1977, 03, 24),
                             PlaceOfBirth = "Sacramento, California, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm1567113/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "David Fincher",
                             Biography = "David Fincher was born in 1962 in Denver, Colorado, and was raised in Marin County, California. When he was 18 years old he went to work for John Korty at Korty Films in Mill Valley. " +
                             "He subsequently worked at ILM (Industrial Light and Magic) from 1981-1983. Fincher left ILM to direct TV commercials and music videos after signing with N. Lee Lacy ...",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1962, 08, 28),
                             PlaceOfBirth = "Denver, Colorado, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0000399/?ref_=tt_ov_dr"
                         },

                    #endregion
                    #region 46-50 Movie People
                         new Person
                         {
                             PersonName = "Chuck Palahniuk",
                             Biography = "Chuck is a low key writer who never stops writing and taking down notes to file away for future writing. Very funny, very creative and very thought provoking. " +
                             "His books often make you look at yourself in ways that you would never have before. Same goes for the world, he will make you notice things that you never did. He is of French and Russian ...",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1962, 02, 21),
                             PlaceOfBirth = "Pasco, Washington, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0744834/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Jim Uhls",
                             Biography = "Jim Uhls was born on March 25, 1957 in Missouri, USA as James Walter Uhls. He is a writer and producer, known for Fight Club (1999), Jumper (2008) and The Destroyer. " +
                             "He is married to Yalda Tehranian. They have two children.",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1957, 03, 25),
                             PlaceOfBirth = "Missouri, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0880243/?ref_=tt_ov_wr"
                         },
                         new Person
                         {
                             PersonName = "Edward Norton",
                             Biography = "American actor, filmmaker and activist Edward Harrison Norton was born on August 18, 1969, in Boston, Massachusetts, and was raised in Columbia, Maryland." +
                             " His mother, Lydia Robinson Robin (Rouse), was a foundation executive and teacher of English, and a daughter of famed real estate developer James Rouse, who developed Columbia, MD; she passed ...",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1969, 08, 18),
                             PlaceOfBirth = "Boston, Massachusetts, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0001570/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Meat Loaf",
                             Biography = "Meat Loaf was born in Dallas,Texas, and moved to Los Angeles in 1967 to play in local bands then in 1970 moved to New York and appeared in the Broadway musicals Hair, " +
                             "Rockabye Hamlet and The Rocky Horror Show and Off Broadway in Rainbow, More Than You Deserve, National Lampoon Show and the New York Shakespeare Festival's production of ... ",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1947, 09, 27),
                             PlaceOfBirth = "Dallas, Texas, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0001533/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "David Leitch",
                             Biography = "David Leitch is a billion dollar film director, actor, stuntman, writer, producer, and stunt coordinator. He co-directed John Wick (2014) with Chad Stahelski, " +
                             "which he also served as producer. David directed Atomic Blonde (2017) starring Charlize Theron. David also directed the box office smash and critically acclaimed Deadpool 2 (2018). He is the... ",
                             Gender = "Male",
                             PlaceOfBirth = "n/a",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0500610/?ref_=tt_ov_dr"
                         },

                    #endregion
                    #region 51-55 Movie People
                         new Person
                         {
                             PersonName = "Rhett Reese",
                             Biography = "Rhett Reese is a writer and producer, known for Deadpool (2016), Zombieland (2009) and Deadpool 2 (2018). He has been married to Chelsey Crisp since 2016. ",
                             Gender = "Male",
                             PlaceOfBirth = "n/a",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm1014201/?ref_=tt_ov_wr"
                         },
                         new Person
                         {
                             PersonName = "Paul Wernick",
                             Biography = "Paul Wernick is a producer and writer, known for Deadpool (2016), Zombieland (2009) and Deadpool 2 (2018).",
                             Gender = "Male",
                             PlaceOfBirth = "n/a",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm1116660/?ref_=tt_ov_wr"
                         },
                         new Person
                         {
                             PersonName = "Ryan Reynolds",
                             Biography = "Ryan Rodney Reynolds was born on October 23, 1976 in Vancouver, British Columbia, Canada, the youngest of four children. His father, James Chester Reynolds, was a " +
                             "food wholesaler, and his mother, Tamara Lee Tammy (Stewart), worked as a retail-store saleswoman. He has Irish and Scottish ancestry. Between 1991-93, Ryan appeared in Fifteen (1990), ... ",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1976, 10, 23),
                             PlaceOfBirth = "Vancouver, British Columbia, Canada",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0005351/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Josh Brolin",
                             Biography = "Rugged features and a natural charm have worked for Josh Brolin, the son of actor James Brolin. He has played roles as a policeman, a hunter, and the President of the United States. " +
                             "Brolin was born February 12, 1968 in Santa Monica, California, to Jane Cameron (Agee), a Texas-born wildlife activist, and James Brolin. Josh was not interested at ... ",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1968, 02, 12),
                             PlaceOfBirth = "Santa Monica, California, USA",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm0000982/?ref_=tt_ov_st_sm"
                         },
                         new Person
                         {
                             PersonName = "Morena Baccarin",
                             Biography = "David Leitch is a billion dollar film director, actor, stuntman, writer, producer, and stunt coordinator. He co-directed John Wick (2014) with Chad Stahelski, " +
                             "which he also served as producer. David directed Atomic Blonde (2017) starring Charlize Theron. David also directed the box office smash and critically acclaimed Deadpool 2 (2018). He is the... ",
                             Gender = "Male",
                             DateOfBirth = new DateTime(1979, 06, 02),
                             PlaceOfBirth = "Rio de Janeiro, Rio de Janeiro, Brazil",
                             IMDBPersonLink = @"https://www.imdb.com/name/nm1072555/?ref_=tt_ov_st_sm"
                         },

                    #endregion
                    #region 56-60 Movie People
                     new Person
                     {
                         PersonName = "Tim Miller",
                         Biography = "Tim Miller is an American animator, film director, creative director and visual effects artist. He was nominated for the Academy Award for Best Animated Short Film for the work on his short animated film Gopher Broke." +
                         " He made his directing debut with Deadpool. Miller is also famous for creating opening sequences of The Girl with the Dragon Tattoo ...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1964, 10, 10),
                         PlaceOfBirth = "Fort Washington, Maryland, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm1783265/?ref_=tt_ov_dr"
                     },
                     new Person
                     {
                         PersonName = "T.J. Miller",
                         Biography = "A comedian. Improvisation, sketch and stand-up are his forte. Todd Joseph Miller was born in Denver, Colorado, to Leslie, a clinical psychologist, and Kent Miller, an attorney. He went to East High School, " +
                         "and college in Washington, D.C. There, he performed with the group receSs for 4 years, being the only person in his class out of 100 to audition...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1981, 06, 04),
                         PlaceOfBirth = "Denver, Colorado, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm2554352/?ref_=tt_ov_st_sm"
                     },
                    new Person
                    {
                        PersonName = "Florian Henckel von Donnersmarck",
                        Biography = "Florian Henckel von Donnersmarck was born on May 2, 1973 in Cologne, North Rhine-Westphalia, Germany as Florian Maria Georg Christian Graf Henckel von Donnersmarck. He is a director and writer, known for The " +
                        "Lives of Others (2006), Never Look Away (2018) and The Tourist (2010). He is married to Christiane Asschenfeldt. They have three children.",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1973, 05, 02),
                        PlaceOfBirth = "Cologne, North Rhine-Westphalia, Germany",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0003697/?ref_=tt_ov_dr"
                    },
                    new Person
                    {
                        PersonName = "Johnny Depp",
                        Biography = "Johnny Depp is perhaps one of the most versatile actors of his day and age in Hollywood. He was born John Christopher Depp II in Owensboro, Kentucky, on June 9, 1963, to Betty Sue (Wells)," +
                        "who worked as a waitress, and John Christopher Depp, a civil engineer. Depp was raised in Florida. He dropped out of school when he was 15, and fronted a series ...",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1963, 06, 09),
                        PlaceOfBirth = "Owensboro, Kentucky, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0000136/?ref_=tt_ov_st_sm"
                    },
                    new Person
                    {
                        PersonName = "Angelina Jolie",
                        Biography = "Angelina Jolie is an Academy Award-winning actress who rose to fame after her role in Girl, Interrupted (1999), playing the title role in the Lara Croft blockbuster movies," +
                        " as well as Mr. & Mrs. Smith (2005), Wanted (2008), Salt (2010) and Maleficent (2014). Off-screen, Jolie has become prominently involved in international charity projects,...",
                        Gender = "Female",
                        DateOfBirth = new DateTime(1975, 06, 04),
                        PlaceOfBirth = "Los Angeles, California, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0001401/?ref_=tt_ov_st_sm"
                    },

                     #endregion
                    #region 61-65 Movie People
                     new Person
                     {
                         PersonName = "Paul Bettany",
                         Biography = "Paul Bettany is an English actor. He first came to the attention of mainstream audiences when he appeared in the British film Gangster No. 1 (2000), and director Brian Helgeland's film A Knight's Tale (2001). " +
                         "He has gone on to appear in a wide variety of films, including A Beautiful Mind (2001), Master and Commander: The Far Side of the World ...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1971, 05, 27),
                         PlaceOfBirth = "Harlesden, London, England, UK",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0079273/?ref_=tt_ov_st_sm"
                     },
                     new Person
                     {
                         PersonName = "Adam Brody",
                         Biography = "Adam Jared Brody was born and raised in San Diego, California, the son of Valerie Jill (Siefman), a graphic artist, and Mark Alan Brody, a lawyer. His parents, both originally from Michigan, are both from " +
                         "Jewish families (from Russia and Poland). Adam spent a lot of his teen years hanging out with his friends, having fun and surfing. Upon ... ",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1979, 12, 15),
                         PlaceOfBirth = "San Diego, California, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0111013/?ref_=tt_ov_st_sm"
                     },
                    new Person
                    {
                        PersonName = "Doug Liman",
                        Biography = "Doug Liman was born on July 24, 1965 in New York City, New York, USA. He is a producer and director, known for Edge of Tomorrow (2014), Swingers (1996) and Fair Game (2010).",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1965, 07, 24),
                        PlaceOfBirth = "New York City, New York, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0510731/?ref_=tt_ov_dr"
                    },
                    new Person
                    {
                        PersonName = "Simon Kinberg",
                        Biography = "Simon Kinberg was born on August 2, 1973 in London, England. He is a producer and writer, known for The Martian (2015), Logan (2017) and Fantastic Four (2015). " +
                        "He was previously married to Mali Heled.",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1973, 08, 02),
                        PlaceOfBirth = "London, England, UK",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm1334526/?ref_=tt_ov_wr"
                    },
                    new Person
                    {
                        PersonName = "James Gunn",
                        Biography = "James Gunn was born and raised in St. Louis, Missouri, to Leota and James Francis Gunn. He is from a large Catholic family, with Irish and Czech ancestry. " +
                        "His father and his uncles were all lawyers. He has been writing and performing as long as he can remember. He began making 8mm films at the age of twelve. Many of these were comedic splatter ... ",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1966, 08, 05),
                        PlaceOfBirth = "St. Louis, Missouri, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0348181/?ref_=tt_ov_dr"
                    },

                     #endregion
                    #region 66-70 Movie People
                     new Person
                     {
                         PersonName = "Nicole Perlman",
                         Biography = "Nicole Perlman received her Film and Dramatic Writing degree from NYU's Tisch School of the Arts in 2003. Since then she has gone on to win the Tribeca Film Festival's Sloan Grant for Science in Film for her screenplay" +
                         " Challenger, which also placed on the 2006 Black List. The same year she was named one of Variety Magazine's Top Ten Writers to ...",
                         Gender = "Female",

                         PlaceOfBirth = "Boulder, Colorado, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm2270979/?ref_=tt_ov_wr"
                     },
                     new Person
                     {
                         PersonName = "Chris Pratt",
                         Biography = "Christopher Michael Pratt is an American film and television actor. He came to prominence for his small-screen roles, including Bright Abbott in Everwood (2002), Ché in The O.C. (2003)," +
                         " and Andy Dwyer and Parks and Recreation (2009), and notable film roles in Moneyball (2011), The Five-Year Engagement (2012), Zero Dark Thirty (2012), Delivery Man ...  ",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1979, 06, 21),
                         PlaceOfBirth = "Virginia, Minnesota, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0695435/?ref_=tt_ov_st_sm"
                     },
                    new Person
                    {
                        PersonName = "Vin Diesel",
                        Biography = "Vin Diesel was born Mark Sinclair in Alameda County, California, along with his fraternal twin brother, Paul Vincent. He was raised by his astrologer/psychologist mother, Delora Sherleen (Sinclair)," +
                        " and adoptive father, Irving H. Vincent, an acting instructor and theatre manager, in an artists' housing project in New York City's Greenwich Village....",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1967, 07, 18),
                        PlaceOfBirth = "Alameda County, California, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0004874/?ref_=tt_ov_st_sm"
                    },
                    new Person
                    {
                        PersonName = "Bradley Cooper",
                        Biography = "Bradley Charles Cooper was born on January 5, 1975 in Philadelphia, Pennsylvania. His mother, Gloria (Campano), is of Italian descent, and worked for a local NBC station. His father, Charles John Cooper, " +
                        "who was of Irish descent, was a stockbroker. Immediately after Bradley graduated from the Honors English program at Georgetown University in 1997... ",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1975, 01, 05),
                        PlaceOfBirth = "Philadelphia, Pennsylvania, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0177896/?ref_=tt_ov_st_sm"
                    },
                    new Person
                    {
                        PersonName = "Dan Abnett",
                        Biography = "Dan Abnett was born on October 12, 1965 in the UK. He is a writer, known for Guardians of the Galaxy (2014), Guardians of the Galaxy Vol. 2 (2017) and Alien: Isolation (2014).",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1965, 10, 12),
                        PlaceOfBirth = "UK",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm3966115/?ref_=tt_ov_wr"
                    },

                     #endregion
                    #region 71-75 Movie People
                     new Person
                     {
                         PersonName = "Zoe Saldana",
                         Biography = "Zoe Saldana was born on June 19, 1978 in Passaic, New Jersey, to Asalia Nazario and Aridio Saldaña. Her father was Dominican and her mother is Puerto Rican. She was raised in Queens, " +
                         "New York. When she was 10 years old, she and her family moved to the Dominican Republic, where they would live for the next seven years. While living there, Zoe ...",
                         Gender = "Female",
                         DateOfBirth = new DateTime(1978, 06, 19),
                         PlaceOfBirth = "Passaic, New Jersey, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0757855/?ref_=tt_ov_st_sm"
                     },
                     new Person
                     {
                         PersonName = "Dave Bautista",
                         Biography = "David Michael Bautista, Jr. was born on January 18, 1969 in Washington, D.C., to Donna Raye (Mullins) and David Michael Bautista, a hairdresser. His father is Filipino, and his mother has Greek ancestry. " +
                         "When WCW officials told him he'd never make it in sports entertainment, Bautista pushed himself to achieve his dream of being a Superstar. In May ...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1969, 01, 18),
                         PlaceOfBirth = "Washington, District of Columbia, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm1176985/?ref_=tt_ov_st_sm"
                     },
                    new Person
                    {
                        PersonName = "Anthony Russo",
                        Biography = "Anthony Russo was born on February 3, 1970 in Cleveland, Ohio, USA as Anthony J. Russo. He is a producer and director, known for Avengers: Endgame (2019), " +
                        "Captain America: The Winter Soldier (2014) and Avengers: Infinity War (2018). ",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1970, 02, 03),
                        PlaceOfBirth = "Cleveland, Ohio, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0751577/?ref_=tt_ov_dr"
                    },
                    new Person
                    {
                        PersonName = "Christopher Markus",
                        Biography = "Christopher Markus is a writer and producer, known for Avengers: Endgame (2019), Avengers: Infinity War (2018) and Captain America: The First Avenger (2011). " +
                        "He has been married to Claire Saunders since October 22, 2011.",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1999, 01, 01),
                        PlaceOfBirth = "n/a",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm1321655/?ref_=tt_ov_wr"
                    },
                    new Person
                    {
                        PersonName = "Stephen McFeely",
                        Biography = "Stephen McFeely is a writer and producer, known for Avengers: Endgame (2019), Captain America: The First Avenger (2011) and Captain America: Civil War (2016). ",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1999, 01, 01),
                        PlaceOfBirth = "n/a",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm1321656/?ref_=tt_ov_wr"
                    },

                     #endregion
                    #region 76-80 Movie People
                     new Person
                     {
                         PersonName = "Robert Downey Jr.",
                         Biography = "Robert Downey Jr. has evolved into one of the most respected actors in Hollywood. With an amazing list of credits to his name, he has managed to stay new and fresh even after over four decades in the business." +
                         " Downey was born April 4, 1965 in Manhattan, New York, the son of writer, director and filmographer Robert Downey Sr. and actress Elsie Downey...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1965, 04, 04),
                         PlaceOfBirth = "Manhattan, New York City, New York, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0000375/?ref_=tt_ov_st_sm"
                     },
                     new Person
                     {
                         PersonName = "Chris Hemsworth",
                         Biography = "Chris Hemsworth was born in Melbourne, Australia, to Leonie (van Os), a teacher of English, and Craig Hemsworth, a social-services counselor. His brothers are actors Liam Hemsworth and Luke Hemsworth. " +
                         "He is of Dutch (from his immigrant maternal grandfather), Irish, English, Scottish, and German ancestry. His uncle, by marriage, was Rod Ansell, the...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1983, 08, 11),
                         PlaceOfBirth = "Melbourne, Victoria, Australia",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm1165110/?ref_=tt_ov_st_sm"
                     },
                    new Person
                    {
                        PersonName = "Mark Ruffalo",
                        Biography = "Mark Ruffalo was born in Kenosha, Wisconsin, to Marie Rose (Hebert), a stylist and hairdresser, and Frank Lawrence Ruffalo, a construction painter. His father's ancestry is Italian, and his mother is of half " +
                        "French-Canadian and half Italian descent. Mark moved with his family to Virginia Beach, Virginia, where he lived out most of his teenage ... ",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1967, 11, 22),
                        PlaceOfBirth = "Kenosha, Wisconsin, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0749263/?ref_=tt_ov_st_sm"
                    },
                    new Person
                    {
                        PersonName = "Taika Waititi",
                        Biography = "Taika Waititi, also known as Taika Cohen, hails from the Raukokore region of the East Coast of New Zealand, and is the son of Robin (Cohen), a teacher, and Taika Waiti, an artist and farmer." +
                        " His father is Maori (Te-Whanau-a-Apanui), and his mother is of Ashkenazi Jewish, Irish, Scottish, and English descent. Taika has been involved in the film ... ",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1975, 08, 16),
                        PlaceOfBirth = "Wellington, New Zealand",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0169806/?ref_=tt_ov_dr"
                    },
                    new Person
                    {
                        PersonName = "Eric Pearson",
                        Biography = "Eric Pearson is known for his work on Thor: Ragnarok (2017), Black Widow (2020) and Godzilla vs. Kong (2020).",
                        Gender = "Male",

                        IMDBPersonLink = @"https://www.imdb.com/name/nm3069408/?ref_=tt_ov_wr"
                    },

                     #endregion
                    #region 81-85 Movie People
                     new Person
                     {
                         PersonName = "Craig Kyle",
                         Biography = "Craig Kyle was born on November 3, 1971 in Houston, Texas, USA as Craig Paul Kyle. He is a writer and producer, known for Thor: Ragnarok (2017), Iron Man (2008) and Thor (2011). ",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1971, 11, 03),
                         PlaceOfBirth = "Houston, Texas, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm1219736/?ref_=tt_ov_wr"
                     },
                     new Person
                     {
                         PersonName = "Tom Hiddleston",
                         Biography = "Thomas William Hiddleston was born in Westminster, London, to English-born Diana Patricia (Servaes) and Scottish-born James Norman Hiddleston. His mother is a former stage manager, and his father," +
                         " a scientist, was the managing director of a pharmaceutical company. He started off at the preparatory school, The Dragon School in Oxford, and by the ...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1981, 02, 09),
                         PlaceOfBirth = "Westminster, London, England, UK",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm1089991/?ref_=tt_ov_st_sm"
                     },
                    new Person
                    {
                        PersonName = "Cate Blanchett",
                        Biography = "Cate Blanchett was born on May 14, 1969 in Melbourne, Victoria, Australia, to June (Gamble), an Australian teacher and property developer, and Robert DeWitt Blanchett, Jr., an American advertising executive, " +
                        "originally from Texas. She has an older brother and a younger sister. When she was ten years old, her 40-year-old father died of a sudden ...",
                        Gender = "Female",
                        DateOfBirth = new DateTime(1969, 05, 04),
                        PlaceOfBirth = "Melbourne, Victoria, Australia",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0000949/?ref_=tt_ov_st_sm"
                    },
                    new Person
                    {
                        PersonName = "Chris Evans",
                        Biography = "Christopher Robert Evans began his acting career in typical fashion: performing in school productions and community theatre. He was born in Boston, Massachusetts, the son of Lisa (Capuano), " +
                        "who worked at the Concord Youth Theatre, and G. Robert Evans III, a dentist. His uncle is congressman Mike Capuano. Chris's father is of half German and half ...",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1981, 06, 13),
                        PlaceOfBirth = "Boston, Massachusetts, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0262635/?ref_=tt_ov_st_sm"
                    },
                    new Person
                    {
                        PersonName = "Joss Whedon",
                        Biography = "Joss Whedon is the middle of five brothers - his younger brothers are Jed Whedon and Zack Whedon. Both his father, Tom Whedon and his grandfather, John Whedon were successful television writers. " +
                        "Joss' mother, Lee Stearns, was a history teacher and she also wrote novels as Lee Whedon. Whedon was raised in New York and was educated at Riverdale ...",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1964, 06, 23),
                        PlaceOfBirth = "New York City, New York, USA",
                        IMDBPersonLink = @"https://www.imdb.com/name/nm0923736/?ref_=tt_ov_wr"
                    },

                     #endregion
                    #region 86-90 Movie People
                     new Person
                     {
                         PersonName = "Stan Lee",
                         Biography = "Stan Lee was an American comic-book writer, editor, and publisher, who was executive vice president and publisher of Marvel Comics. Stan was born in New York City, to Celia (Solomon) and Jack Lieber, a dress cutter. " +
                         "His parents were Romanian Jewish immigrants. Lee co-created Spider-Man, the Hulk, Doctor Strange, the Fantastic Four, Iron Man, ...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1922, 12, 28),
                         PlaceOfBirth = "New York City, New York, USA",
                         DateOfDeath = new DateTime(2018, 11, 12),
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0498278/?ref_=tt_ov_wr"
                     },
                      new Person
                     {
                         PersonName = "Samuel L. Jackson",
                         Biography = "Samuel L. Jackson is an American producer and highly prolific actor, having appeared in over 100 films, including Die Hard with a Vengeance (1995), Unbreakable (2000), Shaft (2000), Formula 51 (2001), Black Snake Moan (2006), " +
                         "Snakes on a Plane (2006), and the Star Wars prequel trilogy (1999-2005), as well as the Marvel Cinematic Universe. Samuel ...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1948, 12, 21),
                         PlaceOfBirth = "Washington, District of Columbia, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0000168/?ref_=tt_ov_st_sm"
                     },
                       new Person
                     {
                         PersonName = "Scarlett Johansson",
                         Biography = "Scarlett Johansson was born in New York City. Her mother, Melanie Sloan, is from a Jewish family from the Bronx, and her father, Karsten Johansson, is a Danish-born architect, from Copenhagen. She has a sister, " +
                         "Vanessa Johansson, who is also an actress, a brother, Adrian, a twin brother, Hunter Johansson, born three minutes after her, and a ... ",
                         Gender = "Female",
                         DateOfBirth = new DateTime(1984, 11, 22),
                         PlaceOfBirth = "New York City, New York, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0424060/?ref_=tt_ov_st_sm"
                     },
                       new Person
                     {
                         PersonName = "Zak Penn",
                         Biography = "Zak Penn's career began as a screenwriter when he sold his first script, Last Action Hero, at the age of twenty-three. Since then, Penn has become known for his work on numerous films based on Marvel comics, " +
                         "including X-Men 2 and X-Men: The Last Stand, The Incredible Hulk, and The Avengers. He has also dabbled in other genres, writing scripts for ...",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1968, 03, 23),
                         PlaceOfBirth = "New York, New York, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0672015/?ref_=tt_ov_wr"
                     },
                       new Person
                     {
                         PersonName = "Shane Black",
                         Biography = "Considered one of the pioneer screenwriters of the action genre, Black made his mark with his Lethal Weapon (1987) screenplay. He also collaborated on the story of the sequel, Lethal Weapon 2 (1989). " +
                         "Each successive script he turned in had a higher price attached it, from The Last Boy Scout (1991) to The Long Kiss Goodnight (1996), and in between a... ",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1961, 12, 16),
                         PlaceOfBirth = "Pittsburgh, Pennsylvania, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0000948/?ref_=tt_ov_dr"
                     },             

                     #endregion
                    #region 86-90 Movie People
                     new Person
                     {
                         PersonName = "Drew Pearce",
                         Biography = "Drew Pearce was born on August 24, 1975. He is a producer and writer, known for Hotel Artemis (2018), Iron Man 3 (2013) and Fast & Furious Presents: Hobbs & Shaw (2019).",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1975, 08, 24),

                         IMDBPersonLink = @"https://www.imdb.com/name/nm1510800/?ref_=tt_ov_wr"
                     },
                      new Person
                     {
                         PersonName = "Guy Pearce",
                         Biography = "Guy Edward Pearce was born 5 October, 1967 in Cambridgeshire, England, UK to Margaret Anne and Stuart Graham Pearce. His father was born in Auckland, New Zealand, to English and Scottish parents, while Guy's mother is English. " +
                         "Pearce and his family initially traveled to Australia for two years, after his father was offered the position of Chief ... ",
                         Gender = "Male",
                         DateOfBirth = new DateTime(1967, 10, 05),
                         PlaceOfBirth = "Cambridgeshire, England, UK",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0001602/?ref_=tt_ov_st_sm"
                     },
                       new Person
                     {
                         PersonName = "Gwyneth Paltrow",
                         Biography = "A tall, wafer thin, delicate beauty, Gwyneth Kate Paltrow was born in Los Angeles, the daughter of noted producer and director Bruce Paltrow and Tony Award-winning actress Blythe Danner. " +
                         "Her father was from a Jewish family, while her mother is of mostly German descent. When Gwyneth was eleven, the family moved to Massachusetts, where her father ...",
                         Gender = "Female",
                         DateOfBirth = new DateTime(1972, 09, 27),
                         PlaceOfBirth = "Los Angeles, California, USA",
                         IMDBPersonLink = @"https://www.imdb.com/name/nm0000569/?ref_=tt_ov_st_sm"
                     },
                                

                     #endregion
                };

                for (int i = 0; i < people.Length; i++)
                {
                    context.Person.Add(people[i]); ;
                    context.SaveChanges();
                }

                var movieRoles = new MovieRole[]
                {
                    new MovieRole { RoleName = "Director" },
                    new MovieRole { RoleName = "Writer" },
                    new MovieRole { RoleName = "Actor" }
                };

                for (int i = 0; i < movieRoles.Length; i++)
                {
                    context.MovieRole.Add(movieRoles[i]);
                    context.SaveChanges();
                }



                var movies = new Movie[] {
                #region 1 - Joker 
                new Movie
                {
                    MovieTitle = "Joker",
                    Summary = "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a " +
                       "downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.",
                    ReleaseDate = new DateTime(2019, 10, 04),
                    Runtime = 122,
                    IMDBLink = @"https://www.imdb.com/title/tt7286456/?ref_=hm_fanfav_tt_2_pd_fp1",
                    MoviePosterURL = "Joker.jpeg",
                    MoviePrice = 2.99,
                    MovieRating = 8.5,
                    MovieGenres = new List<MovieGenres>()
                        {
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Action").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Thriller").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Crime").GenreID},
                        },
                    MovieCastList = new List<MovieCast>
                        {
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Todd Phillips").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Todd Phillips").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName ==  "Scott Silver").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Joaquin Phoenix").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Robert De Niro").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Zazie Beetz").PersonID
                                }
                        }
                },
                #endregion
                #region 2 - Mary Magdalene 
                  new Movie
                  {
                      MovieTitle = "Mary Magdalene",
                      Summary = "Twelve men heard and spread the message of Jesus. Only one woman understood it.",
                      ReleaseDate = new DateTime(2018, 03, 16),
                      Runtime = 120,
                      IMDBLink = @"https://www.imdb.com/title/tt5360996/?ref_=fn_al_tt_1",
                      MoviePosterURL = "MaryMagdalene.jpeg",
                      MoviePrice = 2.99,
                      MovieRating = 5.8,
                      MovieGenres = new List<MovieGenres>()
                        {
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Biography").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Drama").GenreID}
                        },
                      MovieCastList = new List<MovieCast>
                        {
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Garth Davis").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Helen Edmundson").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName ==  "Philippa Goslett").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Rooney Mara").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Joaquin Phoenix").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chiwetel Ejiofor").PersonID
                                }
                        }
                  },
                #endregion
                #region 3 - Inception 
                     new Movie
                     {
                         MovieTitle = "Inception ",
                         Summary = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                         ReleaseDate = new DateTime(2010, 07, 16),
                         Runtime = 148,
                         IMDBLink = @"https://www.imdb.com/title/tt1375666/?ref_=hm_fanfav_tt_13_pd_fp1",
                         MoviePosterURL = "Inception.jpeg",
                         MoviePrice = 2.99,
                         MovieRating = 8.8,
                         MovieGenres = new List<MovieGenres>()
                        {
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Action").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Adventure").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Sci-fi").GenreID}
                        },
                      MovieCastList = new List<MovieCast>
                        {
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Nolan").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Nolan").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName ==  "Leonardo DiCaprio").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Joseph Gordon-Levitt").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Ellen Page").PersonID
                                }

                        }
                      },
                  #endregion
                #region 4 - The Dark Knight 
                     new Movie
                     {
                         MovieTitle = "The Dark Knight",
                         Summary = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                         ReleaseDate = new DateTime(2008, 07, 18),
                         Runtime = 152,
                         IMDBLink = @"https://www.imdb.com/title/tt0468569/?ref_=hm_fanfav_tt_17_pd_fp1",
                         MoviePosterURL = "TheDarkKnight.jpeg",
                         MoviePrice = 2.99,
                         MovieRating = 9.0,
                         MovieGenres = new List<MovieGenres>()
                         {
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Action").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Crime").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Drama").GenreID}
                         },
                      MovieCastList = new List<MovieCast>
                        {
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Nolan").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Nolan").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName ==  "Jonathan Nolan").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christian Bale").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Heath Ledger").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Aaron Eckhart").PersonID
                                }
                        }
                     },                   
                  #endregion
                #region 5 - Green Book
                     new Movie
                     {
                         MovieTitle = "Green Book",
                         Summary = "A working-class Italian-American bouncer becomes the driver of an African-American classical pianist on a tour of venues through the 1960s American South.",
                         ReleaseDate = new DateTime(2018, 11, 16),
                         Runtime = 130,
                         IMDBLink = @"https://www.imdb.com/title/tt6966692/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=N7CZCZ1SSBKCDBH8RKYJ&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_130",
                         MoviePosterURL = "GreenBook.jpeg",
                         MoviePrice = 2.99,
                         MovieRating = 8.2,
                         MovieGenres = new List<MovieGenres>()
                         {
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Biography").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Comedy").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Drama").GenreID}
                         },
                      MovieCastList = new List<MovieCast>
                        {
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Peter Farrelly").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Nick Vallelonga").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName ==  "Brian Hayes Currie").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Viggo Mortensen").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Mahershala Ali").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Linda Cardellini").PersonID
                                }
                        }
                     },
                  #endregion
                #region 6 - Moonlight 
                     new Movie
                     {
                         MovieTitle = "Moonlight ",
                         Summary = "A young African-American man grapples with his identity and sexuality while experiencing the everyday struggles of childhood, adolescence, and burgeoning adulthood.",
                         ReleaseDate = new DateTime(2016, 11, 18),
                         Runtime = 111,
                         IMDBLink = @"https://www.imdb.com/title/tt4975722/?ref_=nv_sr_srsg_0",
                         MoviePosterURL = "Moonlight.jpg",
                         MoviePrice = 2.99,
                         MovieRating = 7.4,
                         MovieGenres = new List<MovieGenres>()
                         {
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Drama").GenreID}
                         },
                      MovieCastList = new List<MovieCast>
                        {
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Barry Jenkins").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Barry Jenkins").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Mahershala Ali").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Naomie Harris").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Trevante Rhodes").PersonID
                                }
                        }
                     },
                  #endregion
                #region 7 - Bright 
                     new Movie
                     {
                         MovieTitle = "Bright",
                         Summary = "A detective must work with an Orc to find a powerful wand before evil creatures do.",
                         ReleaseDate = new DateTime(2017, 12, 22),
                         Runtime = 117,
                         IMDBLink = @"https://www.imdb.com/title/tt5519340/?ref_=nv_sr_srsg_2",
                         MoviePosterURL = "Bright.jpeg",
                         MoviePrice = 2.99,
                         MovieRating = 6.3,
                         MovieGenres = new List<MovieGenres>()
                         {
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Action").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Thriller").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Fantasy").GenreID}
                         },
                      MovieCastList = new List<MovieCast>
                        {
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "David Ayer").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Max Landis").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Will Smith").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Joel Edgerton").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Noomi Rapace").PersonID
                                }
                        }
                     },
                  #endregion
                #region 8 - Tomb Raider
                     new Movie
                     {
                         MovieTitle = "Tomb Raider",
                         Summary = "Lara Croft (Alicia Vikander), the fiercely independent daughter of a missing adventurer, " +
                         "must push herself beyond her limits when she discovers the island where her father, Lord Richard Croft (Dominic West) disappeared.",
                         ReleaseDate = new DateTime(2018, 03, 16),
                         Runtime = 119,
                         IMDBLink = @"https://www.imdb.com/title/tt1365519/?ref_=nv_sr_srsg_0",
                         MoviePosterURL = "TombRaider.jpeg",
                         MoviePrice = 2.99,
                         MovieRating = 6.3,
                         MovieGenres = new List<MovieGenres>()
                         {
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Action").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Adventure").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Fantasy").GenreID}
                         },
                      MovieCastList = new List<MovieCast>
                        {
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Roar Uthaug").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Geneva Robertson-Dworet").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Alicia Vikander").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Dominic West").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Walton Goggins").PersonID
                                }
                        }
                     },
                  #endregion
                #region 9 - Inglourious Basterds 
                     new Movie
                     {
                         MovieTitle = "Inglourious Basterds",
                         Summary = "In Nazi-occupied France during World War II, a plan to assassinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same.",
                         ReleaseDate = new DateTime(2009, 08, 21),
                         Runtime = 155,
                         IMDBLink = @"https://www.imdb.com/title/tt0361748/?ref_=hm_stp_pvs_piv_tt_3",
                         MoviePosterURL = "IngloriousBasterds.jpeg",
                         MoviePrice = 2.99,
                         MovieRating = 8.3,
                         MovieGenres = new List<MovieGenres>()
                         {
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Drama").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "Adventure").GenreID},
                                new MovieGenres{GenreID =  genres.Single(x=>x.GenreName == "War").GenreID}
                         },
                      MovieCastList = new List<MovieCast>
                        {
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Quentin Tarantino").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Quentin Tarantino").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Brad Pitt").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Eli Roth").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Diane Kruger").PersonID
                                }
                        }
                     },
                  #endregion
                #region 10 - Fight Club  
                  new Movie
                  {
                      MovieTitle = "Fight Club",
                      Summary = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.",
                      ReleaseDate = new DateTime(1999, 10, 15),
                      Runtime = 139,
                      IMDBLink = @"https://www.imdb.com/title/tt0137523/?ref_=hm_fanfav_tt_29_pd_fp1",
                      MoviePosterURL = "FightClub.jpeg",
                      MoviePrice = 2.99,
                      MovieRating = 8.8,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Drama").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                              new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "David Fincher").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chuck Palahniuk").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName ==  "Jim Uhls").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Brad Pitt").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Edward Norton").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Meat Loaf").PersonID
                                }
                      }
                  },
               #endregion
                #region 11 - Interstellar  
                  new Movie
                  {
                      MovieTitle = "Interstellar",
                      Summary = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                      ReleaseDate = new DateTime(2014, 11, 07),
                      Runtime = 169,
                      IMDBLink = @"https://www.imdb.com/title/tt0816692/?ref_=hm_fanfav_tt_14_pd_fp1",
                      MoviePosterURL = "Interstellar.jpeg",
                      MoviePrice = 2.99,
                      MovieRating = 8.6,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Drama").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Sci-fi").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                              new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Nolan").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Nolan").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName ==  "Jonathan Nolan").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Matthew McConaughey").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Anne Hathaway").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName =="Jessica Chastain").PersonID
                                }
                      }
                  },
               #endregion
                #region 12 - Deadpool 2
                  new Movie
                  {
                      MovieTitle = "Deadpool 2",
                      Summary = "Foul-mouthed mutant mercenary Wade Wilson (a.k.a. Deadpool), brings together a team of fellow mutant rogues to protect a young boy with supernatural abilities from the brutal, time-traveling cyborg Cable.",
                      ReleaseDate = new DateTime(2018, 05, 18),
                      Runtime = 119,
                      IMDBLink = @"https://www.imdb.com/title/tt5463162/?ref_=nm_flmg_act_5",
                      MoviePosterURL = "Deadpool2.jpeg",
                      MoviePrice = 2.99,
                      MovieRating = 7.7,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Comedy").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                              new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "David Leitch").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Rhett Reese").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName ==  "Paul Wernick").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Ryan Reynolds").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Josh Brolin").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName =="Morena Baccarin").PersonID
                                }
                      }
                  },
               #endregion
                #region 13 - Deadpool 
                  new Movie
                  {
                      MovieTitle = "Deadpool",
                      Summary = "A wisecracking mercenary gets experimented on and becomes immortal but ugly, and sets out to track down the man who ruined his looks.",
                      ReleaseDate = new DateTime(2016, 02, 12),
                      Runtime = 119,
                      IMDBLink = @"https://www.imdb.com/title/tt1431045/?ref_=nm_knf_i2",
                      MoviePosterURL = "Deadpool.jpeg",
                      MoviePrice = 2.99,
                      MovieRating = 8.0,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Comedy").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                              new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Tim Miller").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Rhett Reese").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName ==  "Paul Wernick").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Ryan Reynolds").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Morena Baccarin").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "T.J. Miller").PersonID
                                }
                      }
                  },
                  #endregion
                #region 14 - The Tourist 
                  new Movie
                  {
                      MovieTitle = "The Tourist",
                      Summary = "Revolves around Frank, an American tourist visiting Italy to mend a broken heart. Elise is an extraordinary woman who deliberately crosses his path.",
                      ReleaseDate = new DateTime(2010, 12, 10),
                      Runtime = 103,
                      IMDBLink = @"https://www.imdb.com/title/tt1243957/?ref_=nv_sr_srsg_0",
                      MoviePosterURL = "TheTourist.jpg",
                      MoviePrice = 2.99,
                      MovieRating = 6.0,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Crime").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                              new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Florian Henckel von Donnersmarck").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Florian Henckel von Donnersmarck").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Johnny Depp").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Angelina Jolie").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Paul Bettany").PersonID
                                }
                      }
                  },
                  #endregion
                #region 15 - Mr. & Mrs. Smith 
                  new Movie
                  {
                      MovieTitle = "Mr. & Mrs. Smith",
                      Summary = "A bored married couple is surprised to learn that they are both assassins hired by competing agencies to kill each other.",
                      ReleaseDate = new DateTime(2005, 06, 10),
                      Runtime = 120,
                      IMDBLink = @"https://www.imdb.com/title/tt0356910/?ref_=fn_al_tt_1",
                      MoviePosterURL = "MrMrsSmith.jpg",
                      MoviePrice = 2.99,
                      MovieRating = 6.5,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Comedy").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Crime").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                              new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Doug Liman").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Simon Kinberg").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Brad Pitt").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Angelina Jolie").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Adam Brody").PersonID
                                }
                      }
                  },
                  #endregion
                #region 16 - Guardians of the Galaxy 
                  new Movie
                  {
                      MovieTitle = "Guardians of the Galaxy",
                      Summary = "A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.",
                      ReleaseDate = new DateTime(2014, 08, 01),
                      Runtime = 121,
                      IMDBLink = @"https://www.imdb.com/title/tt2015381/?ref_=adv_li_i",
                      MoviePosterURL = "GuardiansOfTheGalaxy.jpg",
                      MoviePrice = 2.99,
                      MovieRating = 8.0,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Comedy").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                                 new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "James Gunn").PersonID
                                 },
                               new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "James Gunn").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Nicole Perlman").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chris Pratt").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Vin Diesel").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Bradley Cooper").PersonID
                                }
                      }
                  },
                  #endregion
                #region 17 - Guardians of the Galaxy Vol. 2
                    new Movie
                    {
                        MovieTitle = "Guardians of the Galaxy Vol. 2",
                        Summary = "The Guardians struggle to keep together as a team while dealing with their personal family issues, " +
                        "notably Star-Lord's encounter with his father the ambitious celestial being Ego.",
                        ReleaseDate = new DateTime(2017, 05, 05),
                        Runtime = 136,
                        IMDBLink = @"https://www.imdb.com/title/tt3896198/?ref_=adv_li_i",
                        MoviePosterURL = "GuardiansOfTheGalaxy2.jpg",
                        MoviePrice = 2.99,
                        MovieRating = 7.6,
                        MovieGenres = new List<MovieGenres>()
                        {
                                new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                                new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Comedy").GenreID},
                                new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID}
                        },
                        MovieCastList = new List<MovieCast>
                        {
                                    new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "James Gunn").PersonID
                                    },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "James Gunn").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Dan Abnett").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chris Pratt").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Zoe Saldana").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Dave Bautista").PersonID
                                }
                        }
                    },
                    #endregion
                #region 18 - Avengers: Infinity War
                    new Movie
                    {
                        MovieTitle = "Avengers: Infinity War",
                        Summary = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before " +
                        "his blitz of devastation and ruin puts an end to the universe.",
                        ReleaseDate = new DateTime(2017, 05, 05),
                        Runtime = 149,
                        IMDBLink = @"https://www.imdb.com/title/tt4154756/?ref_=adv_li_i",
                        MoviePosterURL = "AvengersInfinityWar.jpg",
                        MoviePrice = 2.99,
                        MovieRating = 8.5,
                        MovieGenres = new List<MovieGenres>()
                        {
                                new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                                new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Sci-fi").GenreID},
                                new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID}
                        },
                        MovieCastList = new List<MovieCast>
                        {
                                    new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Anthony Russo").PersonID
                                    },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Markus").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Stephen McFeely").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Robert Downey Jr.").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chris Hemsworth").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Mark Ruffalo").PersonID
                                }
                        }
                    },
                    #endregion
                #region 19 - Thor: Ragnarok
                    new Movie
                    {
                        MovieTitle = "Thor: Ragnarok",
                        Summary = "Imprisoned on the planet Sakaar, Thor must race against time to return to Asgard and stop Ragnarök, " +
                        "the destruction of his world, at the hands of the powerful and ruthless villain Hela.",
                        ReleaseDate = new DateTime(2017, 11, 03),
                        Runtime = 130,
                        IMDBLink = @"https://www.imdb.com/title/tt3501632/?ref_=adv_li_i",
                        MoviePosterURL = "ThorRagnarok.jpg",
                        MoviePrice = 2.99,
                        MovieRating = 7.9,
                        MovieGenres = new List<MovieGenres>()
                        {
                                new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                                new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID},
                                new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Comedy").GenreID}
                        },
                        MovieCastList = new List<MovieCast>
                        {
                                    new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Taika Waititi").PersonID
                                    },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Eric Pearson").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Craig Kyle").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chris Hemsworth").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Tom Hiddleston").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Cate Blanchett").PersonID
                                }
                        }
                    },
                    #endregion
                #region 20 - Avengers: Endgame
                  new Movie
                  {
                      MovieTitle = "Avengers: Endgame",
                      Summary = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. " +
                      "With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
                      ReleaseDate = new DateTime(2017, 11, 03),
                      Runtime = 181,
                      IMDBLink = @"https://www.imdb.com/title/tt3501632/?ref_=adv_li_i",
                      MoviePosterURL = "AvengersEndgame.jpg",
                      MoviePrice = 2.99,
                      MovieRating = 8.4,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Drama").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                                 new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Anthony Russo").PersonID
                                 },
                               new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Markus").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Stephen McFeely").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Robert Downey Jr.").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chris Evans").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Mark Ruffalo").PersonID
                                }
                      }
                  },
                  #endregion
                #region 21 - Avengers: Age of Ultron
                  new Movie
                  {
                      MovieTitle = "Avengers: Age of Ultron",
                      Summary = "When Tony Stark and Bruce Banner try to jump-start a dormant peacekeeping program called Ultron, " +
                      "things go horribly wrong and it's up to Earth's mightiest heroes to stop the villainous Ultron from enacting his terrible plan.",
                      ReleaseDate = new DateTime(2015, 01, 15),
                      Runtime = 181,
                      IMDBLink = @"https://www.imdb.com/title/tt3501632/?ref_=adv_li_i",
                      MoviePosterURL = "AvengersAgeOfUltron.jpg",
                      MoviePrice = 2.99,
                      MovieRating = 7.3,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Sci-fi").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                                 new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Joss Whedon").PersonID
                                 },
                               new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Joss Whedon").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Stan Lee").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Robert Downey Jr.").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chris Evans").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Mark Ruffalo").PersonID
                                }
                      }
                  },
                  #endregion
                #region 22 - Captain America: The Winter Soldier
                  new Movie
                  {
                      MovieTitle = "Captain America: The Winter Soldier",
                      Summary = "As Steve Rogers struggles to embrace his role in the modern world, he teams up with a fellow Avenger and S.H.I.E.L.D agent, " +
                      "Black Widow, to battle a new threat from history: an assassin known as the Winter Soldier.",
                      ReleaseDate = new DateTime(2014, 04, 04),
                      Runtime = 136,
                      IMDBLink = @"https://www.imdb.com/title/tt1843866/?ref_=adv_li_i",
                      MoviePosterURL = "CaptainAmericaTheWinterSoldier.jpg",
                      MoviePrice = 2.99,
                      MovieRating = 7.7,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Sci-fi").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                                 new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Anthony Russo").PersonID
                                 },
                               new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Markus").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Stephen McFeely").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chris Evans").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Samuel L. Jackson").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Scarlett Johansson").PersonID
                                }
                      }
                  },
                  #endregion
                #region 23 - Captain America: Civil War
                  new Movie
                  {
                      MovieTitle = "Captain America: Civil War",
                      Summary = "Political involvement in the Avengers' affairs causes a rift between Captain America and Iron Man.",
                      ReleaseDate = new DateTime(2014, 04, 04),
                      Runtime = 147,
                      IMDBLink = @"https://www.imdb.com/title/tt3498820/?ref_=adv_li_tt",
                      MoviePosterURL = "CaptainAmericaCivilWar.jpg",
                      MoviePrice = 2.99,
                      MovieRating = 7.8,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Sci-fi").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                                 new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Anthony Russo").PersonID
                                 },
                               new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Christopher Markus").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Stephen McFeely").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chris Evans").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Robert Downey Jr.").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Scarlett Johansson").PersonID
                                }
                      }
                  },
                  #endregion
                #region 24 - The Avengers
                  new Movie
                  {
                      MovieTitle = "The Avengers",
                      Summary = "Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.",
                      ReleaseDate = new DateTime(2014, 04, 04),
                      Runtime = 143,
                      IMDBLink = @"https://www.imdb.com/title/tt0848228/?ref_=adv_li_i",
                      MoviePosterURL = "TheAvengers.jpg",
                      MoviePrice = 2.99,
                      MovieRating = 8.0,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Sci-fi").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                                 new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Joss Whedon").PersonID
                                 },
                               new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Joss Whedon").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Zak Penn").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Robert Downey Jr.").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Chris Evans").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Scarlett Johansson").PersonID
                                }
                      }
                  },
                  #endregion
                #region 25 - Iron Man 3
                  new Movie
                  {
                      MovieTitle = "Iron Man 3",
                      Summary = "When Tony Stark's world is torn apart by a formidable terrorist called the Mandarin, he starts an odyssey of rebuilding and retribution.",
                      ReleaseDate = new DateTime(2014, 05, 03),
                      Runtime = 130,
                      IMDBLink = @"https://www.imdb.com/title/tt1300854/?ref_=adv_li_i",
                      MoviePosterURL = "IronMan3.jpg",
                      MoviePrice = 2.99,
                      MovieRating = 7.2,
                      MovieGenres = new List<MovieGenres>()
                      {
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Action").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Adventure").GenreID},
                               new MovieGenres{GenreID = genres.Single(x => x.GenreName == "Sci-fi").GenreID}
                      },
                      MovieCastList = new List<MovieCast>
                      {
                                 new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Director").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Shane Black").PersonID
                                 },
                               new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Drew Pearce").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Writer").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Shane Black").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Robert Downey Jr.").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Guy Pearce").PersonID
                                },
                                new MovieCast{
                                    MovieRoleID = movieRoles.Single(x => x.RoleName == "Actor").RoleID,
                                    PersonID = people.Single(x => x.PersonName == "Gwyneth Paltrow").PersonID
                                }
                      }
                  }
                  #endregion

                };


                for (int i = 0; i < movies.Length; i++)
                {
                    context.Add(movies[i]);
                    context.SaveChanges();
                }

            }
        }
    }
}