using System.Reflection;

namespace Group3_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//var a = 3; 
             //var b = 20;
             //var name1 = "Katya";
             //{ //if(a > 10)
             //  //{
             //  //    Console.WriteLine("a more  than 10");
             //  //}
             //  //else if(a < 10) 
             //  //{
             //  //    Console.WriteLine("a less than 10");
             //  //}
             //  //else
             //  //    Console.WriteLine("a=10");

                //    //if(a<=10)
                //    //    Console.WriteLine("a less or equal than 10");
                //}
                //{//if(a == 10)
                // //{
                // //    if (b == 10)
                // //        Console.WriteLine($"a = {a} and b = 10");
                // //    else
                // //        Console.WriteLine($"a = {a} and b != 10"); 
                // //}
                //}
                //const int aa = 1;
                //switch (a)
                //{
                //    case aa:
                //        {
                //            Console.WriteLine(1);
                //            break;
                //        }
                //    case 3:
                //        {
                //            Console.WriteLine(3);
                //            switch (name1)
                //            {
                //                case "Katya_":
                //                    {
                //                        Console.WriteLine(name1);
                //                        break;
                //                    }
                //                case "Katya": 
                //                    {
                //                        Console.WriteLine(name1);
                //                        break;
                //                    }
                //            }
                //            break;
                //        }
                //    case 4:
                //        {
                //            Console.WriteLine(4);
                //            break;
                //        }
                //    case 6:
                //    case 8:
                //        {
                //            Console.WriteLine(8);
                //            break;
                //        }
                //    case 10:
                //        {
                //            Console.WriteLine(10);
                //            break;
                //        }
                //    default:
                //        {
                //            Console.WriteLine("default");
                //            break;
                //        }
                //}


                //var name = "Kris";
                //Console.WriteLine("My name is " + name + "1213");
                //Console.WriteLine($"My name is {name} afssad");

                //// ?:

                //var res = a > 10 ? "a>10" : "a<10";
                //Console.WriteLine(res);
            }
            {//var a = 100;
             //while (a < 10) 
             //{
             //    Console.WriteLine($"a={a}");
             //    a++;
             //}

                //for(int i = 100; i < 10; i++)
                //{
                //    Console.WriteLine($"i={i}");
                //}

                //do
                //{
                //    Console.WriteLine($"a={a}");
                //    a++;
                //}
                //while (a < 100);

                // break;

                //int a = 10;

                //while (a < 20)
                //{
                //    Console.WriteLine($"a = {a}");
                //    a++;

                //    if (a > 15)
                //        continue;

                //    Console.WriteLine($"hello");
                //}
                //var str = "test";
                //for (; ; )
                //{
                //    str += " hello"; 
                //    Console.WriteLine($"{str}");
                //}
                //while (true)
                //{
                //    str += " hello";
                //    Console.WriteLine($"{str}");
                //}
                // int, bool, double, float, decimal, byte, char
                // string object
            }
            //int a = 1;
            //int b = 2;
            //int result = 100;
            //SumOfNubers(ref a, ref b, out result, out int res1);
            //Console.WriteLine($"{a}, {b}");
            ////SumOfNubers(3, 4); is as 
            {//Console.WriteLine("----------------------------");
             //var test1 = FindMax(1, 2);
             //Console.WriteLine(test1);
             //Console.WriteLine(FindMax(-1, 2));
             //Console.WriteLine("-------------Factorial---------------");
             //Console.WriteLine(Factorial(5));
             //Console.WriteLine(Factorial(13));
             //Console.WriteLine(Factorial(50));
            }
            //data_typep[] name;
            int[] arr1 = new int[10];
            arr1[0] = 10; arr1[1] = 20; arr1[2] = 30;

            int[] arr2 = { 12, 13, 14, 15 };

            int[] arr3 = new int[5] { 1, 4, 2, 6, 3 };

            int[] arr4 = new int[] { 32, 1, 63, 74, 84, 38 };

            var test = new int[10];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr3[i]);
            }

            foreach(var el in arr3)
            {
                Console.WriteLine(el);
            }

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