
namespace Group3_Part1
{
    public class Student : Person
    {
        public Student(string name1, int age1)
        {
            Console.WriteLine("Constructor 3");
            name = name1;
            age = age1;
        }

        public Student(string name) : this(name, 18)
        {
            Console.WriteLine("Constructor 2");
        }

        public Student() : this("Unknown")
        {
            Console.WriteLine("Constructor 1");
        }

        public void Print()
        {
            Console.WriteLine($"Student's Name: {this.name}");
        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    public sealed class Teacher : Person
    {
        public Teacher(string name, int age) : this(name)
        {
            Console.WriteLine("Constructor 3");
            this.age = age;
        }

        public Teacher(string name)
        {
            this.name = name;
            Console.WriteLine("Constructor 2");
        }

        public Teacher()
        {
            Console.WriteLine("Constructor 1");
            CalculateSallary();
        }
        public void Print()
        {
            Console.WriteLine($"Teacher's Name: {name}");
        }
        public void Print(string message)
        {
            Console.WriteLine($"{message}");
        }

        private void CalculateSallary()
        {
            Console.WriteLine($"CalculateSallary");
        }
    }

    public class Calculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine($"{a + b}");
        }
        public void Sum(int a, int b, int c)
        {
            Console.WriteLine($"{a + b + c}");
        }
        public void Sum(int a, int b, int c, int d = 0)
        {
            Console.WriteLine($"{a + b + c + d}");
        }
        public void Sum(double a, double b)
        {
            Console.WriteLine($"{a + b}");
        }
    }
    // private              -
    // private protected 
    // file 
    // protected            -
    // internal 
    // protected internal 
    // public               -
}
