using System;

namespace InstrumentExercise
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            name = "Violin";
            numberOfStrings = 4;
        }

        public override void Sound()
        {
            Console.WriteLine($"{name} is a {numberOfStrings}-stringed instrument that screeches.");
        }
    }
}
