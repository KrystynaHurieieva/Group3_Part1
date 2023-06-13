using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GENERIC <> List<> Dictionary<> , SortedList<>, Stack<>, Queue<>
            // NON GENERIC ArrayList HashTable SortedList Stack Queue

            //STACK
            //var stack = new Stack();
            //stack.Push('A');
            //stack.Push('B');
            //stack.Push(1);
            //stack.Push(new Car().ToString());
            //foreach (var i in stack)
            //    Console.WriteLine(i);

            //stack.Pop();
            //foreach (var i in stack)
            //    Console.WriteLine(i);

            //Console.WriteLine($"Peek: {stack.Peek()}");
            //Console.WriteLine($"Peek: {stack.Peek()}");
            //Console.WriteLine($"Peek: {stack.Peek()}");

            //var queue = new Queue<int>();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Enqueue(40);

            //foreach (var i in queue)
            //    Console.WriteLine(i);

            //var el1 = queue.Dequeue();
            //var el2 = queue.Dequeue();
            //Console.WriteLine($"Deleted: {el1}, {el2}");
            //foreach (var i in queue)
            //    Console.WriteLine(i);

            //Dictionary<key, value>

            //var dictionary  = new Dictionary<string, Car>();
            //dictionary.Add("121345678", new Car() { Model = "BMW" });
            //dictionary.Add("etggfhjughjf", new Car() { Model = "Mazda" });
            //dictionary.Add("23546756ifg", new Car() { Model = "VW" });
            //dictionary.Add("dhdtjyfyt", new Car() { Model = "Запорожець" });
            //dictionary.Add("sfrsgdr", new Car() { Model = "Tesla" });

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value.ToString()}");
            //}
            //var keys = dictionary.Keys;
            //var values = dictionary.Values;

            //foreach (var item in keys)
            //{
            //    Console.WriteLine($"Key: {item}");
            //}

            //foreach (var item in values)
            //{
            //    Console.WriteLine($" Value: {item.ToString()}");
            //}

            //dictionary.Remove("dhdtjyfyt");
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value.ToString()}");
            //}

            // LINQ to Objects 
            // LINQ To Entities
            // LINQ To XML 
            // LINQ To DataSet 
            // PLINQ

            //var test = new List<string>() { "Tom", "Kris", "Bob", "Sam", "Bill", "Kira", "George" };

            //var sel = from p in test
            //          where p.ToLower().StartsWith('b')
            //          orderby p
            //          select p;

            //var sel1 = test.Where(x => x.ToLower().StartsWith('k')).OrderByDescending(p => p);


            //var res = test.Select(x => x.ToUpper());

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in sel)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in sel1)
            //{
            //    Console.WriteLine(item);
            //}

            var list = new List<List<string>>()
            {
                new List<string>() { "VW", "Toyota", "Mazda", "Tesla"},
                new List<string>() {"Tom", "Kris", "Bob", "Sam", "Bill", "Kira", "George" },
                new List<string>() {"Red", "Black", "White", "Green"}
            };

            //var res = list.SelectMany(x => x.Select(y=> y.ToLower().StartsWith('k'))).ToList();
            // var res = list.SelectMany((x,y) => ))
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //var test = new List<string>() { "Tom", "Kris", "Bob", "Tom", "Kris", "Bob", "Sam", "Sam", "Bill", "Kira", "George" };
            //var test1 = new List<string>() { "VW", "Toyota", "Kris", "Bob", "Mazda", "Tesla" };
            //var test2 = new List<string>() { "Red", "Black", "White", "Green", "Tom", "Kris", "Bob" };
            ////foreach (var item in test.Distinct())
            ////{
            ////    Console.WriteLine(item);
            ////}

            //var res = test.Union(test1).Union(test2).Take(4);
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Union: {item}");
            //}
            //var res1 = test.Intersect(test1).Intersect(test2);
            //foreach (var item in res1)
            //{
            //    Console.WriteLine($"Intersect: {item}");
            //}
            List<string> animals = new List<string>() { "cat", "dog", "donkey" };

            List<int> number = new List<int>() { 10, 20 };


            var mix = number.SelectMany(num => animals, (n, a) => new { n, a });

            foreach (var item in mix)
            {
                Console.WriteLine(item);
            }

            // Single -> SingleOrDefault
            // FIRST -> FirstOrDefault


        }
    }
}