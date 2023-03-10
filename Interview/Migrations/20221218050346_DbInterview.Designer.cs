// <auto-generated />
using System;
using Interview.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Interview.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221218050346_DbInterview")]
    partial class DbInterview
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AdministratorPermission")
                        .HasColumnType("boolean");

                    b.Property<bool>("ConfirmationOfConversation")
                        .HasColumnType("boolean");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("InterviewTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IntervieweeId")
                        .HasColumnType("integer");

                    b.Property<int>("InterviewerId")
                        .HasColumnType("integer");

                    b.Property<double>("PayStatus")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("InterviewerId")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Data.Models.Interviewee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Dagree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("InterviewerId")
                        .HasColumnType("integer");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InterviewerId")
                        .IsUnique();

                    b.ToTable("Interviewees");
                });

            modelBuilder.Entity("Data.Models.Interviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Dagree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Projects")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Interviewers");
                });

            modelBuilder.Entity("Data.Models.Category", b =>
                {
                    b.HasOne("Data.Models.Interviewee", "Interviewee")
                        .WithOne("Category")
                        .HasForeignKey("Data.Models.Category", "InterviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Interviewer", "Interviewer")
                        .WithOne("Category")
                        .HasForeignKey("Data.Models.Category", "InterviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interviewee");

                    b.Navigation("Interviewer");
                });

            modelBuilder.Entity("Data.Models.Interviewee", b =>
                {
                    b.HasOne("Data.Models.Interviewer", "Interviewer")
                        .WithOne("Interviewee")
                        .HasForeignKey("Data.Models.Interviewee", "InterviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interviewer");
                });

            modelBuilder.Entity("Data.Models.Interviewee", b =>
                {
                    b.Navigation("Category")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Models.Interviewer", b =>
                {
                    b.Navigation("Category")
                        .IsRequired();

                    b.Navigation("Interviewee")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
