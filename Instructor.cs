using System;

namespace tracking_student_exercises
{

    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string InstructorSpeciality { get; set; }

        public Instructor(string firstName, string lastName, string slackHandle, Cohort cohort, string instructorSpeciality)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
            InstructorSpeciality = instructorSpeciality;
        }

        public void assignExercise(Student student, Exercise exercise) {
            student.exerciseList.Add(exercise);
        }

    }
}