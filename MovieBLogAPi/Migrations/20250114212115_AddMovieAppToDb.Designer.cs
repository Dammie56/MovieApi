﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieBlogAPI.Data;

#nullable disable

namespace MovieBlogAPI.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20250114212115_AddMovieAppToDb")]
    partial class AddMovieAppToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MovieBlogAPI.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("ReleaseDate")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Comedy",
                            Rating = 8.8000000000000007,
                            ReleaseDate = 2024,
                            Title = "Everybody Loves Jenifa"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Comedy and Action",
                            Rating = 7.0,
                            ReleaseDate = 2024,
                            Title = "Alakada Bad and Boujee"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Action and Animation",
                            Rating = 9.5,
                            ReleaseDate = 2024,
                            Title = "Mufasa"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Inspiring",
                            Rating = 10.0,
                            ReleaseDate = 2024,
                            Title = "Seven Doors"
                        });
                });

            modelBuilder.Entity("MovieBlogAPI.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Amazing and funny movie!",
                            MovieId = 1,
                            Rating = 9,
                            ReviewerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = " An Outstanding performance.",
                            MovieId = 2,
                            Rating = 10,
                            ReviewerId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "A mind Blowing performance.",
                            MovieId = 2,
                            Rating = 9,
                            ReviewerId = 3
                        },
                        new
                        {
                            Id = 4,
                            Content = "I would recommend this to everyone to watch!",
                            MovieId = 4,
                            Rating = 9,
                            ReviewerId = 1
                        });
                });

            modelBuilder.Entity("MovieBlogAPI.Models.Reviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reviewers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Anjorin",
                            LastName = "Oluwadamilola"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Gabriel",
                            LastName = "Anjorin"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Firepemi",
                            LastName = "Bella"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Fifehanmi",
                            LastName = "Anjorin"
                        });
                });

            modelBuilder.Entity("MovieBlogAPI.Models.Review", b =>
                {
                    b.HasOne("MovieBlogAPI.Models.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieBlogAPI.Models.Reviewer", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("MovieBlogAPI.Models.Movie", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("MovieBlogAPI.Models.Reviewer", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
