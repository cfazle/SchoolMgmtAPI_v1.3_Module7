﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SchoolMgmtAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Assignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<Guid>("EnrollmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubmissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("SubmissionId");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705498a4b"),
                            Description = "Entity and databae connection",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b5de-024705497c6e"),
                            Title = "Module 1"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705498b4a"),
                            Description = "Get Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b5de-024705497c6e"),
                            Title = "Module 2"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705498c4c"),
                            Description = "Post Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b5de-024705497c6e"),
                            Title = "Module 3"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705498e2a"),
                            Description = "Get Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b5de-024705497c7e"),
                            Title = "Module1"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705498e3a"),
                            Description = "Post Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b5de-024705497c7e"),
                            Title = "Module2"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705498a3b"),
                            Description = "Delete Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b5de-024705497c7e"),
                            Title = "Module3"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497c3e"),
                            Description = "Get Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b5de-024705497d9e"),
                            Title = "Module1"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-564d-4b20-b5de-024705496d3e"),
                            Description = "Post Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b5de-024705497d9e"),
                            Title = "Module2"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-634d-4b20-b5de-024705495a1e"),
                            Description = "Update Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b5de-024705497d9e"),
                            Title = "Module3"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-624d-4b20-b5de-024705495a1e"),
                            Description = "Get Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b6de-024705497c1e"),
                            Title = "Module2"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-66cd-4b20-b5de-024705495a1a"),
                            Description = "Update Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b6de-024705497c1e"),
                            Title = "Module3"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-66ed-4b20-b5de-024705495e1e"),
                            Description = "Update Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-b6de-024705497c1e"),
                            Title = "Module3"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-662d-4b20-b5de-024705495a2e"),
                            Description = "Update Operation ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-e5de-024705497c2e"),
                            Title = "Module3"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-3a20-b5de-024705494a2e"),
                            Description = "Teacher assigns to students homework",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-d6de-024705497d9e"),
                            Title = "Module3"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-40b2-b5de-024705494a2e"),
                            Description = "Admin created assignment ",
                            EnrollmentId = new Guid("80abbca8-664d-4b20-c6de-024705497d8e"),
                            Title = "Module3"
                        });
                });

            modelBuilder.Entity("Entities.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<Guid?>("EnrollmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentId");

                    b.HasIndex("SectionId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4b"),
                            CourseName = "Acc101",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52c"),
                            CourseName = "Math108",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479822"),
                            CourseName = "IS690",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                        });
                });

            modelBuilder.Entity("Entities.Models.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EnrollmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AttributeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<Guid>("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b4de-024705497c5e"),
                            AttributeName = "Student",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SectionId = new Guid("80abbca8-664d-4b20-b5de-024705497d5a"),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-c5de-024705497c1e"),
                            AttributeName = "Teacher",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SectionId = new Guid("80abbca8-664d-4b20-b5de-024705497d5a"),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-d5de-024705497c2c"),
                            AttributeName = "Student",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SectionId = new Guid("80abbca8-664d-4b20-b5de-024705497d5a"),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-e5de-024705497c2e"),
                            AttributeName = "Student",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SectionId = new Guid("80abbca8-664d-4b20-b5de-024705497d6a"),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b6de-024705497c1e"),
                            AttributeName = "Student",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SectionId = new Guid("80abbca8-664d-4b20-b5de-024705497d6a"),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-c6de-024705497d8e"),
                            AttributeName = "Admin",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SectionId = new Guid("80abbca8-664d-4b20-b5de-024705497d6a"),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-d6de-024705497d9e"),
                            AttributeName = "Teacher",
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SectionId = new Guid("80abbca8-664d-4b20-b5de-024705497d6a"),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.Models.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Address = "583 Wall Dr. Gwynn Oak, MD 21207",
                            Country = "USA",
                            OrgName = "xyz org"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Address = "3036 English Creek Ave, EHT, NJ 08234",
                            Country = "USA",
                            OrgName = "lmnop org"
                        });
                });

            modelBuilder.Entity("Entities.Models.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d5a"),
                            CourseId = new Guid("80abbca8-664d-4b20-b5de-024705497d4b"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Online",
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d6a"),
                            CourseId = new Guid("80abbca8-664d-4b20-b5de-024705497d4b"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "On Campus",
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d7a"),
                            CourseId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479822"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "On Campus",
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d8a"),
                            CourseId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479822"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Online",
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d9a"),
                            CourseId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52c"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Online",
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d9c"),
                            CourseId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52c"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "On Campus",
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.Models.Submission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SubmissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("SubmissionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.ToTable("Submissions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-611d-4b20-b5de-024705493d5a"),
                            AssignmentId = new Guid("80abbca8-664d-4b20-b5de-024705498a4b"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score = 100,
                            SubmissionTitle = "Module 1 submission",
                            UpdatedDate = new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-612d-4b20-bbde-024705493d5a"),
                            AssignmentId = new Guid("80abbca8-624d-4b20-b5de-024705495a1e"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score = 100,
                            SubmissionTitle = "Module 2 submission",
                            UpdatedDate = new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-613d-4b20-bcde-024705493d5a"),
                            AssignmentId = new Guid("80abbca8-66ed-4b20-b5de-024705495e1e"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score = 100,
                            SubmissionTitle = "Module 2 submission",
                            UpdatedDate = new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("80abbca8-614d-4b20-bcde-024705493d5a"),
                            AssignmentId = new Guid("80abbca8-662d-4b20-b5de-024705495a2e"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score = 100,
                            SubmissionTitle = "Module 2 submission",
                            UpdatedDate = new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            CreatedDate = new DateTime(2018, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "abc@gmail.com",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "fchoudhury"
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            CreatedDate = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "xyz@gmail.com",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "fac3"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CreatedDate = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "efg@gmail.com",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            UpdatedDate = new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "fac33"
                        });
                });

            modelBuilder.Entity("Entities.Models.Assignment", b =>
                {
                    b.HasOne("Entities.Models.Submission", null)
                        .WithMany("Assignments")
                        .HasForeignKey("SubmissionId");
                });

            modelBuilder.Entity("Entities.Models.Course", b =>
                {
                    b.HasOne("Entities.Models.Enrollment", null)
                        .WithMany("Courses")
                        .HasForeignKey("EnrollmentId");

                    b.HasOne("Entities.Models.Section", null)
                        .WithMany("Courses")
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Entities.Models.Enrollment", b =>
                {
                    b.HasOne("Entities.Models.Assignment", null)
                        .WithMany("Enrollments")
                        .HasForeignKey("AssignmentId");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.Course", null)
                        .WithMany("Users")
                        .HasForeignKey("CourseId");

                    b.HasOne("Entities.Models.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
