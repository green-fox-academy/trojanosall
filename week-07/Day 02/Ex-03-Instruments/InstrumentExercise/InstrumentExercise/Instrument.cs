namespace InstrumentExercise
{
    abstract class Instrument
    {
        private readonly string Name;

        protected Instrument(string name)
        {
            Name = name;
        }

        public abstract void Play();


    }
}
