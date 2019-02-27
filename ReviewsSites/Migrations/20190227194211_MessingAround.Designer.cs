﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSites;

namespace ReviewsSites.Migrations
{
    [DbContext(typeof(ReviewsContext))]
    [Migration("20190227194211_MessingAround")]
    partial class MessingAround
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSites.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Style");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 2, Style = "IPA" }
                    );
                });

            modelBuilder.Entity("ReviewsSites.Models.Reviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Abv");

                    b.Property<string>("Beer");

                    b.Property<string>("Brewery");

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("ImgPath");

                    b.Property<float>("Rating");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Review");

                    b.HasData(
                        new { Id = 1, Abv = 6.2f, Beer = "Zombie Dust", Brewery = "Three Floyds", Description = "This intensely hopped and gushing undead Pale Ale will be one’s only respite after the zombie apocalypse. Created with our marvelous friends in the comic industry.", ImgPath = "/Images/Zombiedust.png", Rating = 4.8f },
                        new { Id = 2, Abv = 10f, Beer = "Hopslam", Brewery = "Bells", Description = "Starting with six different hop varietals added to the brew kettle & culminating with a massive dry-hop addition of Simcoe hops, Bell's Hopslam Ale possesses the most complex hopping schedule in the Bell's repertoire. Selected specifically because of their aromatic qualities, these Pacific Northwest varieties contribute a pungent blend of grapefruit, stone fruit and floral notes. A generous malt bill and a solid dollop of honey provide just enough body to keep the balance in check, resulting in a remarkably drinkable rendition of the Double India Pale Ale style.", ImgPath = "/Images/Hopslam.png", Rating = 4.6f },
                        new { Id = 3, Abv = 7.8f, Beer = "Boomsauce", Brewery = "Lord Hobo", Description = "Our flagship IPA features six hop varietals and a blend of spelt, oat and wheat. A late hop addition of Mosaic, Falconer’s Flight and Amarillo delivers a notable citrus and tropical fruit finish.", ImgPath = "/Images/Boomsauce.png", Rating = 3f }
                    );
                });

            modelBuilder.Entity("ReviewsSites.Models.Reviews", b =>
                {
                    b.HasOne("ReviewsSites.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
