﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7601),
                            Email = "Marshall42@gmail.com",
                            Name = "Marshall Delgado",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7606),
                            Email = "Lily89@experis.com",
                            Name = "Lily Pritchett",
                            Phone = "888 22 999",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7626),
                            Email = "Marshall16@experis.com",
                            Name = "Marshall Dunpy",
                            Phone = "888 22 999",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7629),
                            Email = "Ted68@live.com",
                            Name = "Ted Dunpy",
                            Phone = "888 22 999",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7631),
                            Email = "Marshall86@hotmail.com",
                            Name = "Marshall Pritchett",
                            Phone = "222 25 555",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7634),
                            Email = "Marshall64@live.com",
                            Name = "Marshall Thorpe",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7636),
                            Email = "Robin6@live.com",
                            Name = "Robin Delgado",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7638),
                            Email = "Lily52@gmail.com",
                            Name = "Lily Thorpe",
                            Phone = "888 22 999",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7639),
                            Email = "Robin92@live.com",
                            Name = "Robin Thorpe",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7642),
                            Email = "Lily7@gmail.com",
                            Name = "Lily Thorpe",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7643),
                            Email = "Barney50@experis.com",
                            Name = "Barney Dunpy",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7645),
                            Email = "Lily64@gmail.com",
                            Name = "Lily Thorpe",
                            Phone = "222 25 555",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7646),
                            Email = "Marshall94@gmail.com",
                            Name = "Marshall Pritchett",
                            Phone = "222 25 555",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7648),
                            Email = "Ted17@experis.com",
                            Name = "Ted Dunpy",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7649),
                            Email = "Barney65@hotmail.com",
                            Name = "Barney Delgado",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7650),
                            Email = "Lily78@gmail.com",
                            Name = "Lily Delgado",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7652),
                            Email = "Ted6@experis.com",
                            Name = "Ted Dunpy",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7655),
                            Email = "Ted12@live.com",
                            Name = "Ted Pritchett",
                            Phone = "888 22 999",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7657),
                            Email = "Ted23@gmail.com",
                            Name = "Ted Thorpe",
                            Phone = "909 11 881",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2024, 2, 8, 9, 58, 43, 521, DateTimeKind.Utc).AddTicks(7659),
                            Email = "Ted38@hotmail.com",
                            Name = "Ted Pritchett",
                            Phone = "222 25 555",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("IMDBRating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imdb_rating");

                    b.Property<int>("RuntimeMin")
                        .HasColumnType("integer")
                        .HasColumnName("runtime_min");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            IMDBRating = "9.3",
                            RuntimeMin = 142,
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                            IMDBRating = "9.2",
                            RuntimeMin = 175,
                            Title = "The Godfather"
                        },
                        new
                        {
                            Id = 3,
                            Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                            IMDBRating = "9.0",
                            RuntimeMin = 152,
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            IMDBRating = "8.9",
                            RuntimeMin = 154,
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                            IMDBRating = "8.8",
                            RuntimeMin = 148,
                            Title = "Inception"
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_movie_id");

                    b.Property<int?>("MovieId1")
                        .HasColumnType("integer");

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasColumnName("number");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieId1");

                    b.ToTable("screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Movie", null)
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId1");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });
#pragma warning restore 612, 618
        }
    }
}
