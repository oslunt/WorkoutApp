using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutApp.Models
{
    public class Workout_Exercise
    {
        [Required]
        [Key]
        public int WorkoutExerciseID { get; set; }
        [Required]
        public int WorkoutID { get; set; }
        public Workout Workout { get; set; }
        [Required]
        public int ExerciseID { get; set; }
        public Exercise Exercise { get; set; }
        [Required]
        public bool Eccentric { get; set; }
        [Required]
        public int ExerciseNum { get; set; }
    }
}
