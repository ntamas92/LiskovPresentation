using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSamples.Duck
{
    public class ToyDuck : Duck
    {
        private Boolean _hasBatteries;
                
        public void InsertBatteries() => _hasBatteries = true;

        public override void Quack()
        {
            if (_hasBatteries)
                base.Quack();

            //No quacking for you :(
        }

        public override void StopThatQuackAlready()
        {
            //NEVER!!!!!!
        }
    }
}
