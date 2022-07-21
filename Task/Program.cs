using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat_1 = new Cat("Барсик", "Мяу", true);
            Dog dog_1 = new Dog("Жучка", "Гав", "Длинные");
            cat_1.ShowInfo();
            dog_1.ShowInfo();
            Console.ReadKey();
        }
    }
}
