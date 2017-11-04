using System;

namespace InstrumentExercise
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            name = "Electric Guitar";
            numberOfStrings = 6;
        }

        public ElectricGuitar(int electricGuitarNumberOfStrings)
        {
            name = "Electric Guitar";
            numberOfStrings = electricGuitarNumberOfStrings;
        }

        public override void Sound()
        {
            Console.WriteLine($"{name} is a {numberOfStrings}-stringed instrument that twangs.");
        }
    }
}
