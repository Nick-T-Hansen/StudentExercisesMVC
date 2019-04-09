using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentExercisesMVC.Models
{

    public class Cohort
    {

        //Cohort object properties
        public int Id { get; set; }
        [Required]
        public string CohortName { get; set; }

        public List<Instructor> InstructorList { get; set; }
        public List<Student> StudentList { get; set; }
    }
}