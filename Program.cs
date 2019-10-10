using System;
using System.Collections.Generic;


namespace tracking_student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            // Create 3, or more, cohorts.
            // Create 4, or more, students and assign them to one of the cohorts.
            // Create 3, or more, instructors and assign them to one of the cohorts.
            // Have each instructor assign 2 exercises to each of the students.

            //create instances of exercises, cohorts, student, instructors
            Exercise exercise1 = new Exercise("Urban Planner", "JavaScript");
            Exercise exercise2 = new Exercise("Urban Planner II", "JavaScript");
            Exercise exercise3 = new Exercise("List Employees", "JavaScript");
            Exercise exercise4 = new Exercise("Address Book", "JavaScript");

            Cohort Cohort34 = new Cohort("Cohort 34");
            Cohort Cohort35 = new Cohort("Cohort 35");
            Cohort Cohort36 = new Cohort("Cohort 36");

            Student student1 = new Student("Allie", "Patton", "alpttn", Cohort34);
            Student student2 = new Student("Thomas", "Shelby", "peaky", Cohort34);
            Student student3 = new Student("Arthur", "Shelby", "blinders", Cohort35);
            Student student4 = new Student("John", "shelby", "order", Cohort36);

            Instructor instructor1 = new Instructor("Andy", "Collins", "askingALot", Cohort34, "pointing");
            Instructor instructor2 = new Instructor("Jenna", "Solis", "stuffedAnimal", Cohort35, "singing");
            Instructor instructor3 = new Instructor("Bryan", "Nielson", "highFive", Cohort36, "high fiving");

            //add instructors and students to each cohort list
            Cohort34.StudentList.Add(student1);
            Cohort34.StudentList.Add(student2);
            Cohort35.StudentList.Add(student3);
            Cohort36.StudentList.Add(student4);

            Cohort34.InstructorList.Add(instructor1);
            Cohort35.InstructorList.Add(instructor2);
            Cohort36.InstructorList.Add(instructor3);

            foreach (Instructor instructor in Cohort34.InstructorList)
            {
                foreach (Student student in Cohort34.StudentList)
                {
                    instructor.assignExercise(student, exercise1);
                    instructor.assignExercise(student, exercise2);
                }
            }
            
            foreach (Instructor instructor in Cohort35.InstructorList)
            {
                foreach (Student student in Cohort35.StudentList)
                {
                    instructor.assignExercise(student, exercise3);
                    instructor.assignExercise(student, exercise4);
                }
            }

            foreach (Instructor instructor in Cohort36.InstructorList)
            {
                foreach (Student student in Cohort36.StudentList)
                {
                    instructor.assignExercise(student, exercise1);
                    instructor.assignExercise(student, exercise2);
                }
            }


            //foreach instructor {

            // foreach student{
            // invoke assignExercise(student1 exercise)
            // invoke assignExercise(student1 DIFFEXercise)
            // }

            // }

        }
    }
}
