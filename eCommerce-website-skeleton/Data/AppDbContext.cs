using eCommerce_website_skeleton.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_website_skeleton.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new 
            {
                am.ActorID,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actors).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ActorID);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actors> Actors { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        //Orders related tables
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}


    }
}
