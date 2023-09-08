using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    internal class Polymorphism
    {
        //Static/Compile-time Polymorpism : Method Overloading, Operator Overloading
        //It is also called Early binding
        //Dynamic/Run-time Polymorphism : Method Overriding
        //It is also called Late binding
    }

    public class Demo
    {
        //Method Overloading

        public void Addition(int a, int b, int c)
        {
            int x = a + b + c;
            Console.WriteLine(x);
        }

        public void Addition(int a, int b)
        {
            int y = a + b;
            Console.WriteLine(y);
        }

        public void Addition(float a, float b)
        {
            float y = a + b;
            Console.WriteLine(y);
        }
    }

    //Method Overriding

    public class Area
    {
        public virtual double area() //virtual keyword is used in the  methods of parent class
        {
            return 0;
        }
    }
       

        public class Square : Area
        {

            public double Length { get; set; }
            public Square()
            {
                Length = 5;
            }

            public override double area() 
            {
                return Math.Pow(Length, 2);
            }
        }

        public class Circle : Area
        {
            public double Radius { get; set; }

            public Circle()
            {
                Radius = 5;
            }

            public override double area() //override keyword is used in the overriding methods of child class
            {
                return (3.14) * Math.Pow(Radius, 2);
            }
        }


}
