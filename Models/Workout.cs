using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutApp.Models
{
    public class Workout
    {
        [Key]
        [Required]
        public int WorkoutID { get; set; }
        [Required]
        public string Name { get; set; }
        public int DayID { get; set; }
        public Day Day { get; set; }
        public int PersonID { get; set; }
    }
}
