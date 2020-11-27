using System;

namespace Pet
{
    class Program
    {

        class Pet
        {
            string name;
            int age;
            double weight;
            int lifespan;

            public Pet(string _name, double _weight)
            {
                name = _name;
                age = 0;
                weight = _weight;
                lifespan = 0;
            }

            public string Name
            {
                get { return Name; }
            }

            public int Age
            {
                get { return Age; }
            }

            public double Weight
            {
                get { return weight; }
            }

            public int Lifespan
            {
                get { return lifespan; }
            }

            public void PetStats()
            {
                Console.WriteLine($"Name: {name} \n Age: {age}");
            }

            public void PetLifeSpan()
            {
                Console.WriteLine($"Lifespan: {lifespan}");
            }

            public void PetWeight()
            {
                Console.WriteLine($"Weight: {weight}");
            }

            public void Eat()
            {
                weight += 0.1;
                Console.WriteLine($"{name} eats.");
            }

            public void Exercise()
            {
                weight -= 0.1;
                Console.WriteLine($"{name} exercises.");
            }
        }

        static void Main(string[] args)
        {
            Pet Hamster = new Pet("Hamster", 0);

            for (int i = 0; i < 11; i++)
            {
                if (Hamster.Weight == 0.7)
                {
                    Hamster.Exercise();
                }
                else
                {
                    Hamster.Eat();
                }

            }

            Console.WriteLine("The hamster died:(");

        }
    }
}
