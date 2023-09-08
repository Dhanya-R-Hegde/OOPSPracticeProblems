// See https://aka.ms/new-console-template for more information
namespace OOPS_Practice
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            //Inheritance

            //Employee employee = new Employee();
            //employee.salaryPrint();
            //Console.WriteLine(employee.salary);

            //Programmer programmer = new Programmer();
            //programmer.salaryPrint();
            //programmer.bonusPrint();
            //Console.WriteLine(programmer.bonus);
            //Console.WriteLine(programmer.salary);

            //Employee employee1 = new Tester();
            //employee1.salaryPrint();
            //employee1.bonusPrint(); Since the reference is of Parent class type we cannot access child class methods

            // JavaProgrammer javaProgrammer = new Programmer(); With child class reference we cannot create parent object

            //JavaProgrammer javaProgrammer1 = new JavaProgrammer();
            //javaProgrammer1.salaryPrint();

            //Encapsulation

            //Car car = new Car();
            //car.speed = 200;
            //car.Print();

            //Employee1 employee1 = new Employee1();
            //employee1.name = "Dhanya";
            //employee1.age = 21;
            //employee1.id = 02;
            //Console.WriteLine(employee1.name+" "+employee1.id+" "+employee1.age);

            //Polymorphism

            //Demo demo = new Demo();
            //demo.Addition(2, 2);
            //demo.Addition(3, 3, 3);

            Area area = new Area();
            Console.WriteLine("Area is" + area.area());

            Area circle = new Circle();
            Console.WriteLine("Area of circle is" + circle.area());

            Square square = new Square();
            Console.WriteLine("Area of square is" + square.area());

            //Abstraction

            Pig2 mypig = new Pig2();
            mypig.animalSound();
            mypig.sleep();

            //Full Abstraction with Multiple Inheritance

            IDrawable drawable;
            drawable = new Rectangle();
            drawable.draw();

            drawable = new Circle1();
            drawable.draw();

            drawable = new Square1();
            drawable.draw();

            //Constroctor

            Person1 person1 = new Person1();
            Console.WriteLine(person1.name, person1.age);

            Person1 person2 = new Person1("Achchi", 25);
            Console.WriteLine(person1.name, person1.age);

        }

        //Encapsulation data hiding(exposing data) binding data , Abstraction is for implimentation hiding(exposing implementation) hiding data, Encapsulation - can validate the data before initialising it(get and set)


    }
}
