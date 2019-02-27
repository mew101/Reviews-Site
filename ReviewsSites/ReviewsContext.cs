﻿using Microsoft.EntityFrameworkCore;
using ReviewsSites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites
{
    public class ReviewsContext : DbContext
    {
        public DbSet<Reviews> Review { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BeerdsReviews;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reviews>().HasData(
                 new Reviews() { Id = 1,
                     Beer = "Zombie Dust",
                     Abv = 6.20f,
                     Brewery = "Three Floyds",
                     Rating = 4.8f,
                     Description = "This intensely hopped and gushing undead Pale Ale will be one’s only respite after the zombie apocalypse. Created with our marvelous friends in the comic industry.",
                     ImgPath = "/Images/Zombiedust.png" },
                 new Reviews() { Id = 2, Beer = "Hopslam", Abv = 10.00f, Brewery = "Bells", Rating = 4.6f, Description = "Starting with six different hop varietals added to the brew kettle & culminating with a massive dry-hop addition of Simcoe hops, Bell's Hopslam Ale possesses the most complex hopping schedule in the Bell's repertoire. Selected specifically because of their aromatic qualities, these Pacific Northwest varieties contribute a pungent blend of grapefruit, stone fruit and floral notes. A generous malt bill and a solid dollop of honey provide just enough body to keep the balance in check, resulting in a remarkably drinkable rendition of the Double India Pale Ale style.", ImgPath = "/Images/Hopslam.png" },
                 new Reviews() { Id = 3, Beer = "Boomsauce", Abv = 7.80f, Brewery = "Lord Hobo", Rating = 3.0f, Description = "Our flagship IPA features six hop varietals and a blend of spelt, oat and wheat. A late hop addition of Mosaic, Falconer’s Flight and Amarillo delivers a notable citrus and tropical fruit finish.", ImgPath = "/Images/Boomsauce.png" }
                       );
            base.OnModelCreating(modelBuilder);
        }
    }
}