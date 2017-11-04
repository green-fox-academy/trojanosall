using System;

namespace InstrumentExercise
{
    abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        protected StringedInstrument(string name, int numberOfStrings) : base(name)
        {

        }

        public abstract string Sound();

        public override void Play()
        {
            Console.WriteLine($"{name}, a {numberOfStrings} - stringed instrument that", Sound()); ;
        }


    }
}
