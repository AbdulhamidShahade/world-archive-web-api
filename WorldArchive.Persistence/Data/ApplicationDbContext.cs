using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldArchive.Domain.Models;

namespace WorldArchive.Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actress> Actresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryLanguage> CountriesLanguages { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieActor> MoviesActors { get; set; }
        public DbSet<MovieActress> MoviesActresses { get; set; }
        public DbSet<MovieLanguage> MoviesLanguages { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<University> Universities { get; set; }
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .HasOne(u => u.University)
                .WithMany(a => a.Actors)
                .HasForeignKey(fk => fk.UniversityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Actor>()
                .HasOne(c => c.City)
                .WithMany(a => a.Actors)
                .HasForeignKey(fk => fk.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Actress>()
                .HasOne(u => u.University)
                .WithMany(a => a.Actresses)
                .HasForeignKey(fk => fk.UniversityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Actress>()
                .HasOne(c => c.City)
                .WithMany(a => a.Actress)
                .HasForeignKey(fk => fk.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<City>()
                .HasOne(c => c.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(fk => fk.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<City>()
                .HasMany(u => u.Universities)
                .WithOne(c => c.City)
                .HasForeignKey(fk => fk.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<City>()
                .HasMany(c => c.Companies)
                .WithOne(c => c.City)
                .HasForeignKey(fk => fk.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<City>()
                .HasMany(f => f.Foods)
                .WithOne(c => c.City)
                .HasForeignKey(fk => fk.CityId)
                .OnDelete(DeleteBehavior.Restrict);  

            modelBuilder.Entity<City>()
                .HasMany(p => p.Players)
                .WithOne(c => c.City)
                .HasForeignKey(fk => fk.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Country>()
                .HasMany(m => m.Movies)
                .WithOne(c => c.Country)
                .HasForeignKey(fk => fk.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Country>()
                .HasOne(r => r.Region)
                .WithMany(c => c.Countries)
                .HasForeignKey(fk => fk.RegionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CountryLanguage>()
                .HasOne(c => c.Country)
                .WithMany(l => l.Languages)
                .HasForeignKey(fk => fk.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CountryLanguage>()
                .HasOne(l => l.Language)
                .WithMany(c => c.Countries)
                .HasForeignKey(fk => fk.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MovieActor>()
                .HasOne(a => a.Actor)
                .WithMany(m => m.Movies)
                .HasForeignKey(fk => fk.ActorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MovieActor>()
                .HasOne(m => m.Movie)
                .WithMany(a => a.Actors)
                .HasForeignKey(fk => fk.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MovieActress>()
                .HasOne(m => m.Movie)
                .WithMany(a => a.Actresses)
                .HasForeignKey(fk => fk.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MovieActress>()
                .HasOne(a => a.Actress)
                .WithMany(m => m.Movies)
                .HasForeignKey(fk => fk.ActressId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MovieLanguage>()
                .HasOne(m => m.Movie)
                .WithMany(l => l.Languages)
                .HasForeignKey(fk => fk.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MovieLanguage>()
                .HasOne(l => l.Language)
                .WithMany(m => m.Movies)
                .HasForeignKey(fk => fk.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Player>()
                .HasOne(s => s.Sport)
                .WithMany(p => p.Players)
                .HasForeignKey(fk => fk.SportId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Player>()
                .HasOne(u => u.University)
                .WithMany(p => p.Players)
                .HasForeignKey(fk => fk.UniversityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
