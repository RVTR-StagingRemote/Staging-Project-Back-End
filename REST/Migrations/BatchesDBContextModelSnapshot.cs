﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using REST.DataLayer;

namespace REST.Migrations
{
    [DbContext(typeof(BatchesDBContext))]
    partial class BatchesDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("REST.Models.Clients", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int?>("StateId")
                        .HasColumnType("integer");

                    b.Property<string>("StateProvince")
                        .HasColumnType("text");

                    b.HasKey("ClientId");

                    b.HasIndex("StateId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("REST.Models.Courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("REST.Models.CoursesTopicsJoin", b =>
                {
                    b.Property<int>("JoinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("TopicId")
                        .HasColumnType("integer");

                    b.HasKey("JoinId");

                    b.ToTable("CoursesTopicsJoins");
                });

            modelBuilder.Entity("REST.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Degree")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeType")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<int>("StateId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("REST.Models.EmployeeSkills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CoursesTopicsJoinJoinId")
                        .HasColumnType("integer");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int>("EmplyeeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TopicsJoinId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CoursesTopicsJoinJoinId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeSkills");
                });

            modelBuilder.Entity("REST.Models.OrderDetails", b =>
                {
                    b.Property<int>("DetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AssociateCount")
                        .HasColumnType("integer");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateNeeded")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int?>("OrdersOrderId")
                        .HasColumnType("integer");

                    b.HasKey("DetailsId");

                    b.HasIndex("OrdersOrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("REST.Models.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<int?>("ClientsClientId")
                        .HasColumnType("integer");

                    b.Property<string>("OrderName")
                        .HasColumnType("text");

                    b.HasKey("OrderId");

                    b.HasIndex("ClientsClientId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("REST.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("StateId");

                    b.ToTable("State");
                });

            modelBuilder.Entity("REST.Models.Topics", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("TopicName")
                        .HasColumnType("text");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("REST.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("REST.Models.Clients", b =>
                {
                    b.HasOne("REST.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.Navigation("State");
                });

            modelBuilder.Entity("REST.Models.Employee", b =>
                {
                    b.HasOne("REST.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("REST.Models.EmployeeSkills", b =>
                {
                    b.HasOne("REST.Models.CoursesTopicsJoin", "CoursesTopicsJoin")
                        .WithMany()
                        .HasForeignKey("CoursesTopicsJoinJoinId");

                    b.HasOne("REST.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.Navigation("CoursesTopicsJoin");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("REST.Models.OrderDetails", b =>
                {
                    b.HasOne("REST.Models.Orders", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrdersOrderId");
                });

            modelBuilder.Entity("REST.Models.Orders", b =>
                {
                    b.HasOne("REST.Models.Clients", "Clients")
                        .WithMany("Orders")
                        .HasForeignKey("ClientsClientId");

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("REST.Models.Clients", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("REST.Models.Orders", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
