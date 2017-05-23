﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Platform.Context;
using Platform.Data;
using Platform.Data.Account.Protection;
using Platform.Data.Course;
using System;

namespace Platform.Migrations
{
    [DbContext(typeof(StorageContext))]
    [Migration("20170522123645_Added Course data.")]
    partial class AddedCoursedata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-preview1-24937")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Platform.Data.Account.Teacher", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("AccessToken");

                    b.Property<DateTime>("CreateAt");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email");

                    b.Property<bool>("IsBanned");

                    b.Property<string>("Name");

                    b.Property<long>("PasswordHash");

                    b.Property<string>("Photo");

                    b.Property<double>("Rating");

                    b.Property<int>("Rights");

                    b.Property<int>("TeacherStatus");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("ID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("Platform.Data.Account.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessToken");

                    b.Property<DateTime>("CreateAt");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email");

                    b.Property<bool>("IsBanned");

                    b.Property<double>("Money");

                    b.Property<string>("Name");

                    b.Property<long>("PasswordHash");

                    b.Property<string>("Photo");

                    b.Property<int>("Rights");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Platform.Data.Course.Course", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<int>("Category");

                    b.Property<float>("Coast");

                    b.Property<int>("CourseStatus");

                    b.Property<DateTime>("CreateAt");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<int>("Difficulty");

                    b.Property<string>("Duration");

                    b.Property<int>("Language");

                    b.Property<int>("Lessons");

                    b.Property<int>("Rating");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("ID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Platform.Data.Course.Lesson.Lesson", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<string>("Duration");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("ID");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("Platform.Data.Review", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AuthorId");

                    b.Property<string>("Comment");

                    b.Property<int>("CourseRating");

                    b.Property<DateTime>("CreateAt");

                    b.Property<bool>("Deleted");

                    b.Property<int>("ReviewRating");

                    b.Property<int>("TeacherRating");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("ID");

                    b.ToTable("Review");
                });
        }
    }
}