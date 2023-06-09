using System.Reflection;

namespace OOP
{
    public class Train : Machine
    {
        public int Length { get; set; }
        public override void PrintInformation()
        {
            Console.WriteLine($"Train. Length: {Length},  PassCount: {PassCount}");
        }
        public override void Move() => Console.WriteLine("Train moved");

        public override int Speed//_speed
        {
            get => speed;
            set => speed = value ;
        }
    }
}
