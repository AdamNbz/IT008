﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    public class Student
    {
        public string name, id, department;
        public double score;
        public int tp;
        public Student(string id, string name, string department, double score, int tp)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.score = score;
            this.tp = tp;
        }
    }
}
