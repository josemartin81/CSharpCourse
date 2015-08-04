using System;


namespace Module3
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

            string teacher_first_name;
            string teacher_last_name;
            DateTime teacher_birthday;
            string teacher_address_line1;
            string teacher_address_line2;
            string teacher_city;
            string teacher_state_province;
            string teacher_zip_postal;
            string teacher_country;

            string uprogram_program_name;
            string uprogram_department_head;
            string uprogram_degrees;

            string degree_degree_name;
            int degree_credits_required;

            string course_course_name;
            int course_credits;
            int course_duration_in_weeks;
            string course_teacher;


            GetStudentInformation(out student_first_name, out student_last_name, out student_birthday, 
                out student_address_line1, out student_address_line2, out student_city, out student_state_province, 
                out student_zip_postal, out student_country);

            PrintStudentDetails(student_first_name, student_last_name, student_birthday,
                student_address_line1, student_address_line2, student_city, student_state_province,
                student_zip_postal, student_country);

            GetTeacherInformation(out teacher_first_name, out teacher_last_name, out teacher_birthday,
                out teacher_address_line1, out teacher_address_line2, out teacher_city, out teacher_state_province,
                out teacher_zip_postal, out teacher_country);

            PrintTeacherDetails(teacher_first_name, teacher_last_name, teacher_birthday,
                teacher_address_line1, teacher_address_line2, teacher_city, teacher_state_province,
                teacher_zip_postal, teacher_country);

            GetUProgramInformation(out uprogram_program_name,
                out uprogram_department_head, out uprogram_degrees);

            PrintUProgramDetails(uprogram_program_name, uprogram_department_head, uprogram_degrees);

            GetDegreeInformation(out degree_degree_name, out degree_credits_required);

            PrintDegreeDetails(degree_degree_name, degree_credits_required);

            GetCourseInformation(out course_course_name, out course_credits,
                out course_duration_in_weeks, out course_teacher);
            PrintCourseDetails(course_course_name, course_credits,
                course_duration_in_weeks, course_teacher);

            ValidateStudentBirthday(); 

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        static void GetStudentInformation(out string first_name, out string last_name,
                    out DateTime birthday, out string address_line1, out string address_line2, 
                    out string city, out string state_province, out string zip_postal,
                    out string country)
        {
            Console.WriteLine("Enter the teacher's first name: ");
            first_name = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            last_name = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthdate: ");
            try
            {
                birthday = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception)
            {
                birthday = new DateTime();
                Console.WriteLine("Error reading the birthday");
            }  
            Console.WriteLine("Enter the teacher's address line 1: ");
            address_line1 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's address line 2: ");
            address_line2 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter the teacher's state: ");
            state_province = Console.ReadLine();
            Console.WriteLine("Enter the teacher's zip code: ");
            zip_postal = Console.ReadLine();
            Console.WriteLine("Enter the teacher's country: ");
            country = Console.ReadLine();
        }

        static void PrintStudentDetails(string first_name, string last_name,
                     DateTime birthday, string address_line1, string address_line2,
                     string city, string state_province, string zip_postal,
                     string country)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first_name, last_name, birthday);
            Console.WriteLine("{0} {1} lives on: {2} - {3} - {4} - {5}",
                first_name, last_name, address_line1, city, state_province,
                zip_postal, country);
        }

        static void GetTeacherInformation(out string first_name, out string last_name,
                   out DateTime birthday, out string address_line1, out string address_line2,
                   out string city, out string state_province, out string zip_postal,
                   out string country)
        {
            Console.WriteLine("Enter the Teacher's first name: ");
            first_name = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's last name: ");
            last_name = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's birthdate: ");
            try
            {
                birthday = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception)
            {
                birthday = new DateTime();
                Console.WriteLine("Error reading the birthday");
            }
            Console.WriteLine("Enter the Teacher's address line 1: ");
            address_line1 = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's address line 2: ");
            address_line2 = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's state: ");
            state_province = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's zip code: ");
            zip_postal = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's country: ");
            country = Console.ReadLine();
        }

        static void PrintTeacherDetails(string first_name, string last_name,
                     DateTime birthday, string address_line1, string address_line2,
                     string city, string state_province, string zip_postal,
                     string country)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first_name, last_name, birthday);
            Console.WriteLine("{0} {1} lives on: {2} - {3} - {4} - {5}",
                first_name, last_name, address_line1, city, state_province,
                zip_postal, country);
        }

        static void GetUProgramInformation(out string program_name,
                out string department_head, out string degrees)
        {
            Console.WriteLine("Enter the UProgram's name: ");
            program_name = Console.ReadLine();
            Console.WriteLine("Enter the UProgram's department head: ");
            department_head = Console.ReadLine();
            Console.WriteLine("Enter the UProgram's degrees: ");
            degrees = Console.ReadLine();
        }

        static void PrintUProgramDetails(string program_name,
                string department_head, string degrees)
        {
            Console.WriteLine("{0}'s department head is: {1}", program_name, department_head );
            Console.WriteLine("{0}'s degrees is: {1}", program_name, degrees);
        }

        static void GetDegreeInformation(out string degree_name,
                out int credits_required)
        {
            Console.WriteLine("Enter the Degree's name: ");
            degree_name = Console.ReadLine();
            Console.WriteLine("Enter the Degree's credits required: ");
            try
            {
                credits_required = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                credits_required = 0;
                Console.WriteLine("Error reading the credits required");
            }
            
        }

        static void PrintDegreeDetails(string degree_name,
                int credits_required)
        {
            Console.WriteLine("{0} requires {1} credits", degree_name, Convert.ToString(credits_required));
        }


        static void GetCourseInformation(out string course_name,
            out int credits, out int duration_in_weeks,
            out string teacher)
        {
            Console.WriteLine("Enter the Course's name: ");
            course_name = Console.ReadLine();
            Console.WriteLine("Enter the Course's credits: ");
            try
            {
                credits = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                credits = 0;
                Console.WriteLine("Error reading the credits");
            }
            Console.WriteLine("Enter the Course's duration in weeks: ");
            try
            {
                duration_in_weeks = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                duration_in_weeks = 0;
                Console.WriteLine("Error reading the duration in weeks");
            }
            Console.WriteLine("Enter the Course's teacher: ");
            teacher = Console.ReadLine();
        }

        static void PrintCourseDetails(string course_name,
            int credits, int duration_in_weeks,
            string teacher)
        {
            Console.WriteLine("Course {0} has {2} credits and its teacher is",
                course_name, Convert.ToString(credits), teacher);
        }

        static void ValidateStudentBirthday()
        {
            throw new NotImplementedException(); 
        }
    }
}