namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IMovable.minSpeed);
            //Console.WriteLine(IMovable.maxSpeed);
            var m = new Person();
            //m.Move1();
            m.Move();

            //IMovable t = new Test();
            //t.Move1();
            //t.Move();
            //Console.WriteLine(t.Name);


            //var col = new List<IMovable>() { m, t };

            //foreach(var i in col)
            //{
            //    Console.WriteLine(i.Name);
            //}
        }
    }
}