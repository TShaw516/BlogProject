﻿// <auto-generated />
using System;
using BlogProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogProject.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogProject.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TagId");

                    b.ToTable("Blog");

                    b.HasData(
                        new
                        {
                            BlogId = 1,
                            Author = "Tom Shaw",
                            CategoryId = 1,
                            Content = "Machine learning for humans",
                            PublishDate = new DateTime(2020, 2, 27, 22, 39, 0, 597, DateTimeKind.Local).AddTicks(6264),
                            TagId = 1,
                            Title = "First Blog"
                        },
                        new
                        {
                            BlogId = 2,
                            Author = "Samuel Burns",
                            CategoryId = 2,
                            Content = "The one stop shop for all your traveling needs",
                            PublishDate = new DateTime(2020, 2, 27, 22, 39, 0, 599, DateTimeKind.Local).AddTicks(5818),
                            TagId = 2,
                            Title = "Travel for Dummies"
                        },
                        new
                        {
                            BlogId = 3,
                            Author = "John Doe",
                            CategoryId = 3,
                            Content = "Tasty Snacks with a low price point",
                            PublishDate = new DateTime(2020, 2, 27, 22, 39, 0, 599, DateTimeKind.Local).AddTicks(5850),
                            TagId = 3,
                            Title = "Cooking on a Budget"
                        });
                });

            modelBuilder.Entity("BlogProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Technology"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Travel"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Cooking"
                        });
                });

            modelBuilder.Entity("BlogProject.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            TagName = "Toronto"
                        },
                        new
                        {
                            TagId = 2,
                            TagName = "Cleveland"
                        },
                        new
                        {
                            TagId = 3,
                            TagName = "Pittsburgh"
                        });
                });

            modelBuilder.Entity("BlogProject.Models.Blog", b =>
                {
                    b.HasOne("BlogProject.Models.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogProject.Models.Tag", "Tag")
                        .WithMany("Blogs")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
