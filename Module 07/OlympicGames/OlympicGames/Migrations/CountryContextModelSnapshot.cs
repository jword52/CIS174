﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicGames.Models;

#nullable disable

namespace OlympicGames.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OlympicGames.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlagImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocationID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryID");

                    b.HasIndex("GameID");

                    b.HasIndex("LocationID");

                    b.HasIndex("SportID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "CA",
                            CountryName = "Canada",
                            FlagImg = "CA.png",
                            GameID = "wo",
                            LocationID = "in",
                            SportID = "cur"
                        },
                        new
                        {
                            CountryID = "SE",
                            CountryName = "Sweden",
                            FlagImg = "SE.png",
                            GameID = "wo",
                            LocationID = "in",
                            SportID = "cur"
                        },
                        new
                        {
                            CountryID = "GB",
                            CountryName = "Great Britain",
                            FlagImg = "GB.png",
                            GameID = "wo",
                            LocationID = "in",
                            SportID = "cur"
                        },
                        new
                        {
                            CountryID = "JM",
                            CountryName = "Jamaica",
                            FlagImg = "JM.png",
                            GameID = "wo",
                            LocationID = "out",
                            SportID = "bob"
                        },
                        new
                        {
                            CountryID = "IT",
                            CountryName = "Italy",
                            FlagImg = "IT.png",
                            GameID = "wo",
                            LocationID = "out",
                            SportID = "bob"
                        },
                        new
                        {
                            CountryID = "JP",
                            CountryName = "Japan",
                            FlagImg = "JP.png",
                            GameID = "wo",
                            LocationID = "out",
                            SportID = "bob"
                        },
                        new
                        {
                            CountryID = "DE",
                            CountryName = "Germany",
                            FlagImg = "DE.png",
                            GameID = "so",
                            LocationID = "in",
                            SportID = "div"
                        },
                        new
                        {
                            CountryID = "CN",
                            CountryName = "China",
                            FlagImg = "CN.png",
                            GameID = "so",
                            LocationID = "in",
                            SportID = "div"
                        },
                        new
                        {
                            CountryID = "MX",
                            CountryName = "Mexico",
                            FlagImg = "MX.png",
                            GameID = "so",
                            LocationID = "in",
                            SportID = "div"
                        },
                        new
                        {
                            CountryID = "BR",
                            CountryName = "Brazil",
                            FlagImg = "BR.png",
                            GameID = "so",
                            LocationID = "out",
                            SportID = "cyc"
                        },
                        new
                        {
                            CountryID = "NL",
                            CountryName = "Netherlands",
                            FlagImg = "NL.png",
                            GameID = "so",
                            LocationID = "out",
                            SportID = "cyc"
                        },
                        new
                        {
                            CountryID = "US",
                            CountryName = "USA",
                            FlagImg = "US.png",
                            GameID = "so",
                            LocationID = "out",
                            SportID = "cyc"
                        },
                        new
                        {
                            CountryID = "TH",
                            CountryName = "Thailand",
                            FlagImg = "TH.png",
                            GameID = "po",
                            LocationID = "in",
                            SportID = "arc"
                        },
                        new
                        {
                            CountryID = "UY",
                            CountryName = "Uruguay",
                            FlagImg = "UY.png",
                            GameID = "po",
                            LocationID = "in",
                            SportID = "arc"
                        },
                        new
                        {
                            CountryID = "UA",
                            CountryName = "Ukraine",
                            FlagImg = "UA.png",
                            GameID = "po",
                            LocationID = "in",
                            SportID = "arc"
                        },
                        new
                        {
                            CountryID = "AT",
                            CountryName = "Austria",
                            FlagImg = "AT.png",
                            GameID = "po",
                            LocationID = "out",
                            SportID = "can"
                        },
                        new
                        {
                            CountryID = "PK",
                            CountryName = "Pakistan",
                            FlagImg = "PK.png",
                            GameID = "po",
                            LocationID = "out",
                            SportID = "can"
                        },
                        new
                        {
                            CountryID = "ZW",
                            CountryName = "Zimbabwe",
                            FlagImg = "ZW.png",
                            GameID = "po",
                            LocationID = "out",
                            SportID = "can"
                        },
                        new
                        {
                            CountryID = "FR",
                            CountryName = "France",
                            FlagImg = "FR.png",
                            GameID = "yo",
                            LocationID = "in",
                            SportID = "bre"
                        },
                        new
                        {
                            CountryID = "CY",
                            CountryName = "Cyprus",
                            FlagImg = "CY.png",
                            GameID = "yo",
                            LocationID = "in",
                            SportID = "bre"
                        },
                        new
                        {
                            CountryID = "RU",
                            CountryName = "Russia",
                            FlagImg = "RU.png",
                            GameID = "yo",
                            LocationID = "in",
                            SportID = "bre"
                        },
                        new
                        {
                            CountryID = "FI",
                            CountryName = "Finland",
                            FlagImg = "FI.png",
                            GameID = "yo",
                            LocationID = "out",
                            SportID = "ska"
                        },
                        new
                        {
                            CountryID = "SK",
                            CountryName = "Slovakia",
                            FlagImg = "SK.png",
                            GameID = "yo",
                            LocationID = "out",
                            SportID = "ska"
                        },
                        new
                        {
                            CountryID = "PT",
                            CountryName = "Portugal",
                            FlagImg = "PT.png",
                            GameID = "yo",
                            LocationID = "out",
                            SportID = "ska"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "wo",
                            GameName = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "so",
                            GameName = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "po",
                            GameName = "Paralympics"
                        },
                        new
                        {
                            GameID = "yo",
                            GameName = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Location", b =>
                {
                    b.Property<string>("LocationID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationID = "in",
                            LocationName = "Indoors"
                        },
                        new
                        {
                            LocationID = "out",
                            LocationName = "Outdoors"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Sport", b =>
                {
                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportID");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportID = "cur",
                            SportName = "Curling"
                        },
                        new
                        {
                            SportID = "bob",
                            SportName = "Bobsleigh"
                        },
                        new
                        {
                            SportID = "div",
                            SportName = "Diving"
                        },
                        new
                        {
                            SportID = "cyc",
                            SportName = "Road Cycling"
                        },
                        new
                        {
                            SportID = "arc",
                            SportName = "Archery"
                        },
                        new
                        {
                            SportID = "can",
                            SportName = "Canoe Sprint"
                        },
                        new
                        {
                            SportID = "bre",
                            SportName = "Breakdancing"
                        },
                        new
                        {
                            SportID = "ska",
                            SportName = "Skateboarding"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Country", b =>
                {
                    b.HasOne("OlympicGames.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");

                    b.HasOne("OlympicGames.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID");

                    b.HasOne("OlympicGames.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportID");

                    b.Navigation("Game");

                    b.Navigation("Location");

                    b.Navigation("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}