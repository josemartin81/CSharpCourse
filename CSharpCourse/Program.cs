using System;

namespace CSharpCourse
{

    class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            //Course course1 = new Course();
            //course1.course_name = "Programming with C#";
            //course1.students = new Student[] { student1, student2, student3 };

            //Teacher teacher1 = new Teacher();
            //course1.teachers = new Teacher[] { teacher1 };

            //Degree degree1 = new Degree();
            //degree1.degree_name = "Bachelor of Science";
            //degree1.courses = new Course[] { course1 };

            //UProgram uprogram1 = new UProgram();
            //uprogram1.program_name = "Information Technology";
            //uprogram1.degrees = new Degree[] { degree1 };


            //Console.WriteLine("The {0} contains the {1} degree", uprogram1.program_name, uprogram1.degrees[0].degree_name);
            //Console.WriteLine("The {0} degree contains the course {1}", uprogram1.degrees[0].degree_name,
            //    uprogram1.degrees[0].courses[0].course_name);
            //Console.WriteLine("The {0} course contains {1} students", uprogram1.degrees[0].courses[0].course_name,
            //    Convert.ToString(uprogram1.degrees[0].courses[0].students.Length));

            //// the static varible shows the total number of instancied students
            ////Console.WriteLine("Total number of students: {0}", Convert.ToString(Student.count) );

            //Console.Write("Press any key to continue...");
            //Console.ReadKey();
        }

    }
}