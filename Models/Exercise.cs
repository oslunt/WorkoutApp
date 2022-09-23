using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutApp.Models
{
    public class Exercise
    {
        [Key]
        [Required]
        public int ExerciseID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
