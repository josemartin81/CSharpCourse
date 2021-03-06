﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpCourse
{
    class Course
    {
        public string course_name { get; set; }
        public int credits { get; set; }
        public int duration_in_weeks { get; set; }
        public Teacher[] teachers { get; set; }
        public List<Student> students { get; set; }

        public Course(string course_name, int credits, int duration_in_weeks, 
            Teacher[] teachers, List<Student> students)
        {
            this.course_name = course_name;
            this.credits = credits;
            this.duration_in_weeks = duration_in_weeks;
            this.teachers = teachers;
            this.students = students;
        }

        public void ListStudents()
        {
            Console.WriteLine("List of students:");
            if (students != null){
                foreach(Student item in this.students)
                {
                    Console.WriteLine("{0} {1}", item.first_name, item.last_name);
                }
            }
        }
    }
}
