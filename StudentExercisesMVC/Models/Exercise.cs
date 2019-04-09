
 /*
You must define a type for representing an exercise in code. An exercise can be assigned to many students.

Name of exercise
Language of exercise (JavaScript, Python, CSharp, etc.)
 */

using System;
using System.ComponentModel.DataAnnotations;

namespace StudentExercisesMVC.Models

{
    public class Exercise
    {
        /*
        // Constructor for exercise object
        public Exercise(string exercise, string language) {
            ExerciseName = exercise;
            ExerciseLanguage = language;
        }
        */
        public Exercise()
        {
        }
        
        //Exercise object properties
        public int Id { get; set; }
        [Required]
        public string ExerciseName {get; set;}
        [Required]
        public string ExerciseLanguage {get; set;}


    }
}