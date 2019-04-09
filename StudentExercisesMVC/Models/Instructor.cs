using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentExercisesMVC.Models

{    public class Instructor
    {
        /*
        public Instructor(string firstN, string lastN, string slackHandle, int cohortId)
        {
            //constructor for Instructor object
            FirstName = firstN;
            LastName = lastN;
            Slack = slackHandle;
            CohortId = cohortId;
        }
        */

        //Instructor object properties
        public int Id { get; set; }
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        [StringLength(12, MinimumLength = 3)]
        public string Slack {get; set;}
        public int CohortId {get; set;}

        public Cohort Cohort { get; set; }
        public List<Exercise> ExerciseList { get; set; }

    }
}
