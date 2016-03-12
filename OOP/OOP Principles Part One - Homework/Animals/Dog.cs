namespace Animals
{
    using System;

    public class Dog : Animal, ISound
    {
        // Constructors

        public Dog(string name, int age, Gender gender, string breed)
            :base(name, age, gender)
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
            Console.WriteLine("{0} is barking loudly !!", this.Name); 
        }
    }
}
