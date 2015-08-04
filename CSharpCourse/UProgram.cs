using System;


namespace CSharpCourse
{
    class UProgram
    {
        public string program_name { get; set; }
        public string department_head { get; set; }
        public Degree[] degrees { get; set; }


        public UProgram(string program_name, string department_head, Degree[] degrees)
        {
            this.program_name = program_name;
            this.department_head = department_head;
            this.degrees = degrees;
        }

        public void GetInformation()
        {
            Console.WriteLine("Enter the UProgram's name: ");
            this.program_name = Console.ReadLine();
            Console.WriteLine("Enter the UProgram's department head: ");
            this.department_head = Console.ReadLine();
            Console.WriteLine("Enter the UProgram's degrees: ");
        }

        public void PrintDetails()
        {
            Console.WriteLine("{0}'s department head is: {1}", this.program_name, this.department_head);
            Console.WriteLine("{0}'s degrees is: {1}", this.program_name, this.degrees);
        }
    }
}
