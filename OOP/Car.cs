namespace OOP
{
    public class Car : Machine
    {
        public int Engine { get; set; }
        public string Model { get; set; }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Car. Engine: {Engine}, Model: {Model}, PassCount: {PassCount}");
        }
        public override void Move() => Console.WriteLine("Car moved");

        public override int Speed { get; set; }
    }
}
