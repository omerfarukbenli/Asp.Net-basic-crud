﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attilla.Entity.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
