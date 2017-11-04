namespace InstrumentExercise
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            name = "Violin";
            numberOfStrings = 4;
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
