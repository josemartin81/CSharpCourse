using System;

namespace CSharpCourse
{
    class Student : Person
    {

        public static int count = 0;

        public Student(string first_name, string last_name, DateTime birthday,
            string address_line1, string address_line2, string city,
            string state_province, string zip_postal, string country) : base(first_name, 
                last_name, birthday, address_line1, address_line2, city,
                state_province, zip_postal, country)
        {
            count++;
        }

        public void TakeTest()
        {
            Console.WriteLine("Student {0} {1} take a test", this.first_name , this.last_name );
        }
    }
}
