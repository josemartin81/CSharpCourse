using System;

namespace CSharpCourse
{
    class Student : Person
    {

        public static int count = 0;

        public Student()
        {
            count++;
        }
    }
}
