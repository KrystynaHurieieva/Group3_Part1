namespace Collections
{
    public abstract class Machine
    {
        protected int speed;
        public abstract int Speed { get; set; }
        public int PassCount { get; set; } = 666;

        public virtual void PrintInformation() 
        {
            Console.WriteLine("Machine");
        }
        public abstract void Move();
    }
}
