using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// List <T> 
            //List<int> numbers = new List<int>(10) { 1,35,73,84,99};
            //Console.WriteLine("numbers.Capacity : "+ numbers.Capacity);// 8 16
            //var numbers2 = new List<int>() { 43, 23, 6, 9, 3, 88, 26 };
            //numbers.Add(453);
            //numbers.AddRange(numbers2);
            //Console.WriteLine("numbers.Capacity : " + numbers.Capacity);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(numbers[3]);

            var list = new List<string>() {"K", "R", "S" };
            var linkedList = new LinkedList<string>(list); // LinkedListNode

            Console.WriteLine(linkedList.Count());
            Console.WriteLine(linkedList.First?.Value);
            Console.WriteLine(linkedList.Last?.Value);

            var currentNode = linkedList.Last;
            while (currentNode != null)
            {
                if(currentNode.Value == "R")
                {
                    linkedList.AddAfter(currentNode, "I");
                    break;
                }
                currentNode = currentNode.Previous;
            }

            var currentNode1 = linkedList.First;
            while (currentNode1 != null)
            {
                Console.WriteLine($"currentNode1: {currentNode1.Value}");
                if (currentNode1.Value == "R")
                {
                    linkedList.AddAfter(currentNode1, "R");
                }
                currentNode1 = currentNode1.Next;
            }


            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            

            // 1,2,3,44,4,5,6
        }
    }
}