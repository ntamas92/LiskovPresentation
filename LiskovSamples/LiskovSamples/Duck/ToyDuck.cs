using System;

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
