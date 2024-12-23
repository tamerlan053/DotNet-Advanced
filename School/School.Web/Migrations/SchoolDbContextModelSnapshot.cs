﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Web.Infrastructure;

#nullable disable

namespace School.Web.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("School.Web.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("681bc0ef-25cc-47c0-852b-db07543f997d"),
                            Credits = 3,
                            Title = "Chemistry"
                        },
                        new
                        {
                            Id = new Guid("938a181c-d465-47fc-bbf5-bacb467619af"),
                            Credits = 4,
                            Title = "Calculus"
                        },
                        new
                        {
                            Id = new Guid("cb808a1b-105b-4998-93b4-9ddcd7a9fb15"),
                            Credits = 4,
                            Title = "Literature"
                        });
                });

            modelBuilder.Entity("School.Web.Models.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("32063aa2-e689-4a1a-913c-9655b3521029"),
                            CourseId = new Guid("681bc0ef-25cc-47c0-852b-db07543f997d"),
                            Grade = 8,
                            StudentId = new Guid("71341f00-ae72-4af9-bb4f-d78b7f48180f")
                        },
                        new
                        {
                            Id = new Guid("1dcf0e5b-bdb9-4a48-b250-eb42ea60a6d6"),
                            CourseId = new Guid("938a181c-d465-47fc-bbf5-bacb467619af"),
                            Grade = 8,
                            StudentId = new Guid("71341f00-ae72-4af9-bb4f-d78b7f48180f")
                        },
                        new
                        {
                            Id = new Guid("7a2dbbdd-30e5-4469-814f-3083e3f2fabd"),
                            CourseId = new Guid("cb808a1b-105b-4998-93b4-9ddcd7a9fb15"),
                            Grade = 15,
                            StudentId = new Guid("71341f00-ae72-4af9-bb4f-d78b7f48180f")
                        },
                        new
                        {
                            Id = new Guid("093700e2-0de6-402c-bc77-f896273bcdea"),
                            CourseId = new Guid("681bc0ef-25cc-47c0-852b-db07543f997d"),
                            Grade = 8,
                            StudentId = new Guid("05029cf3-4271-458d-8eec-fac3dea8f2ae")
                        },
                        new
                        {
                            Id = new Guid("ed87c9d4-9cd2-4b02-bd73-bf6409a55018"),
                            CourseId = new Guid("938a181c-d465-47fc-bbf5-bacb467619af"),
                            Grade = 8,
                            StudentId = new Guid("05029cf3-4271-458d-8eec-fac3dea8f2ae")
                        },
                        new
                        {
                            Id = new Guid("d2f7a963-77cb-4125-a703-1e202a11e97e"),
                            CourseId = new Guid("cb808a1b-105b-4998-93b4-9ddcd7a9fb15"),
                            Grade = 11,
                            StudentId = new Guid("05029cf3-4271-458d-8eec-fac3dea8f2ae")
                        });
                });

            modelBuilder.Entity("School.Web.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("71341f00-ae72-4af9-bb4f-d78b7f48180f"),
                            FirstName = "John",
                            LastName = "Doe",
                            StartedOn = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("05029cf3-4271-458d-8eec-fac3dea8f2ae"),
                            FirstName = "Jane",
                            LastName = "Doe",
                            StartedOn = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("School.Web.Models.Enrollment", b =>
                {
                    b.HasOne("School.Web.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Web.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("School.Web.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("School.Web.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
