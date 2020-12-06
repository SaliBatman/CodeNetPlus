﻿// <auto-generated />
using System;
using CodeNet.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeNet.API.Migrations
{
    [DbContext(typeof(CodeNetContext))]
    [Migration("20201205142940_UserNameTypeChanged")]
    partial class UserNameTypeChanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CodeNet.Domain.Entities.CodeNote", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("GeneralSubjectId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsBookMarked")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<long>("NoteTypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SpecificSubjectId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("GeneralSubjectId");

                    b.HasIndex("NoteTypeId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SpecificSubjectId");

                    b.HasIndex("UserId");

                    b.ToTable("CodeNote");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.CodeNoteDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("CodeNoteId")
                        .HasColumnType("bigint");

                    b.Property<string>("CodeSyntax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProgrammingLanguageId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CodeNoteId");

                    b.HasIndex("ProgrammingLanguageId");

                    b.ToTable("CodeNoteDetail");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.GeneralSubject", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("GeneralSubject");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.NoteType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("NoteType");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.ProgrammingLanguage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProgrammingLanguage");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.SpecificSubject", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("GeneralSubjectId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralSubjectId");

                    b.ToTable("SpecificSubject");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("IsActive")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.CodeNote", b =>
                {
                    b.HasOne("CodeNet.Domain.Entities.GeneralSubject", "GeneralSubject")
                        .WithMany("CodeNotes")
                        .HasForeignKey("GeneralSubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CodeNet.Domain.Entities.NoteType", "NoteType")
                        .WithMany("CodeNotes")
                        .HasForeignKey("NoteTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CodeNet.Domain.Entities.Project", "Project")
                        .WithMany("CodeNotes")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CodeNet.Domain.Entities.SpecificSubject", "SpecificSubject")
                        .WithMany("CodeNotes")
                        .HasForeignKey("SpecificSubjectId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CodeNet.Domain.Entities.User", "User")
                        .WithMany("CodeNotes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GeneralSubject");

                    b.Navigation("NoteType");

                    b.Navigation("Project");

                    b.Navigation("SpecificSubject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.CodeNoteDetail", b =>
                {
                    b.HasOne("CodeNet.Domain.Entities.CodeNote", "CodeNote")
                        .WithMany("CodeNetDetails")
                        .HasForeignKey("CodeNoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeNet.Domain.Entities.ProgrammingLanguage", "ProgrammingLanguage")
                        .WithMany("CodeNoteDetails")
                        .HasForeignKey("ProgrammingLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodeNote");

                    b.Navigation("ProgrammingLanguage");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.GeneralSubject", b =>
                {
                    b.HasOne("CodeNet.Domain.Entities.User", "User")
                        .WithMany("GeneralSubjects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.NoteType", b =>
                {
                    b.HasOne("CodeNet.Domain.Entities.User", "User")
                        .WithMany("NoteTypes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.Project", b =>
                {
                    b.HasOne("CodeNet.Domain.Entities.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.SpecificSubject", b =>
                {
                    b.HasOne("CodeNet.Domain.Entities.GeneralSubject", "GeneralSubject")
                        .WithMany("SpecificSubjects")
                        .HasForeignKey("GeneralSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GeneralSubject");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.CodeNote", b =>
                {
                    b.Navigation("CodeNetDetails");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.GeneralSubject", b =>
                {
                    b.Navigation("CodeNotes");

                    b.Navigation("SpecificSubjects");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.NoteType", b =>
                {
                    b.Navigation("CodeNotes");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.ProgrammingLanguage", b =>
                {
                    b.Navigation("CodeNoteDetails");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.Project", b =>
                {
                    b.Navigation("CodeNotes");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.SpecificSubject", b =>
                {
                    b.Navigation("CodeNotes");
                });

            modelBuilder.Entity("CodeNet.Domain.Entities.User", b =>
                {
                    b.Navigation("CodeNotes");

                    b.Navigation("GeneralSubjects");

                    b.Navigation("NoteTypes");

                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
