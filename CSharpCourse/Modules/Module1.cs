using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables declaration
            string student_first_name;
            string student_last_name;
            DateTime student_birthday;
            string student_address_line1;
            string student_address_line2;
            string student_city;
            string student_state_province;
            string student_zip_postal;
            string student_country;

            //string teacher_first_name;
            //string teacher_last_name;
            //DateTime teacher_birthday;
            //string teacher_address_line1;
            //string teacher_address_line2;
            //string teacher_city;
            //string teacher_state_province;
            //string teacher_zip_postal;
            //string teacher_country;

            //string uprogram_program_name;
            //string uprogram_department_head;
            //string uprogram_degrees;

            //string degree_degree_name;
            //int degree_credits_required;

            //string course_course_name;
            //int course_credits;
            //int course_duration_in_weeks;
            //string course_teacher;

            //variables assigment (only to one set as is indicated in section 3)
            student_first_name = "Jose";
            student_last_name = "Martin";
            student_birthday = new DateTime(1980, 1, 1);
            student_address_line1 = "Mayor Road";
            student_address_line2 = "1";
            student_city = "Madrid";
            student_state_province = "Madrid";
            student_zip_postal = "28000";
            student_country = "Spain";

            Console.WriteLine("Student - First Name: " + student_first_name);
            Console.WriteLine("Student - Last Name: " + student_last_name);
            Console.WriteLine("Student - Birthday: " + student_birthday.ToShortDateString());
            Console.WriteLine("Student - Address Line1: " + student_address_line1);
            Console.WriteLine("Student - Address Line2: " + student_address_line2);
            Console.WriteLine("Student - City: " + student_city);
            Console.WriteLine("Student - State / Province: " + student_state_province);
            Console.WriteLine("Student - Zip / Postal: " + student_zip_postal);
            Console.WriteLine("Student - Country: " + student_country);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}