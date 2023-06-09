namespace OOP
{
    public interface IMovable
    {
        // Methods
        // Properties
        // Index
        // Events
        // stiatic fields and consts 


        void Move();
        void Move1() => Console.WriteLine("Move1");
       
        const int minSpeed = 0;
        private const int maxSpeed = 220;
        
        string Name { get { return "IMovable"; }}

    }
    public interface IMovable2
    {
        public void Move();
        public void Move1() => Console.WriteLine("Move2");

        const int minSpeed = 0;
        private const int maxSpeed = 220;

        public string Name { get { return "IMovable2"; } }

    }

    public class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Person.Move");
        }
        public void Hello()
        {
            Console.WriteLine("Person.Hello");
        }
        //public string Name { get { return "Person"; } }
    }

    public class Test : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Test.Move");
        }
        public void Move1()
        {
            Console.WriteLine("Test.Move1");
        }
        public void Hello()
        {
            Console.WriteLine("Test.Hello");
        }
        //public string Name { get { return "Test"; } }
    }
}
