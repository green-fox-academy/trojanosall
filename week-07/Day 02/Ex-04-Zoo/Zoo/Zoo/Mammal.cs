namespace Zoo
{
    class Mammal : Animal
    {
        public Mammal(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override string Greet()
        {
            return $"Hello i am an mammal and my name is {name}";
        }

        public override string WantChild()
        {
            return "I wanna child...";
        }
    }
}
