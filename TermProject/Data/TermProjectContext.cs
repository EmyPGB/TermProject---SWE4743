using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TermProject.Models;

namespace TermProject.Data
{ 
    public class TermProjectContext : DbContext
    {
        public TermProjectContext (DbContextOptions<TermProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Package> Packages { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Traveler> Travelers { get; set; }
        public DbSet<TripPackage> TripPackages { get; set; }
        public DbSet<AgentTrip> AgentTrips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>().ToTable("Package");
            modelBuilder.Entity<Trip>().ToTable("Trip");
            modelBuilder.Entity<Agent>().ToTable("Agent");
            modelBuilder.Entity<Traveler>().ToTable("Traveler");
            modelBuilder.Entity<TripPackage>().ToTable("TripPackage");
            modelBuilder.Entity<AgentTrip>().ToTable("AgentTrip");
        }
    }
}
