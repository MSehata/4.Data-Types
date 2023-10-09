using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the name? ");
            string name = Console.ReadLine();
            Console.Write("What is the age? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("What is the weight? ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write(name + " is tall. True or False: ");
            bool isTall = Convert.ToBoolean(Console.ReadLine().ToLower());

            Console.WriteLine(name + " is " + age + " years old and weighs " + weight + "KG");
            Console.WriteLine(name + " is Tall results with: " + isTall);
        }
    }
}
