using Microsoft.AspNetCore.Identity;
using VBAPproj.Data.Static;
using VBAPproj.Models;

namespace VBAPproj.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "hmm",
                            Description = "This is the description of first cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "hmm",
                            Description = "This is the description of second cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "hmm",
                            Description = "This is the description of third cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "hmm",
                            Description = "This is the description of fourth cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "hmm",
                            Description = "This is the description of fifth cinema."
                        },
                    });
                    context.SaveChanges();
                }
                //actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the bio of first actor."
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the bio of second actor."
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the bio of third actor."
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the bio of fourth actor."
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the bio of fifth actor."
                        },
                    });
                    context.SaveChanges();
                }
                //producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the bio of first producer."
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the bio of second producer."
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the bio of third producer."
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the bio of fourth producer."
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the bio of fifth producer."
                        },
                    });
                    context.SaveChanges();
                }
                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie 1",
                            Description = "This is the description of first movie.",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-8),
                            CinemaId = 5,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Movie 2",
                            Description = "This is the description of second movie.",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-8),
                            EndDate = DateTime.Now.AddDays(-6),
                            CinemaId = 6,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Movie 3",
                            Description = "This is the description of third movie.",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-6),
                            EndDate = DateTime.Now.AddDays(-4),
                            CinemaId = 7,
                            ProducerId = 4,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Movie 4",
                            Description = "This is the description of fourth movie.",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-4),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 8,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Movie 5",
                            Description = "This is the description of fifth movie.",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-2),
                            EndDate = DateTime.Now,
                            CinemaId = 9,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Documentary
                        },
                    });
                    context.SaveChanges();
                }
                //actors and movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 18
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 19
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 20
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 20
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 21
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 21
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 22
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 22
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 22
                        },

                    });
                    context.SaveChanges();
                }

            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }


                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@VPABproj.com";
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin user",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@VPABproj.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application user",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true,
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
