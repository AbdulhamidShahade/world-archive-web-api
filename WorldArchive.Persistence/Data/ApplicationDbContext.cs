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
        public DbSet<Map> Maps { get; set; }
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
            
        }
    }
}
