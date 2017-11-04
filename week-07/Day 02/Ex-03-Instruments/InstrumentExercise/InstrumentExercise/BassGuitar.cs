using System;

namespace InstrumentExercise
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            name = "Bass Guitar";
            numberOfStrings = 4;
        }

        public BassGuitar(int bassGuitarNumberOfStrings)
        {
            name = "Bass Guitar";
            numberOfStrings = bassGuitarNumberOfStrings;
        }

        public override void Sound()
        {
            Console.WriteLine($"{name} is a {numberOfStrings}-stringed instrument that duum-duum-duum.");
        }
    }
}
