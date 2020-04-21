using System;
using System.Collections.Generic;
using System.Text;

namespace UvA.Nose.AzureMigratie.Poc.Models.ViewModel
{
    public class Course
    {        
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
