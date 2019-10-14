﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesQuestion.Data;

namespace RazorPagesQuestion.Migrations
{
    [DbContext(typeof(RazorPagesQuestionContext))]
    [Migration("20191014075111_InitialCreateList")]
    partial class InitialCreateList
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesQuestion.Models.Waitinglist", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Enddtime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Starttime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Waitinglist");
                });

            modelBuilder.Entity("RazorPagesQuestions.Models.Question", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Lokaal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vraag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaitinglistID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("WaitinglistID");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("RazorPagesQuestions.Models.Question", b =>
                {
                    b.HasOne("RazorPagesQuestion.Models.Waitinglist", null)
                        .WithMany("Questions")
                        .HasForeignKey("WaitinglistID");
                });
#pragma warning restore 612, 618
        }
    }
}