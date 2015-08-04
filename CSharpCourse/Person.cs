using System;
using System.Collections;

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

    }
}
