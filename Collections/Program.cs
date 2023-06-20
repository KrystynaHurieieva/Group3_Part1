using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { //// LArge Object Heap -- 85 000 bytes 
            ////int t;

            ////Int16 y;
            ////Int32 x;
            ////Int64 tt;

            //// AddMemoryPressure   - REMOVEMemoryPressure
            //// Collect 
            //// GetGeneration(Obeject)
            //// GetTotalMemory 
            //// WaitForPendingFinalizers
            //var list = new List<string>() { "K", "R", "S", "R" };
            //var linkedList = new LinkedList<string>(list); // LinkedListNode

            ////Console.WriteLine(linkedList.Count());
            ////Console.WriteLine(linkedList.First?.Value);
            ////Console.WriteLine(linkedList.Last?.Value);

            //var currentNode = linkedList.Last;
            ////while (currentNode != null)
            ////{
            ////    if (currentNode.Value == "R")
            ////    {
            ////        linkedList.AddAfter(currentNode, "I");
            ////        break;
            ////    }
            ////    currentNode = currentNode.Previous;
            ////}

            //var currentNode1 = linkedList.First;
            ////while (currentNode1 != null)
            ////{
            ////    //Console.WriteLine($"currentNode1: {currentNode1.Value}");
            ////    if (currentNode1.Value == "R")
            ////    {
            ////        linkedList.AddAfter(currentNode1, "R");
            ////    }
            ////    currentNode1 = currentNode1.Next;
            ////}


            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}

            //var totalMemory = GC.GetTotalMemory(false);
            //Console.WriteLine(totalMemory);
            //GC.Collect();
            //totalMemory = GC.GetTotalMemory(false);
            //Console.WriteLine(totalMemory);

            // try - catch -- finally 
            // throw 

            //try
            //{
            //object test = null;
            //var test1 = 0;
            //var test2 = 6;
            //var test3 = 2;

            //var res = test2 * test1;
            ////var res1 = test2 / test1;
            //var res2 = test2 / test3;
            ////var res12 = int.Parse("t");
            //if(res2 > 2)
            //{
            //    throw new Exception("My message");
            //}


            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine($"NullReferenceException {ex.Message}");
            //}
            //catch (StackOverflowException ex)
            //{
            //    Console.WriteLine($"StackOverflowException {ex.Message}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"DivideByZeroException {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine($"Finally ");
            //}?
            }

            Student st = null;
            try
            {
                st = new Student();
                st.Name = "test2143423";
                ValidateStudent(st);
            }
            catch (InvalidStudentNameException ex)
            {

                Console.WriteLine($"InvalidStudentNameException {ex.Message}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exception {ex.Message}");
            }
        }

        private static void ValidateStudent(Student st)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if(!regex.IsMatch(st.Name))
                throw new InvalidStudentNameException(st.Name);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException()
        {
        }
        public InvalidStudentNameException(string name)
            : base($"Invalid student name: {name}")
        {
            
        }
    }

}