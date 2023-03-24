﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Fields
{
    internal class SchoolClass
    {
        Instructor _instructor;
        Student _student;

        public SchoolClass(Instructor instructor, Student student)
        {
            _instructor = instructor;
            _student = student;
        }

        public Instructor Instructor { get => _instructor; set => _instructor = value; }
        public Student Student { get => _student; set => _student = value; }
    }
}
