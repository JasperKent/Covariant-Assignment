using System;
using System.Collections.Generic;

namespace CovariantAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //BreakingLSP();
            //WithStandardGenerics();
            //WithHomemadeGeneric();
            WithArrays();
        }

        private static void BreakingLSP()
        {
            BagOfApples bagOfApples = new BagOfApples();

            bagOfApples.Add(new Apple { Name = "Braeburn" });
            bagOfApples.Add(new Banana { Name = "Blue Java" });

            Console.WriteLine(bagOfApples.Get(0).Name);
            Console.WriteLine(bagOfApples.Get(1).Name);
        }

        private static void WithStandardGenerics()
        {
            List<Apple> bagOfApples = new List<Apple>()
            {
                new Apple {Name = "Granny Smith" },
                new Apple {Name = "Cox's Orange Pippin" },
                new Apple {Name = "Golden Delicious" }
            };

            IEnumerable<Fruit> bagOfFruit;

            bagOfFruit = bagOfApples;

            foreach (Fruit fruit in bagOfFruit)
                Console.WriteLine(fruit.Name);

            bagOfApples.Add(new Apple { Name = "Braeburn" });

            Console.WriteLine("---");

            foreach (Fruit fruit in bagOfFruit)
                Console.WriteLine(fruit.Name);

            //bagOfApples.Add(new Banana { Name = "Blue Java" });
            //bagOfFruit.Add(new Banana { Name = "Blue Java" });

            Console.WriteLine("---");

            foreach (Fruit fruit in bagOfFruit)
                Console.WriteLine(fruit.Name);
        }

        private static void WithHomemadeGeneric()
        {
            Bag<Apple> bagOfApples = new Bag<Apple>();

            bagOfApples.Add(new Apple { Name = "Granny Smith" });
            bagOfApples.Add(new Apple { Name = "Cox's Orange Pippin" });
            bagOfApples.Add(new Apple { Name = "Golden Delicious" });

            IBag<Fruit> bagOfFruit = bagOfApples;

            Console.WriteLine(bagOfFruit.Get(0).Name);
            Console.WriteLine(bagOfFruit.Get(1).Name);

            //bagOfApples.Add(new Banana { Name = "Blue Java" });
            //bagOfFruit.Add(new Banana { Name = "Blue Java" });
        }

        private static void WithArrays()
        {
            var arrayOfApples = new Apple[]
                  {
                new Apple {Name = "Granny Smith" },
                new Apple {Name = "Cox's Orange Pippin" },
                new Apple {Name = "Golden Delicious" }
                  };

            Fruit[] arrayOfFruit = arrayOfApples;

            foreach (Fruit fruit in arrayOfFruit)
                Console.WriteLine(fruit.Name);

            arrayOfFruit[1] = new Banana { Name = "Blue Java" };

            foreach (Apple apple in arrayOfApples)
                Console.WriteLine(apple.Name);
        }
    }
}
