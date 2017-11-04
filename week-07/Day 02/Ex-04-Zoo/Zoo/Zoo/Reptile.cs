namespace Zoo
{
    class Reptile : Animal
    {
        public Reptile(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override string Greet()
        {
            return $"Hello i am an reptile and my name is {name}";
        }

        public override string WantChild()
        {
            return "I wanna child... from egg";
        }
    }
}
