﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using REST.DataLayer;

namespace REST.Migrations
{
    [DbContext(typeof(BatchesDBContext))]
    [Migration("20220103210440_updateusermodel")]
    partial class updateusermodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("REST.Models.Applicant", b =>
                {
                    b.Property<int>("ApplicantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AboutMe")
                        .HasColumnType("text");

                    b.Property<string>("EducationField")
                        .HasColumnType("text");

                    b.Property<string>("EducationLevel")
                        .HasColumnType("text");

                    b.Property<string>("EmploymentStatus")
                        .HasColumnType("text");

                    b.Property<byte[]>("Resume")
                        .HasColumnType("bytea");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ApplicantId");

                    b.HasIndex("UserId");

                    b.ToTable("Applicants");
                });

            modelBuilder.Entity("REST.Models.ApplicantOccupation", b =>
                {
                    b.Property<int>("ApplicantOccupationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicantId")
                        .HasColumnType("integer");

                    b.Property<string>("JobTitle")
                        .HasColumnType("text");

                    b.Property<bool>("OpenMarket")
                        .HasColumnType("boolean");

                    b.Property<int>("YearsExperience")
                        .HasColumnType("integer");

                    b.HasKey("ApplicantOccupationId");

                    b.HasIndex("ApplicantId");

                    b.ToTable("ApplicantOccupations");
                });

            modelBuilder.Entity("REST.Models.ApplicantSkill", b =>
                {
                    b.Property<int>("ApplicantSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicantId")
                        .HasColumnType("integer");

                    b.Property<int>("SkillId")
                        .HasColumnType("integer");

                    b.HasKey("ApplicantSkillId");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("SkillId");

                    b.ToTable("ApplicantSkills");
                });

            modelBuilder.Entity("REST.Models.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicantOccupationId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateOfApplication")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("NeedId")
                        .HasColumnType("integer");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("ApplicationId");

                    b.HasIndex("ApplicantOccupationId");

                    b.HasIndex("NeedId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("REST.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("REST.Models.ClientUser", b =>
                {
                    b.Property<int>("ClientUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("ClientUserId");

                    b.HasIndex("ClientID");

                    b.HasIndex("UserID");

                    b.ToTable("ClientUsers");
                });

            modelBuilder.Entity("REST.Models.Interview", b =>
                {
                    b.Property<int>("InterviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("InterviewId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("REST.Models.Need", b =>
                {
                    b.Property<int>("NeedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AmountFulfilled")
                        .HasColumnType("integer");

                    b.Property<int>("AmountNeeded")
                        .HasColumnType("integer");

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<string>("EducationField")
                        .HasColumnType("text");

                    b.Property<string>("EducationLevel")
                        .HasColumnType("text");

                    b.Property<string>("ExtraDescription")
                        .HasColumnType("text");

                    b.Property<string>("JobTitle")
                        .HasColumnType("text");

                    b.Property<int>("YearsExperience")
                        .HasColumnType("integer");

                    b.HasKey("NeedId");

                    b.HasIndex("ClientId");

                    b.ToTable("Needs");
                });

            modelBuilder.Entity("REST.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("OwnerId");

                    b.HasIndex("UserId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("REST.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("SkillName")
                        .HasColumnType("text");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("REST.Models.SkillNeed", b =>
                {
                    b.Property<int>("SkillNeedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("NeedId")
                        .HasColumnType("integer");

                    b.Property<int>("SkillId")
                        .HasColumnType("integer");

                    b.HasKey("SkillNeedId");

                    b.HasIndex("NeedId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillNeeds");
                });

            modelBuilder.Entity("REST.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicantId")
                        .HasColumnType("integer");

                    b.Property<bool>("Approved")
                        .HasColumnType("boolean");

                    b.Property<int>("ClientUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("ClientUserId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("REST.Models.Applicant", b =>
                {
                    b.HasOne("REST.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("REST.Models.ApplicantOccupation", b =>
                {
                    b.HasOne("REST.Models.Applicant", "Applicant")
                        .WithMany("ApplicantOccupations")
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");
                });

            modelBuilder.Entity("REST.Models.ApplicantSkill", b =>
                {
                    b.HasOne("REST.Models.Applicant", "Applicant")
                        .WithMany("ApplicantSkills")
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("REST.Models.Skill", "Skill")
                        .WithMany("ApplicantSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("REST.Models.Application", b =>
                {
                    b.HasOne("REST.Models.ApplicantOccupation", "ApplicantOccupation")
                        .WithMany("Applications")
                        .HasForeignKey("ApplicantOccupationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("REST.Models.Need", "Need")
                        .WithMany("Applications")
                        .HasForeignKey("NeedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("REST.Models.Owner", "Owner")
                        .WithMany("Applications")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicantOccupation");

                    b.Navigation("Need");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("REST.Models.ClientUser", b =>
                {
                    b.HasOne("REST.Models.Client", "Client")
                        .WithMany("ClientUsers")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("REST.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("User");
                });

            modelBuilder.Entity("REST.Models.Interview", b =>
                {
                    b.HasOne("REST.Models.Application", "Application")
                        .WithMany("Interviews")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("REST.Models.Need", b =>
                {
                    b.HasOne("REST.Models.Client", "Client")
                        .WithMany("Needs")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("REST.Models.Owner", b =>
                {
                    b.HasOne("REST.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("REST.Models.SkillNeed", b =>
                {
                    b.HasOne("REST.Models.Need", "Need")
                        .WithMany("SkillNeeds")
                        .HasForeignKey("NeedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("REST.Models.Skill", "Skill")
                        .WithMany("SkillNeeds")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Need");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("REST.Models.User", b =>
                {
                    b.HasOne("REST.Models.Applicant", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("REST.Models.ClientUser", "ClientUser")
                        .WithMany()
                        .HasForeignKey("ClientUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("REST.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");

                    b.Navigation("ClientUser");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("REST.Models.Applicant", b =>
                {
                    b.Navigation("ApplicantOccupations");

                    b.Navigation("ApplicantSkills");
                });

            modelBuilder.Entity("REST.Models.ApplicantOccupation", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("REST.Models.Application", b =>
                {
                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("REST.Models.Client", b =>
                {
                    b.Navigation("ClientUsers");

                    b.Navigation("Needs");
                });

            modelBuilder.Entity("REST.Models.Need", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("SkillNeeds");
                });

            modelBuilder.Entity("REST.Models.Owner", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("REST.Models.Skill", b =>
                {
                    b.Navigation("ApplicantSkills");

                    b.Navigation("SkillNeeds");
                });
#pragma warning restore 612, 618
        }
    }
}
