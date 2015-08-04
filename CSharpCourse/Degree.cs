using System;


namespace CSharpCourse
{
    class Degree
    {
        public string degree_name { get; set; }
        public int credits_required { get; set; }
        public Course[] courses { get; set; }

        public Degree(string degree_name, int credits_required, Course[] courses)
        {
            this.degree_name = degree_name;
            this.credits_required = credits_required;
            this.courses = courses;
        }

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
}
