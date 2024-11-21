﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using data_access;

#nullable disable

namespace data_access.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20241121171429_StudentSubjectPK")]
    partial class StudentSubjectPK
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("data_access.Entities.FieldOfStudy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FieldsOfStudy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer Science"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mechanical Engineering"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Electrical Engineering"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Physics"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Applied Information Technology"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Digital Engineering"
                        });
                });

            modelBuilder.Entity("data_access.Entities.FieldOfStudySubject", b =>
                {
                    b.Property<int>("FieldOfStudyId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("FieldOfStudyId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("FieldOfStudySubject");

                    b.HasData(
                        new
                        {
                            FieldOfStudyId = 1,
                            SubjectId = 6
                        },
                        new
                        {
                            FieldOfStudyId = 1,
                            SubjectId = 7
                        },
                        new
                        {
                            FieldOfStudyId = 1,
                            SubjectId = 8
                        },
                        new
                        {
                            FieldOfStudyId = 1,
                            SubjectId = 18
                        },
                        new
                        {
                            FieldOfStudyId = 2,
                            SubjectId = 9
                        },
                        new
                        {
                            FieldOfStudyId = 2,
                            SubjectId = 10
                        },
                        new
                        {
                            FieldOfStudyId = 2,
                            SubjectId = 11
                        },
                        new
                        {
                            FieldOfStudyId = 2,
                            SubjectId = 12
                        },
                        new
                        {
                            FieldOfStudyId = 3,
                            SubjectId = 12
                        },
                        new
                        {
                            FieldOfStudyId = 3,
                            SubjectId = 16
                        },
                        new
                        {
                            FieldOfStudyId = 3,
                            SubjectId = 13
                        },
                        new
                        {
                            FieldOfStudyId = 3,
                            SubjectId = 14
                        },
                        new
                        {
                            FieldOfStudyId = 3,
                            SubjectId = 11
                        },
                        new
                        {
                            FieldOfStudyId = 4,
                            SubjectId = 15
                        },
                        new
                        {
                            FieldOfStudyId = 4,
                            SubjectId = 16
                        },
                        new
                        {
                            FieldOfStudyId = 4,
                            SubjectId = 17
                        },
                        new
                        {
                            FieldOfStudyId = 5,
                            SubjectId = 18
                        },
                        new
                        {
                            FieldOfStudyId = 5,
                            SubjectId = 19
                        },
                        new
                        {
                            FieldOfStudyId = 5,
                            SubjectId = 20
                        },
                        new
                        {
                            FieldOfStudyId = 5,
                            SubjectId = 16
                        },
                        new
                        {
                            FieldOfStudyId = 6,
                            SubjectId = 21
                        },
                        new
                        {
                            FieldOfStudyId = 6,
                            SubjectId = 22
                        },
                        new
                        {
                            FieldOfStudyId = 6,
                            SubjectId = 23
                        });
                });

            modelBuilder.Entity("data_access.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AverageGrade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FieldOfStudyId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FieldOfStudyId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Students", t =>
                        {
                            t.HasCheckConstraint("CK_Student_AverageGrade", "AverageGrade >= 2 AND AverageGrade <= 5");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageGrade = 4.5m,
                            Email = "alice.smith@student.uni",
                            FieldOfStudyId = 1,
                            FullName = "Alice Smith",
                            StudentImage = "https://i.pinimg.com/564x/d1/2d/ec/d12dece72502dd732b11ec5a66fb9076.jpg"
                        },
                        new
                        {
                            Id = 2,
                            AverageGrade = 3.9m,
                            Email = "john.doe@student.uni",
                            FieldOfStudyId = 1,
                            FullName = "John Doe"
                        },
                        new
                        {
                            Id = 3,
                            AverageGrade = 4.1m,
                            Email = "emily.clark@student.uni",
                            FieldOfStudyId = 2,
                            FullName = "Emily Clark",
                            StudentImage = "https://i.pinimg.com/enabled_lo/564x/8b/9a/02/8b9a02ac3ea4d3bdb3e1403c34a6c232.jpg"
                        },
                        new
                        {
                            Id = 4,
                            AverageGrade = 3.7m,
                            Email = "michael.johnson@student.uni",
                            FieldOfStudyId = 2,
                            FullName = "Michael Johnson",
                            StudentImage = "https://i.pinimg.com/564x/db/c5/e6/dbc5e69ece5632c0885e497d1882d40b.jpg"
                        },
                        new
                        {
                            Id = 5,
                            AverageGrade = 4.3m,
                            Email = "sophia.williams@student.uni",
                            FieldOfStudyId = 3,
                            FullName = "Sophia Williams"
                        },
                        new
                        {
                            Id = 6,
                            AverageGrade = 4.0m,
                            Email = "liam.brown@student.uni",
                            FieldOfStudyId = 4,
                            FullName = "Liam Brown"
                        },
                        new
                        {
                            Id = 7,
                            AverageGrade = 3.8m,
                            Email = "olivia.davis@student.uni",
                            FieldOfStudyId = 4,
                            FullName = "Olivia Davis",
                            StudentImage = "https://i.pinimg.com/736x/74/94/71/749471a2654703b02997f7357ef57a37.jpg"
                        });
                });

            modelBuilder.Entity("data_access.Entities.StudentSubject", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubject");
                });

            modelBuilder.Entity("data_access.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ects")
                        .HasColumnType("int");

                    b.Property<bool>("IsOptional")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ects = 5,
                            IsOptional = true,
                            Name = "Psychology"
                        },
                        new
                        {
                            Id = 2,
                            Ects = 6,
                            IsOptional = true,
                            Name = "Research Methodology"
                        },
                        new
                        {
                            Id = 3,
                            Ects = 4,
                            IsOptional = true,
                            Name = "Philosophy of Science"
                        },
                        new
                        {
                            Id = 4,
                            Ects = 5,
                            IsOptional = true,
                            Name = "Information Systems"
                        },
                        new
                        {
                            Id = 5,
                            Ects = 3,
                            IsOptional = true,
                            Name = "Cultural Studies"
                        },
                        new
                        {
                            Id = 6,
                            Ects = 4,
                            IsOptional = false,
                            Name = "Calculus"
                        },
                        new
                        {
                            Id = 7,
                            Ects = 5,
                            IsOptional = false,
                            Name = "Operating Systems"
                        },
                        new
                        {
                            Id = 8,
                            Ects = 8,
                            IsOptional = false,
                            Name = "Programming"
                        },
                        new
                        {
                            Id = 9,
                            Ects = 5,
                            IsOptional = false,
                            Name = "Structural Analysis"
                        },
                        new
                        {
                            Id = 10,
                            Ects = 3,
                            IsOptional = false,
                            Name = "Computer Aided Engineering"
                        },
                        new
                        {
                            Id = 11,
                            Ects = 6,
                            IsOptional = false,
                            Name = "Energy Systems"
                        },
                        new
                        {
                            Id = 12,
                            Ects = 5,
                            IsOptional = false,
                            Name = "Structural Analysis"
                        },
                        new
                        {
                            Id = 13,
                            Ects = 3,
                            IsOptional = false,
                            Name = "Electrical Energy Production Transportation and Distribution"
                        },
                        new
                        {
                            Id = 14,
                            Ects = 6,
                            IsOptional = false,
                            Name = "Trafic Infrastructure Design"
                        },
                        new
                        {
                            Id = 15,
                            Ects = 5,
                            IsOptional = false,
                            Name = "Physics"
                        },
                        new
                        {
                            Id = 16,
                            Ects = 3,
                            IsOptional = false,
                            Name = "Linear Algebra"
                        },
                        new
                        {
                            Id = 17,
                            Ects = 6,
                            IsOptional = false,
                            Name = "Introduction to Biological Physics"
                        },
                        new
                        {
                            Id = 18,
                            Ects = 5,
                            IsOptional = false,
                            Name = "Databases"
                        },
                        new
                        {
                            Id = 19,
                            Ects = 6,
                            IsOptional = false,
                            Name = "Software Engineering"
                        },
                        new
                        {
                            Id = 20,
                            Ects = 6,
                            IsOptional = false,
                            Name = "Interaction Design"
                        },
                        new
                        {
                            Id = 21,
                            Ects = 5,
                            IsOptional = false,
                            Name = "Programming for Engineers"
                        },
                        new
                        {
                            Id = 22,
                            Ects = 3,
                            IsOptional = false,
                            Name = "Artificial Intelligence for Smart Technologies"
                        },
                        new
                        {
                            Id = 23,
                            Ects = 6,
                            IsOptional = false,
                            Name = "Introduction to IOT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("data_access.Entities.FieldOfStudySubject", b =>
                {
                    b.HasOne("data_access.Entities.FieldOfStudy", "FieldOfStudy")
                        .WithMany()
                        .HasForeignKey("FieldOfStudyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("data_access.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FieldOfStudy");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("data_access.Entities.Student", b =>
                {
                    b.HasOne("data_access.Entities.FieldOfStudy", "FieldOfStudy")
                        .WithMany("Students")
                        .HasForeignKey("FieldOfStudyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithOne()
                        .HasForeignKey("data_access.Entities.Student", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("FieldOfStudy");

                    b.Navigation("User");
                });

            modelBuilder.Entity("data_access.Entities.StudentSubject", b =>
                {
                    b.HasOne("data_access.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("data_access.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("data_access.Entities.FieldOfStudy", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
