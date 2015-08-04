using System;

namespace CSharpCourse
{

    class Module4
    {

        public struct Student
        {
            public string first_name;
            public string last_name;
            public DateTime birthday;
            public string address_line1;
            public string address_line2;
            public string city;
            public string state_province;
            public string zip_postal;
            public string country;

            public void GetInformation()
            {
                Console.WriteLine("Enter the teacher's first name: ");
                this.first_name = Console.ReadLine();
                Console.WriteLine("Enter the teacher's last name: ");
                this.last_name = Console.ReadLine();
                Console.WriteLine("Enter the teacher's birthdate: ");
                try
                {
                    this.birthday = Convert.ToDateTime(Console.ReadLine());
                }
                catch (Exception)
                {
                    this.birthday = new DateTime();
                    Console.WriteLine("Error reading the birthday");
                }
                Console.WriteLine("Enter the teacher's address line 1: ");
                this.address_line1 = Console.ReadLine();
                Console.WriteLine("Enter the teacher's address line 2: ");
                this.address_line2 = Console.ReadLine();
                Console.WriteLine("Enter the teacher's city: ");
                this.city = Console.ReadLine();
                Console.WriteLine("Enter the teacher's state: ");
                this.state_province = Console.ReadLine();
                Console.WriteLine("Enter the teacher's zip code: ");
                this.zip_postal = Console.ReadLine();
                Console.WriteLine("Enter the teacher's country: ");
                this.country = Console.ReadLine();
            }

            public void PrintDetails()
            {
                Console.WriteLine("{0} {1} was born on: {2}", this.first_name, this.last_name, this.birthday);
                Console.WriteLine("{0} {1} lives on: {2} - {3} - {4} - {5}",
                    this.first_name, this.last_name, this.address_line1, this.city, this.state_province,
                    this.zip_postal, this.country);
            }
        }

        public struct Teacher
        {
            public string first_name;
            public string last_name;
            public DateTime birthday;
            public string address_line1;
            public string address_line2;
            public string city;
            public string state_province;
            public string zip_postal;
            public string country;

            public void GetInformation()
            {
                Console.WriteLine("Enter the Teacher's first name: ");
                this.first_name = Console.ReadLine();
                Console.WriteLine("Enter the Teacher's last name: ");
                this.last_name = Console.ReadLine();
                Console.WriteLine("Enter the Teacher's birthdate: ");
                try
                {
                    this.birthday = Convert.ToDateTime(Console.ReadLine());
                }
                catch (Exception)
                {
                    this.birthday = new DateTime();
                    Console.WriteLine("Error reading the birthday");
                }
                Console.WriteLine("Enter the Teacher's address line 1: ");
                this.address_line1 = Console.ReadLine();
                Console.WriteLine("Enter the Teacher's address line 2: ");
                this.address_line2 = Console.ReadLine();
                Console.WriteLine("Enter the Teacher's city: ");
                this.city = Console.ReadLine();
                Console.WriteLine("Enter the Teacher's state: ");
                state_province = Console.ReadLine();
                Console.WriteLine("Enter the Teacher's zip code: ");
                this.zip_postal = Console.ReadLine();
                Console.WriteLine("Enter the Teacher's country: ");
                this.country = Console.ReadLine();
            }

            public void PrintDetails()
            {
                Console.WriteLine("{0} {1} was born on: {2}", this.first_name, this.last_name, this.birthday);
                Console.WriteLine("{0} {1} lives on: {2} - {3} - {4} - {5}",
                    this.first_name, this.last_name, this.address_line1, this.city, this.state_province,
                    this.zip_postal, this.country);
            }
        }


        public struct UProgram
        {
            public string program_name;
            public string department_head;
            public string degrees;

            public void GetInformation()
            {
                Console.WriteLine("Enter the UProgram's name: ");
                this.program_name = Console.ReadLine();
                Console.WriteLine("Enter the UProgram's department head: ");
                this.department_head = Console.ReadLine();
                Console.WriteLine("Enter the UProgram's degrees: ");
                this.degrees = Console.ReadLine();
            }

            public void PrintDetails()
            {
                Console.WriteLine("{0}'s department head is: {1}", this.program_name, this.department_head);
                Console.WriteLine("{0}'s degrees is: {1}", this.program_name, this.degrees);
            }
        }

        public struct Degree
        {
            public string degree_name;
            public int credits_required;

            public void GetInformation()
            {
                Console.WriteLine("Enter the Degree's name: ");
                this.degree_name = Console.ReadLine();
                Console.WriteLine("Enter the Degree's credits required: ");
                try
                {
                    this.credits_required = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    this.credits_required = 0;
                    Console.WriteLine("Error reading the credits required");
                }

            }

            public void PrintDetails()
            {
                Console.WriteLine("{0} requires {1} credits", this.degree_name,
                    Convert.ToString(this.credits_required));
            }
        }

        public struct Course
        {
            public string course_name;
            public int credits;
            public int duration_in_weeks;
            public string teacher;

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
                Console.WriteLine("Enter the Course's teacher: ");
                this.teacher = Console.ReadLine();
            }

            public void PrintDetails()
            {
                Console.WriteLine("Course {0} has {2} credits and its teacher is",
                    this.course_name, Convert.ToString(this.credits), this.teacher);
            }
        }


        static void Main(string[] args)
        {

            //Create an array to hold 5 student structs.
            Student[] arrStudent = new Student[5];
            Student std = arrStudent[0];

            std.GetInformation();
            std.PrintDetails();

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

    }
}