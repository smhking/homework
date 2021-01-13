using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace naw_w_taman
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; int age; int year = 2021; int result;

            Console.WriteLine("enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            result = year - age;

            Console.WriteLine("<<<< your name is " + name + " and your birth date is " + result+" >>>>");
            Console.ReadLine();

            

        }
    }
}
