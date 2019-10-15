using System;
using System.Collections.Generic;
using System.Linq;

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
            Exercise exercise3 = new Exercise("List Employees", "C#");
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

            List<Cohort> cohortList = new List<Cohort>();
            cohortList.Add(Cohort34);
            cohortList.Add(Cohort35);
            cohortList.Add(Cohort36);

            foreach (Cohort cohort in cohortList) //for each cohort in the cohort list do something
            {
                Instructor AnInstructor = cohort.InstructorList.First(); //give me an instructor from the list doesn't matter which one aka .First from linq
                foreach (Student student in cohort.StudentList)
                {
                    AnInstructor.assignExercise(student, exercise1);
                    AnInstructor.assignExercise(student, exercise2);
                }

            }

            List<Student> students = new List<Student>() {
                student1,
                student2,
                student3,
                student4
            };

            List<Exercise> exercises = new List<Exercise>() {
                exercise1,
                exercise2,
                exercise3,
                exercise4
            };
            List<Cohort> cohorts = new List<Cohort>() {
                Cohort34,
                Cohort35,
                Cohort36,
            };
            List<Instructor> instructors = new List<Instructor>() {
                instructor1,
                instructor2,
                instructor3,
            };

            // List exercises for the JavaScript language by using the Where() LINQ method.
            List<Exercise> listOfJavaScriptExercises = exercises.Where(exercise => exercise.Language == "JavaScript").ToList();

            foreach (Exercise exercise in listOfJavaScriptExercises)
            {
                Console.WriteLine(exercise.Name);
            }
            //List students in a particular cohort by using the Where() LINQ method.
            Console.WriteLine("----Students in cohort 34----");
            List<Student> studentsOfCohort34 = students.Where(student => student.Cohort.Name == "Cohort 34").ToList();
            foreach (Student student in studentsOfCohort34)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine("----Instructors in cohort 34----");
            //List instructors in a particular cohort by using the Where() LINQ method.
            List<Instructor> instructorsOfCohort34 = instructors.Where(instructor => instructor.Cohort.Name == "Cohort 34").ToList();
            foreach (Instructor instructor in instructorsOfCohort34)
            {
                Console.WriteLine(instructor.FirstName);
            }






            //then did this way but didn't have DRY code. would have to do this for each cohort
            // Instructor aCohort34Instructor = Cohort34.InstructorList.First();
            // foreach (Student student in Cohort34.StudentList)
            // {
            //     aCohort34Instructor.assignExercise(student, exercise1);
            //     aCohort34Instructor.assignExercise(student, exercise2);
            // }

            // I was doing it this way but then every teacher would assign me 2 exercises

            // foreach (Instructor instructor in Cohort35.InstructorList)
            // {
            //     foreach (Student student in Cohort35.StudentList)
            //     {
            //         instructor.assignExercise(student, exercise3);
            //         instructor.assignExercise(student, exercise4);
            //     }
            // }

            // foreach (Instructor instructor in Cohort36.InstructorList)
            // {
            //     foreach (Student student in Cohort36.StudentList)
            //     {
            //         instructor.assignExercise(student, exercise1);
            //         instructor.assignExercise(student, exercise2);
            //     }
            // }




        }
    }
}
