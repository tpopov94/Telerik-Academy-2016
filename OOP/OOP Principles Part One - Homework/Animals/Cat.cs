namespace Animals
{
    using System;

    public class Cat : Animal, ISound
    {
        // Constructors

        public Cat(string name, int age, Gender gender, string breed)
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
            Console.WriteLine("{0} says: meww meww I am your meww master meww ", this.Name);
        }
    }
}
