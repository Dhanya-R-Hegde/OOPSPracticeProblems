using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    internal class Abstraction
    {
    }

    abstract class Animal2 //Abstract Class
    {
        public abstract void animalSound(); // abstract Method
        public void sleep()   //normal Method
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig2 : Animal2 //Derived
    {
        public override void animalSound()
        {
            Console.WriteLine("The Pig says wee wee");
        }
    }

    // Interfaces -- Used to achieve Multiple inheritance as well as full abstraction. 
    //  Methods inside a interface are abstract methods means they are having name but they don't have body.

    public interface IDrawable
    {
        void draw();
    }

    public class Rectangle : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }

    public class Circle1 : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }

    public class Square1 : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Draw Square");
        }
    }
}
