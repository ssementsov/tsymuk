using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022
{
    internal class Dog : Animal
    {
        string Animal.Name => nameof(Dog);
        public void MakeSound() => Console.WriteLine("Woof-Woof");
       
    }
}
