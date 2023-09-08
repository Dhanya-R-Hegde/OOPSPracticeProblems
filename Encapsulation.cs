using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    internal class Encapsulation
    {

    }

    class Car
    {
        private int _speed;

        public int speed
        {
            get {return _speed; }
            set { _speed = value; }
        }

        public void Print()
        {
            Console.WriteLine(_speed);
        }
    }

    class Person
    {
        private string _name;
        private int _age;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_age);
        }
    }

    public class Employee1
    {
        public int id { get; set; }

        public string name { get; set; }

        public int age { get; set; }
    }
}
