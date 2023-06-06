using System.Reflection;

namespace Group3_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStudent = new Student() {name = "My name", age = 25 };
            //myStudent.Name = "Test";
            myStudent.Print();

            var myTeacher = new Teacher("Kris");
            myTeacher.Print();

            var calc = new Calculator();
            calc.Sum(4, 6);
            calc.Sum(4, 6, 7);
            calc.Sum(4, 6, 7,12);
            calc.Sum(3.5, 5.5);

            if (myTeacher is Teacher)
                Console.WriteLine("Teacher");

            if (myStudent is Teacher)
                Console.WriteLine("Teacher");

            if (myStudent is Person)
                Console.WriteLine("Person");
        }
        //Access_specifier return_type MethodName (parameters)
        //{
        //    MethodBody 
        //}

        public static void SumOfNubers(ref int a, ref int b, out int res, out int res1)
        {
            a += 10;
            b += 100;
            res = a + b;
            res1 = b;
            Console.WriteLine(res);
            Console.WriteLine($"{a}, {b}");
        }

        public static int FindMax(int a, int b)
        {
            int result;
            result = a > b ? a : b;
            return result;
            // return a > b ? a : b;
        }
        public static ulong Factorial(ulong num)
        {
            if (num < 1)
                return 100;

            ulong result;
            if (num == 1)
                return 1;
            else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }
    }
}