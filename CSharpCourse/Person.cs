using System;

namespace CSharpCourse
{
    class Person
    {

        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime birthday { get; set; }
        public string address_line1 { get; set; }
        public string address_line2 { get; set; }
        public string city { get; set; }
        public string state_province { get; set; }
        public string zip_postal { get; set; }
        public string country { get; set; }

        public Person(string first_name, string last_name, DateTime birthday,
            string address_line1, string address_line2, string city,
            string state_province, string zip_postal, string country)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.birthday = birthday;
            this.address_line1 = address_line1;
            this.address_line2 = address_line2;
            this.city = city;
            this.state_province = state_province;
        }


        public void GetInformation()
        {
            Console.WriteLine("Enter the first name: ");
            this.first_name = Console.ReadLine();
            Console.WriteLine("Enter the last name: ");
            this.last_name = Console.ReadLine();
            Console.WriteLine("Enter the birthdate: ");
            try
            {
                this.birthday = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception)
            {
                this.birthday = new DateTime();
                Console.WriteLine("Error reading the birthday");
            }
            Console.WriteLine("Enter the address line 1: ");
            this.address_line1 = Console.ReadLine();
            Console.WriteLine("Enter the address line 2: ");
            this.address_line2 = Console.ReadLine();
            Console.WriteLine("Enter the city: ");
            this.city = Console.ReadLine();
            Console.WriteLine("Enter the state: ");
            this.state_province = Console.ReadLine();
            Console.WriteLine("Enter the zip code: ");
            this.zip_postal = Console.ReadLine();
            Console.WriteLine("Enter the country: ");
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
}
