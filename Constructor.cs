using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    internal class Constructor
    {

    }

    public class Person1
    {
        public string name;
        public int age;

        public Person1() 
        {
            name = "Dhanya";
            age = 21;
        }

        //Constructor overloading
        public Person1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
