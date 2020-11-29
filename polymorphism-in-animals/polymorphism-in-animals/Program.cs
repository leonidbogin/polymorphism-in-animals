using System;

namespace polymorphism_in_animals
{
    class Program
    {
        private static void Main(string[] args)
        {
            var herd = new Animal[7];
            herd[0] = new Horse("Лошадь 1", 4, false);
            herd[1] = new Horse("Лошадь 2", 4, false);
            herd[2] = new Кangaroo("Кенгуру 1", 4, true);
            herd[3] = new Кangaroo("Кенгуру 2", 4, true);
            herd[4] = new Dragonfly("Стрекоза 1", 6, true);
            herd[5] = new Dragonfly("Стрекоза 2", 6, true);
            herd[6] = new Animal("Неизвестный вид", 10, true);

            var horse = new Horse("Лошадь 3", 4, false);
            var kangaroo = new Кangaroo("Кенгуру 3", 4, true);
            var dragonfly = new Dragonfly("Стрекоза 3", 6, true);

            foreach (var animal in herd)
            {
                Console.WriteLine(animal.Voice());
            }
            Console.WriteLine(horse.Voice());
            Console.WriteLine(kangaroo.Voice());
            Console.WriteLine(dragonfly.Voice());

            Console.WriteLine();

            foreach (var animal in herd)
            {
                Console.WriteLine(animal.Move());
            }
            Console.WriteLine(horse.Move());
            Console.WriteLine(kangaroo.Move());
            Console.WriteLine(dragonfly.Move());

            Console.WriteLine();

            foreach (var animal in herd)
            {
                Console.WriteLine(animal.IsHungry());
            }
            Console.WriteLine(horse.IsHungry());
            Console.WriteLine(kangaroo.IsHungry());
            Console.WriteLine(dragonfly.IsHungry());

            Console.ReadLine();
        }
    }
}
