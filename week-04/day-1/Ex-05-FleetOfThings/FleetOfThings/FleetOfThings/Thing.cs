using System;


namespace FleetOfThings
{
    public class Thing
    {
        private string Name;                // Field definialas.
        private bool Completed;             // Field definialas.

        public Thing(string name)           // Constructor a Name field-re
        {
            this.Name = name;
        }

        public void Complete()              // Constructor a Complete field-re
        {
            this.Completed = true;
        }

        public string GetName()             // Method
        {
            return this.Name;
        }
        public bool IsCompleted()           // Method
        {
            return this.Completed;
        }
    }
}