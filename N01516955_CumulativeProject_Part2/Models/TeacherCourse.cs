using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace N01516955_CumulativeProject_Part2.Models
{
    public class TeacherCourse
    {
        public Teacher Teacher { get; set; }

        public List<Course> Courses { get; set; }

    }
}