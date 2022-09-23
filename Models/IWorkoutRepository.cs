using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutApp.Models
{
    public interface IWorkoutRepository
    {
        public IQueryable<Workout> Workouts { get; }
        public void SaveWorkout(Workout w);
        public void AddWorkout(Workout w);
        public void DeleteWorkout(Workout w);

        public IQueryable<Exercise> Exercises { get; }
        public void SaveExercise(Exercise e);
        public void AddExercise(Exercise e);
        public void DeleteExercise(Exercise e);

        public IQueryable<Workout_Exercise> Workout_Exercises { get; }
        public void SaveWorkoutExercises(Workout_Exercise we);
        public void AddWorkoutExercises(Workout_Exercise we);
        public void DeleteWorkoutExercises(Workout_Exercise we);

        public IQueryable<Day> Days { get; }

        public IQueryable<Stat> Stats { get; }
        public void SaveStats(Stat s);
        public void AddStats(Stat s);
        public void DeleteStats(Stat s);
    }
}
