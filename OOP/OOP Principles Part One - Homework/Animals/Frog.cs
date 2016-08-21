namespace Animals
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Gender gender, string breed)
            : base(name, age, gender)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }
        
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
