﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using akimedia_server.Persistence;

namespace akimediaserver.Migrations
{
    [DbContext(typeof(AkimediaDbContext))]
    [Migration("20180617165852_AddTotalFilmsToFilmDirector")]
    partial class AddTotalFilmsToFilmDirector
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("akimedia_server.Models.Films.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("DirectorId");

                    b.Property<string>("Logo");

                    b.Property<int?>("Rating")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("akimedia_server.Models.Films.FilmDirector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BornYear");

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<int?>("DeathYear");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Photo");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("TotalFilms")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("FilmDirectors");
                });

            modelBuilder.Entity("akimedia_server.Models.Films.FilmFilmGenre", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<int>("FilmGenreId");

                    b.HasKey("FilmId", "FilmGenreId");

                    b.HasIndex("FilmGenreId");

                    b.ToTable("FilmFilmGenres");
                });

            modelBuilder.Entity("akimedia_server.Models.Films.FilmGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId");

                    b.Property<string>("GenreName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("FilmGenres");
                });

            modelBuilder.Entity("akimedia_server.Models.Films.Film", b =>
                {
                    b.HasOne("akimedia_server.Models.Films.FilmDirector", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("akimedia_server.Models.Films.FilmFilmGenre", b =>
                {
                    b.HasOne("akimedia_server.Models.Films.FilmGenre", "FilmGenre")
                        .WithMany("FilmFilmGenres")
                        .HasForeignKey("FilmGenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("akimedia_server.Models.Films.Film", "Film")
                        .WithMany("FilmFilmGenres")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
