using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Кошка");
            cat.ShowInfo();
            var dog = new Dog("Собака");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
