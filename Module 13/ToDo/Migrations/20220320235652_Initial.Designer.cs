﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoApp.Data;

namespace ToDoApp.Migrations
{
    [DbContext(typeof(TicketContext))]
    [Migration("20220320235652_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoApp.Models.Sprint", b =>
                {
                    b.Property<int>("SprintId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SprintId");

                    b.ToTable("Sprints");

                    b.HasData(
                        new
                        {
                            SprintId = -1,
                            Name = "No Sprint"
                        },
                        new
                        {
                            SprintId = 1,
                            DueDate = new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 1"
                        },
                        new
                        {
                            SprintId = 2,
                            DueDate = new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 2"
                        },
                        new
                        {
                            SprintId = 3,
                            DueDate = new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 3"
                        },
                        new
                        {
                            SprintId = 4,
                            DueDate = new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 4"
                        },
                        new
                        {
                            SprintId = 5,
                            DueDate = new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 5"
                        },
                        new
                        {
                            SprintId = 6,
                            DueDate = new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 6"
                        },
                        new
                        {
                            SprintId = 7,
                            DueDate = new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 7"
                        },
                        new
                        {
                            SprintId = 8,
                            DueDate = new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 8"
                        },
                        new
                        {
                            SprintId = 9,
                            DueDate = new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 9"
                        },
                        new
                        {
                            SprintId = 10,
                            DueDate = new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sprint 10"
                        });
                });

            modelBuilder.Entity("ToDoApp.Models.Status", b =>
                {
                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = "todo",
                            Name = "To Do"
                        },
                        new
                        {
                            StatusId = "inprog",
                            Name = "In Progress"
                        },
                        new
                        {
                            StatusId = "qa",
                            Name = "Quality Assurance"
                        },
                        new
                        {
                            StatusId = "done",
                            Name = "Done"
                        });
                });

            modelBuilder.Entity("ToDoApp.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("SprintId")
                        .HasColumnType("int");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SprintId");

                    b.HasIndex("StatusId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ToDoApp.Models.Ticket", b =>
                {
                    b.HasOne("ToDoApp.Models.Sprint", "Sprint")
                        .WithMany("Tickets")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToDoApp.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sprint");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ToDoApp.Models.Sprint", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
