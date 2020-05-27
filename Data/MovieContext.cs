using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieWeb.Data.Entities;

namespace MovieWeb.Data
{
    public class MovieContext : IdentityDbContext
    {

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieRole> MovieRole { get; set; }
        public DbSet<MovieGenres> MovieGenres { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MovieCast>()
                .HasKey(e => new { e.MovieID, e.MovieRoleID, e.PersonID });

            builder.Entity<MovieCast>().HasOne(mc => mc.Movie).WithMany(m => m.MovieCastList).HasForeignKey(mc => mc.MovieID);
            builder.Entity<MovieCast>().HasOne(mc => mc.MovieRole).WithMany(mr => mr.MovieCast).HasForeignKey(mc => mc.MovieRoleID);
            builder.Entity<MovieCast>().HasOne(mc => mc.Person).WithMany(p => p.MovieCast).HasForeignKey(mc => mc.PersonID);

            builder.Entity<MovieGenres>()
                .HasKey(e => new { e.MovieID, e.GenreID });

            builder.Entity<MovieGenres>().HasOne(mc => mc.Movie).WithMany(m => m.MovieGenres).HasForeignKey(mc => mc.MovieID);
            builder.Entity<MovieGenres>().HasOne(mc => mc.Genre).WithMany(p => p.MovieGenres).HasForeignKey(mc => mc.GenreID);



            const string ADMIN_ID = "b4280b6a-0613-4cbd-a9e6-f1701e926e73";
            const string ROLE_ID = ADMIN_ID;
            var passwordFromSettings = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetSection("AdminCredentials")["Password"];

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ID,
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e74",
                    Name = "editor",
                    NormalizedName = "EDITOR"
                },
                new IdentityRole
                {
                    Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                    Name = "guest",
                    NormalizedName = "GUEST"
                }
            );

            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = ADMIN_ID,
                UserName = "admin@movieweb.com",
                NormalizedUserName = "ADMIN@MOVIEWEB.COM",
                Email = "admin@movieweb.com",
                NormalizedEmail = "ADMIN@MOVIEWEB.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, passwordFromSettings),
                SecurityStamp = string.Empty,
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58"
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
