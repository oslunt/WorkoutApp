using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutApp.Models
{
    public class Stat
    {
        [Key]
        [Required]
        public int StatID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int Reps { get; set; }
        public float Weight { get; set; }
        public float Time { get; set; }
        public int WorkoutExerciseID { get; set; }
        public Workout_Exercise Workout_Exercise { get; set; }
    }
}
