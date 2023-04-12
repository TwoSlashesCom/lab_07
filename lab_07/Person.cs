using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_07
{
    class Person : ICLlabel
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        private char gender;
        public char Gender
        {
            get { return gender; }
            set { if (value == 'M' | value == 'F') gender = value; }
        }
        public Person(string fn, string sn, char s)
        {
            Name = fn;
            Surname = sn;
            Gender = s;
        }
        public virtual string ToString()
        {
            return Name + " " + Surname + "" + Gender;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name} \t Surname: {Surname} \t Age: {Age(BirthDate)} \t Gender: {gender}");
        }
        public virtual void Read()
        {
            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Input Surname: ");
            Surname = Console.ReadLine();

            Console.WriteLine("Input date of birth (yyyy-mm-dd): ");
            BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter gender (M/F): ");
            Gender = char.Parse(Console.ReadLine());
        }
        public int Age(DateTime birthDay)
        {
            int age = DateTime.Now.Year - birthDay.Year;

            if (DateTime.Now.Day < birthDay.Day)
            {
                if (DateTime.Now.Month < birthDay.Month)
                {
                    age--;
                }
            }

            return age;
        }

    }
}
