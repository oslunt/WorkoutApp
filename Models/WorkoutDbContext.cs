using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutApp.Models
{
    public class WorkoutDbContext : DbContext
    {
        public WorkoutDbContext(DbContextOptions<WorkoutDbContext> options) : base(options)
        {

        }

        public DbSet<Day> Days { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Workout_Exercise> Workout_Exercises { get; set; }
    }
}
