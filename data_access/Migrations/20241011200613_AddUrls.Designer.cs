﻿// <auto-generated />
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
    [Migration("20241011200613_AddUrls")]
    partial class AddUrls
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("data_access.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudyYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Groups", t =>
                        {
                            t.HasCheckConstraint("CK_Group_StudyYear", "StudyYear >= 1 AND StudyYear <= 4");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer Science",
                            StudyYear = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mechanical Engineering",
                            StudyYear = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Electrical Engineering",
                            StudyYear = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Physics",
                            StudyYear = 2
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

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("StudentImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students", t =>
                        {
                            t.HasCheckConstraint("CK_Student_AverageGrade", "AverageGrade >= 2 AND AverageGrade <= 5");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageGrade = 4.5m,
                            FullName = "Alice Smith",
                            GroupId = 1,
                            StudentImage = "https://i.pinimg.com/564x/d1/2d/ec/d12dece72502dd732b11ec5a66fb9076.jpg"
                        },
                        new
                        {
                            Id = 2,
                            AverageGrade = 3.9m,
                            FullName = "John Doe",
                            GroupId = 1,
                            StudentImage = ""
                        },
                        new
                        {
                            Id = 3,
                            AverageGrade = 4.1m,
                            FullName = "Emily Clark",
                            GroupId = 2,
                            StudentImage = "https://i.pinimg.com/enabled_lo/564x/8b/9a/02/8b9a02ac3ea4d3bdb3e1403c34a6c232.jpg"
                        },
                        new
                        {
                            Id = 4,
                            AverageGrade = 3.7m,
                            FullName = "Michael Johnson",
                            GroupId = 2,
                            StudentImage = "https://i.pinimg.com/564x/db/c5/e6/dbc5e69ece5632c0885e497d1882d40b.jpg"
                        },
                        new
                        {
                            Id = 5,
                            AverageGrade = 4.3m,
                            FullName = "Sophia Williams",
                            GroupId = 3,
                            StudentImage = ""
                        },
                        new
                        {
                            Id = 6,
                            AverageGrade = 4.0m,
                            FullName = "Liam Brown",
                            GroupId = 4,
                            StudentImage = ""
                        },
                        new
                        {
                            Id = 7,
                            AverageGrade = 3.8m,
                            FullName = "Olivia Davis",
                            GroupId = 4,
                            StudentImage = "https://i.pinimg.com/736x/74/94/71/749471a2654703b02997f7357ef57a37.jpg"
                        });
                });

            modelBuilder.Entity("data_access.Entities.Student", b =>
                {
                    b.HasOne("data_access.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("data_access.Entities.Group", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
