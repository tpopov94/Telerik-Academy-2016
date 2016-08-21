namespace Animals
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Gender gender, string breed)
            :base(name, age, gender)
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
            Console.WriteLine("{0} is barking loudly !!", this.Name); 
        }
    }
}
