namespace Zoo
{
    abstract class Animal
    {
        protected string name;
        protected int age;
        protected string gender;
        protected string habitat;
        protected int numberOfLegs;
        protected int averageOfWeight;

        public abstract string Greet();

        public abstract string WantChild();

        public abstract string GetName();
    }
}
