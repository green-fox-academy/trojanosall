using System;

namespace InstrumentExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1, create Electric Guitar, Bass Guitar and Violin with default strings.\n\n");
            var myGuitar = new ElectricGuitar();
            var myBassGuitar = new BassGuitar();
            var myViolin = new Violin();

            Console.WriteLine("Test 1 Play");

            myGuitar.Play();
            myBassGuitar.Play();
            myViolin.Play();

            Console.WriteLine("\n\nTest 2, create Electric Guitar, Bass Guitar with 7 and 5 strings .");

            ElectricGuitar myGuitar2 = new ElectricGuitar(7);
            BassGuitar myBassGuitar2 = new BassGuitar(5);

            Console.WriteLine("\n\nTest 2 Play");
            myGuitar2.Play();
            myBassGuitar2.Play();

            Console.ReadKey();


        }
    }
}
