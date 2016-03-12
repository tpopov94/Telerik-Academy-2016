namespace Animals
{
    using System;

    public class Frog : Animal, ISound
    {
        // Constructors

        public Frog(string name, int age, Gender gender, string breed)
            : base(name, age, gender)
        {
            this.Breed = breed;
        }

        // Properties

        public string Breed { get; set; }

        // Methods

        public override string ToString()
        {
            return base.ToString() + " - Breed: " + this.Breed;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says:  Crrrroak ribbit ribbit !!", this.Name); ;
        }
    }
}
