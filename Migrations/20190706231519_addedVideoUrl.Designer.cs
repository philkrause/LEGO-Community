﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using stackflow;

namespace sdgreacttemplate.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190706231519_addedVideoUrl")]
    partial class addedVideoUrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("stackflow.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("QuestionTableId");

                    b.Property<int>("VoteCount");

                    b.HasKey("Id");

                    b.HasIndex("QuestionTableId");

                    b.ToTable("AnswerTable");
                });

            modelBuilder.Entity("stackflow.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BluePrintUrl");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Designer");

                    b.Property<string>("Dimensions");

                    b.Property<string>("ImageUrl");

                    b.Property<int>("PieceCount");

                    b.Property<int?>("QuestionTableId");

                    b.Property<string>("Theme");

                    b.Property<string>("Title");

                    b.Property<string>("VideoUrl");

                    b.Property<int>("ViewCount");

                    b.Property<int>("VoteCount");

                    b.HasKey("Id");

                    b.HasIndex("QuestionTableId");

                    b.ToTable("ProjectTable");
                });

            modelBuilder.Entity("stackflow.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<int>("ViewCount");

                    b.Property<int>("VoteCount");

                    b.HasKey("Id");

                    b.ToTable("QuestionTable");
                });

            modelBuilder.Entity("stackflow.Models.Answer", b =>
                {
                    b.HasOne("stackflow.Models.Question", "QuestionTable")
                        .WithMany("AnswerTable")
                        .HasForeignKey("QuestionTableId");
                });

            modelBuilder.Entity("stackflow.Models.Project", b =>
                {
                    b.HasOne("stackflow.Models.Question", "QuestionTable")
                        .WithMany()
                        .HasForeignKey("QuestionTableId");
                });
#pragma warning restore 612, 618
        }
    }
}
