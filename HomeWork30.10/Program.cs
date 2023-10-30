class Program
{
    static void Main(string[] args)
    {
        Kettle kettle = new Kettle("Electric Kettle", "A device for boiling water.");
        Microwave microwave = new Microwave("Microwave Oven", "Used for heating food");
        Car car = new Car("Toyota Camry", "A popular sedan car.");
        Steamship steamship = new Steamship("Titanic", "Famous luxury passenger steamship.");

        kettle.Show();
        kettle.Sound();
        kettle.Desc();

        Console.WriteLine();

        microwave.Show();
        microwave.Sound();
        microwave.Desc();

        Console.WriteLine();

        car.Show();
        car.Sound();
        car.Desc();

        Console.WriteLine();

        steamship.Show();
        steamship.Sound();
        steamship.Desc();


    }
    class Device
    {
        private string name;
        private string description;

        public Device(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public virtual void Sound()
        {
            System.Console.WriteLine("Device makes a sound.");
        }
        public void Show()
        {
            System.Console.WriteLine($"Device name : {name}");
        }
        public void Desc()
        {
            System.Console.WriteLine($"Device description: {description}");
        }
    }
    class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            System.Console.WriteLine("Kettle makes boiling sound.");
        }
    }
    class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            System.Console.WriteLine("Microwave makes bussing sound.");
        }
    }
    class Car : Device
    {
        public Car(string name, string description) : base(name, description) { }
        public override void Sound()
        {
            System.Console.WriteLine("Car makes engine noise.");
        }
    }
    class Steamship : Device
    {
        public Steamship(string name,string description) : base(name, description) { }
        public override void Sound()
        {
            System.Console.WriteLine("Steamship makes steam engine noise.");
        }
    }
}