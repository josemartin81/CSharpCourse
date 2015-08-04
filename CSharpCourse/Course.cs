using System;


namespace CSharpCourse
{
    class Course
    {
        public string course_name { get; set; }
        public int credits { get; set; }
        public int duration_in_weeks { get; set; }
        public Teacher[] teachers { get; set; }
        public Student[] students { get; set; }

        public Course(string course_name, int credits, int duration_in_weeks, 
            Teacher[] teachers, Student[] students)
        {
            this.course_name = course_name;
            this.credits = credits;
            this.duration_in_weeks = duration_in_weeks;
            this.teachers = teachers;
            this.students = students;
        }

        public void GetInformation()
        {
            Console.WriteLine("Enter the Course's name: ");
            this.course_name = Console.ReadLine();
            Console.WriteLine("Enter the Course's credits: ");
            try
            {
                this.credits = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                this.credits = 0;
                Console.WriteLine("Error reading the credits");
            }
            Console.WriteLine("Enter the Course's duration in weeks: ");
            try
            {
                this.duration_in_weeks = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                this.duration_in_weeks = 0;
                Console.WriteLine("Error reading the duration in weeks");
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine("Course {0} has {2} credits",
                this.course_name, Convert.ToString(this.credits));
        }
    }
}
