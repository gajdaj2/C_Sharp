﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_3
{
    class GradeBook
    {

        List<float> grades;


        public GradeBook()
        {
            grades = new List<float>();
        }


        
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
    }
}
