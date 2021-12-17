﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PreSchool.Database;

#nullable disable

namespace PreSchool.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20211217143414_firstmaybe")]
    partial class firstmaybe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AdultChild", b =>
                {
                    b.Property<int>("ChildrenId")
                        .HasColumnType("int");

                    b.Property<int>("GuardiansId")
                        .HasColumnType("int");

                    b.HasKey("ChildrenId", "GuardiansId");

                    b.HasIndex("GuardiansId");

                    b.ToTable("AdultChild");
                });

            modelBuilder.Entity("ChildGroup", b =>
                {
                    b.Property<int>("ChildrenId")
                        .HasColumnType("int");

                    b.Property<int>("GroupsId")
                        .HasColumnType("int");

                    b.HasKey("ChildrenId", "GroupsId");

                    b.HasIndex("GroupsId");

                    b.ToTable("ChildGroup");
                });

            modelBuilder.Entity("PreSchool.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AdultId")
                        .HasColumnType("int");

                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("GuardianId")
                        .HasColumnType("int");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdultId");

                    b.HasIndex("ChildId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AddressInfo");
                });

            modelBuilder.Entity("PreSchool.Models.Adult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DebitFee")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("IncomeInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonalNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Adults");
                });

            modelBuilder.Entity("PreSchool.Models.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BillRecipent")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FifteenHours")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonalNumber")
                        .HasColumnType("bigint");

                    b.Property<bool>("PublicPreSchool")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("PreSchool.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonalNumber")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PreSchool.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("AdultChild", b =>
                {
                    b.HasOne("PreSchool.Models.Child", null)
                        .WithMany()
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PreSchool.Models.Adult", null)
                        .WithMany()
                        .HasForeignKey("GuardiansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChildGroup", b =>
                {
                    b.HasOne("PreSchool.Models.Child", null)
                        .WithMany()
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PreSchool.Models.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PreSchool.Models.Address", b =>
                {
                    b.HasOne("PreSchool.Models.Adult", null)
                        .WithMany("AddressesInfo")
                        .HasForeignKey("AdultId");

                    b.HasOne("PreSchool.Models.Child", null)
                        .WithMany("AddressesInfo")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PreSchool.Models.Employee", null)
                        .WithMany("AddressesInfo")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PreSchool.Models.Adult", b =>
                {
                    b.HasOne("PreSchool.Models.Group", null)
                        .WithMany("Adults")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("PreSchool.Models.Adult", b =>
                {
                    b.Navigation("AddressesInfo");
                });

            modelBuilder.Entity("PreSchool.Models.Child", b =>
                {
                    b.Navigation("AddressesInfo");
                });

            modelBuilder.Entity("PreSchool.Models.Employee", b =>
                {
                    b.Navigation("AddressesInfo");
                });

            modelBuilder.Entity("PreSchool.Models.Group", b =>
                {
                    b.Navigation("Adults");
                });
#pragma warning restore 612, 618
        }
    }
}