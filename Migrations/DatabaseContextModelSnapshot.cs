﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using stackflow;

namespace sdgreacttemplate.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("VoteCount");

                    b.HasKey("Id");

                    b.ToTable("AnswerTable");
                });

            modelBuilder.Entity("stackflow.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AnswerTableId");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<int>("VoteCount");

                    b.HasKey("Id");

                    b.HasIndex("AnswerTableId");

                    b.ToTable("QuestionTable");
                });

            modelBuilder.Entity("stackflow.Models.Question", b =>
                {
                    b.HasOne("stackflow.Models.Answer", "AnswerTable")
                        .WithMany("QuestionTable")
                        .HasForeignKey("AnswerTableId");
                });
#pragma warning restore 612, 618
        }
    }
}
