﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220308030311_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Post", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("SourceId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Content = "PIERS Morgan fought back tears over his close friend Shane Warne's death while watching an emotional TV tribute.\nRemembering Shane Warne - a repeat documentary in honour of the cricketing legend - is being aired on Sky.\n2 Shane Warne with Piers Morga... [1688 chars]",
                            Description = "PIERS Morgan fought back tears over his close friend Shane Warne's death while watching an emotional TV tribute.Remembering Shane Warne - a repeat doc",
                            Image = "https://www.thesun.ie/wp-content/uploads/sites/3/2022/03/comp-skc-shane-warne-piers.jpg?strip=all&quality=100&w=1200&h=800&crop=1",
                            PublishedAt = new DateTime(2022, 3, 7, 22, 3, 11, 184, DateTimeKind.Local).AddTicks(3451),
                            SourceId = 1L,
                            Title = "Piers Morgan fights back tears over pal Shane Warne's death as he watches emotional TV tribute",
                            Url = "https://www.thesun.ie/tv/8464762/piers-morgan-fights-back-tears-shane-warne-death/"
                        },
                        new
                        {
                            Id = 2L,
                            Content = "Governments, think tanks, and analysts around the world had been asking the same questions. But Rinaldi, a teacher at Newton South High School, and his young minds, a group of seniors in his comparative politics and world government seminar, happened... [6697 chars]",
                            Description = "As the war in Ukraine unfolds, teachers have the unique obligation to balance giving students information and historical context about the conflict, while also quelling theirs fears and anxiety",
                            Image = "https://bostonglobe-prod.cdn.arcpublishing.com/resizer/Pr3Nd9bEjaAn4uiNcAsuDoH4kmI=/506x0/cloudfront-us-east-1.images.arcpublishing.com/bostonglobe/5CFA2HR2ZRB2DI6RJOILVP7ASY.jpg",
                            PublishedAt = new DateTime(2022, 3, 7, 22, 3, 11, 186, DateTimeKind.Local).AddTicks(5431),
                            SourceId = 2L,
                            Title = "As the world watches the war in Ukraine, educators are facing the challenges of teaching history in real time",
                            Url = "https://www.bostonglobe.com/2022/03/06/metro/world-watches-war-ukraine-educators-are-facing-challenges-teaching-history-real-time/"
                        },
                        new
                        {
                            Id = 3L,
                            Content = "Amid dark times, we look for a reprieve in cinema or books. The last two years, however, have produced few mood lifters as both the film industry and OTT platforms seem partial towards dark thrillers, murder mysteries, social dramas or biopics. Where... [4149 chars]",
                            Description = "Today, when Bollywood’s idea of comedies involve a fair degree of sexism, Angoor comes across as simple, clean, and a crisp comedy-drama. Here's revisiting the Gulzar directorial as it completes 40 years of its release.",
                            Image = "https://images.indianexpress.com/2022/03/angoor-40-years.jpg",
                            PublishedAt = new DateTime(2022, 3, 7, 22, 3, 11, 186, DateTimeKind.Local).AddTicks(5632),
                            SourceId = 3L,
                            Title = "A millennial watches Angoor: In dark times, revisiting Gulzar’s cult classic",
                            Url = "https://indianexpress.com/article/entertainment/bollywood/a-millennial-watches-angoor-in-dark-times-revisiting-gulzars-cult-classic-7802072/"
                        },
                        new
                        {
                            Id = 4L,
                            Content = "Bruno Lage has reiterated his support for Max Kilman but he doesn’t believe the Wolves defender’s recent struggles should be attributed to the war in Ukraine.\nKilman’s mother, Maria, is Ukrainian and the Wolves defender was contacted by Andriy Shevch... [2668 chars]",
                            Description = "Wolverhampton Wanderers head coach Bruno Lage has been discussing England hopeful Max Kilman's form",
                            Image = "https://i2-prod.birminghammail.co.uk/sport/football/football-news/article23308507.ece/ALTERNATES/s1200/0_JS259676123.jpg",
                            PublishedAt = new DateTime(2022, 3, 7, 22, 3, 11, 186, DateTimeKind.Local).AddTicks(5636),
                            SourceId = 4L,
                            Title = "Bruno Lage makes Max Kilman admission after Gareth Southgate watches Wolves horror show",
                            Url = "https://www.birminghammail.co.uk/sport/football/football-news/wolves-max-kilman-southgate-england-23308321"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Source", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sources");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "The Irish Sun",
                            Url = "https://www.thesun.ie"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "The Boston Globe",
                            Url = "https://www.bostonglobe.com"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "The Indian Express",
                            Url = "https://indianexpress.com"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Birmingham Live",
                            Url = "https://www.birminghammail.co.uk"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Post", b =>
                {
                    b.HasOne("Domain.Entities.Source", "Source")
                        .WithMany("Posts")
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Source");
                });

            modelBuilder.Entity("Domain.Entities.Source", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}