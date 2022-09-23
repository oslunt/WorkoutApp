﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkoutApp.Models;

namespace WorkoutApp.Migrations
{
    [DbContext(typeof(WorkoutDbContext))]
    [Migration("20220615214101_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WorkoutApp.Models.Day", b =>
                {
                    b.Property<int>("DayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DayID");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("WorkoutApp.Models.Exercise", b =>
                {
                    b.Property<int>("ExerciseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ExerciseID");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("WorkoutApp.Models.Stat", b =>
                {
                    b.Property<int>("StatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ExerciseID")
                        .HasColumnType("int");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time(6)");

                    b.Property<float>("Weight")
                        .HasColumnType("float");

                    b.Property<int>("WorkoutID")
                        .HasColumnType("int");

                    b.HasKey("StatID");

                    b.HasIndex("ExerciseID");

                    b.HasIndex("WorkoutID");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("WorkoutApp.Models.Workout", b =>
                {
                    b.Property<int>("WorkoutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DayID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("WorkoutID");

                    b.HasIndex("DayID");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("WorkoutApp.Models.Workout_Exercise", b =>
                {
                    b.Property<int>("WorkoutExerciseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Eccentric")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ExerciseID")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseNum")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutID")
                        .HasColumnType("int");

                    b.HasKey("WorkoutExerciseID");

                    b.HasIndex("ExerciseID");

                    b.HasIndex("WorkoutID");

                    b.ToTable("Workout_Exercises");
                });

            modelBuilder.Entity("WorkoutApp.Models.Stat", b =>
                {
                    b.HasOne("WorkoutApp.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkoutApp.Models.Workout", "Workout")
                        .WithMany()
                        .HasForeignKey("WorkoutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkoutApp.Models.Workout", b =>
                {
                    b.HasOne("WorkoutApp.Models.Day", "Day")
                        .WithMany()
                        .HasForeignKey("DayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkoutApp.Models.Workout_Exercise", b =>
                {
                    b.HasOne("WorkoutApp.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkoutApp.Models.Workout", "Workout")
                        .WithMany()
                        .HasForeignKey("WorkoutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}