using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSamples.Duck
{
    public class Duck
    {
        public Boolean IsQuacking { get; private set; }

        public virtual void Quack() 
        {
            Console.WriteLine("Quack, Quack!!!");
            IsQuacking = true;
        }

        public virtual void StopThatQuackAlready() => IsQuacking = false;
    }
}
