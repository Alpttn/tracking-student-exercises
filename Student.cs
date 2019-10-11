using System;
using System.Collections.Generic;


namespace tracking_student_exercises {
     public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        //list of student exercises
        public List<Exercise> exerciseList { get; set; }

            //constructor is a method to instantiate. There is no object until you instantiate it. 
         public Student(string firstName, string lastName, string slackHandle, Cohort cohort) 
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
            exerciseList = new List<Exercise>(); 
        }

    }
}