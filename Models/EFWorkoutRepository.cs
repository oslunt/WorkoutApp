using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutApp.Models
{
    public class EFWorkoutRepository : IWorkoutRepository
    {
        public WorkoutDbContext context { get; set; }

        public EFWorkoutRepository(WorkoutDbContext temp)
        {
            context = temp;
        }

        public IQueryable<Workout> Workouts => context.Workouts;

        public IQueryable<Exercise> Exercises => context.Exercises;

        public IQueryable<Workout_Exercise> Workout_Exercises => context.Workout_Exercises;

        public IQueryable<Day> Days => context.Days;

        public IQueryable<Stat> Stats => context.Stats;

        public void AddWorkout(Workout w)
        {
            if (w.WorkoutID == 0)
            {
                w.WorkoutID = context.Workouts.Max(w => w.WorkoutID) + 1;
                context.Workouts.Add(w);
            }
            context.SaveChanges();
        }

        public void DeleteWorkout(Workout w)
        {
            context.Remove(w);
            context.SaveChanges();
        }

        public void SaveWorkout(Workout w)
        {
            context.Update(w);
            context.SaveChanges();
        }

        public void SaveExercise(Exercise e)
        {
            context.Update(e);
            context.SaveChanges();
        }

        public void AddExercise(Exercise e)
        {
            if (e.ExerciseID == 0)
            {
                e.ExerciseID = context.Exercises.Max(e => e.ExerciseID) + 1;
                context.Exercises.Add(e);
            }
            context.SaveChanges();
        }

        public void DeleteExercise(Exercise e)
        {
            context.Remove(e);
            context.SaveChanges();
        }

        public void SaveWorkoutExercises(Workout_Exercise we)
        {
            context.Update(we);
            context.SaveChanges();
        }

        public void AddWorkoutExercises(Workout_Exercise we)
        {
            if (we.WorkoutExerciseID == 0)
            {
                we.WorkoutExerciseID = context.Workout_Exercises.Max(we => we.WorkoutExerciseID) + 1;
                context.Workout_Exercises.Add(we);
            }
            context.SaveChanges();
        }

        public void DeleteWorkoutExercises(Workout_Exercise we)
        {
            context.Remove(we);
            context.SaveChanges();
        }

        public void SaveStats(Stat s)
        {
            context.Update(s);
            context.SaveChanges();
        }

        public void AddStats(Stat s)
        {
            if(s.StatID == 0)
            {
                s.StatID = context.Stats.Max(s => s.StatID) + 1;
                context.Stats.Add(s);
            }
            context.SaveChanges();
        }

        public void DeleteStats(Stat s)
        {
            context.Remove(s);
            context.SaveChanges();
        }
    }
}
