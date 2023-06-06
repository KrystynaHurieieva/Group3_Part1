namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car() { PassCount = 5, Engine = 255, Model = "VW Passat" , Speed = 44};

            var plane = new Plane() { PassCount = 300, MaxHeight = 9000, Speed = 44 };

            var train = new Train() { PassCount = 1000, Length = 10, Speed = 44 };

            //car.PrintInformation();
            //plane.PrintInformation();
            //train.PrintInformation();

            var list = new List<Machine>() { car, plane, train };
            foreach(var el in list)
            {
                el.PrintInformation();
                el.Move();
                Console.WriteLine($"Speed: {el.Speed}");
            }


        }
    }
}