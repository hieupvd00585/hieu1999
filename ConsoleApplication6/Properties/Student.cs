using System;

namespace ConsoleApplication6.Properties
{
    public class Student
    {
        private String name;
        private String rollNumber;
        private String email;
        private String phone;

        public Student(string name, string rollNumber, string email, string phone)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.email = email;
            this.phone = phone;
        }

        public Student()
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string RollNumber
        {
            get { return rollNumber; }
            set { rollNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public override string ToString()
        {
            return this.email + this.rollNumber + this.email + this.phone;
        }
    }
}