﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(ContextDb))]
    partial class ContextDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImage2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutMapLocation")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentContent")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentUserName")
                        .HasColumnType("TEXT");

                    b.Property<int>("FoodID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("FoodID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FoodContent")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FoodCreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodImage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FoodStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FoodThumbnailImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodTitle")
                        .HasColumnType("TEXT");

                    b.HasKey("FoodId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("EntityLayer.Concrete.FoodCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FoodId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "FoodId");

                    b.HasIndex("FoodId");

                    b.ToTable("FoodCategory");
                });

            modelBuilder.Entity("EntityLayer.Concrete.WriterChef", b =>
                {
                    b.Property<int>("WriterChefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("WriterChefAbout")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterChefImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterChefMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterChefName")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterChefPassword")
                        .HasColumnType("TEXT");

                    b.Property<bool>("WriterChefStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("WriterChefId");

                    b.ToTable("WriterChefs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Food", "Food")
                        .WithMany("Comment")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Food", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Food")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrete.FoodCategory", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("FoodCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Food", "Food")
                        .WithMany("FoodCategories")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Food");

                    b.Navigation("FoodCategories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Food", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("FoodCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
