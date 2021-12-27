using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_14
{
    abstract class Animal
    {
        public abstract string AnimalName { get; set; }

        protected Animal(string animalName)
        {
            AnimalName = animalName;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(AnimalName);
            Say();
        }
    }
}
