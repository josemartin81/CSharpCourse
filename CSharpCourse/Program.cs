using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpCourse
{

    class Program
    {

        static void Main(string[] args)
        {

            List<Student> lstStudent = new List<Student>();

            Student student1 = new Student("Student1", "Last_Name1", new DateTime(2000, 1, 1),
                "address1", "address2", "city", "state", "01", "country");
            Student student2 = new Student("Student2", "Last_Name2", new DateTime(2000, 1, 1),
                "address1", "address2", "city", "state", "01", "country");
            Student student3 = new Student("Student3", "Last_Name3", new DateTime(2000, 1, 1),
                "address1", "address2", "city", "state", "01", "country");

            //the grades are initializated inside the constructor
            for(int i=0; i<5; i++)
            {
                student1.grades.Push(i);
                student2.grades.Push(i);
                student3.grades.Push(i);
            }


            lstStudent.Add(student1);
            lstStudent.Add(student2);
            lstStudent.Add(student3);


            Teacher teacher1 = new Teacher("Teacher1", "Last Name", new DateTime(2000, 1, 1),
                "address1", "address2", "city", "state", "01", "country");

            Course course1 = new Course("Programming with C#", 100, 20, new Teacher[] { teacher1 },
                lstStudent );


            Degree degree1 = new Degree("Bachelor of Science", 300, new Course[] { course1 });


            UProgram uprogram1 = new UProgram("Information Technology", "Department Head", 
                new Degree[] { degree1 });


            course1.ListStudents();

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

    }
}