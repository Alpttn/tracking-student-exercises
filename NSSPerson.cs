using System;
using System.Collections.Generic;

namespace tracking_student_exercises
{
    public class NSSPerson 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
    }
}