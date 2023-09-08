using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    internal class Inheritance
    {
        //in Inheritance child class can access the methods in  parent class but the vice versa is not true...So it is recommended create the object for child class 
    }

    public class Employee
    {
        public int salary = 4000000;

        public void salaryPrint()
        {
            Console.WriteLine("Salary : " + salary);
        }
    }

    public class Programmer : Employee //Single Inheritance
    {
        public int bonus = 10000;
        public int salary = 50000000;

        public void bonusPrint()
        {
            Console.WriteLine("Bonus : " + bonus);
        }
    }

    public class JavaProgrammer : Programmer //Multi level Inheritance
    {
        public void JavaProgrammerPrint()
        {
            Console.WriteLine("I am working on Java Project");
        }
    }

    public class Tester : Employee //Heirachical Inheritance
    {
        public int bonus = 8000;

        public void bonusPrint1()
        {
            Console.WriteLine("Bonus : " + bonus);
        }
    }

    public sealed class Parent
    {
        Parent()
        {
            Console.WriteLine("I am a sealed class");
        }
    }

    //We cannot inherite a class from a child class

    //public class Child : Parent
    //{

    //}


}
