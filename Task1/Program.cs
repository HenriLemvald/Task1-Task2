using System;

namespace Task1
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;
            }
            public string Name
            {
                get { return name; }
                set
                {
                    Name = value;
                }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hunger
            {
                get { return hunger; }
            }
            public void Sleep()
            {
                Console.WriteLine("The cat sleeps");
                hunger += 0.2;
                Console.WriteLine($"cat is hungry:{hunger}");
            }
        }
        static void Main(string[] args)
        {
            Cat newcat = new Cat("cat", "brown");
            while (newcat.Hunger != 1)
            {
                newcat.Sleep();
            }

            Console.WriteLine("meow");
        }
    }
}

