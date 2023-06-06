using System.Reflection;

namespace OOP
{
    public class Plane: Machine
    {
        public int MaxHeight { get; set; } // _maxHeight

        public override void PrintInformation()
        {
            Console.WriteLine($"Plane. MaxHeight: {MaxHeight}, PassCount: {PassCount}");
        }
        public override void Move() => Console.WriteLine("Plane moved");

        public override int Speed 
        {
            get => speed;
            set => speed = value + 100;
        }
    }
}
