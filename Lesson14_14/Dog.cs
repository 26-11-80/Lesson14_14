using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_14
{
    class Dog : Animal
    {
        public override string AnimalName { get; set; }
        public Dog(string animalName) : base(animalName)
        {
            AnimalName = animalName;
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
