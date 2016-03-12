namespace Animals
{

    public class Kitten : Cat
    {
        //Constructors

        public Kitten(string name, int age, string breed)
            : base(name, age, Gender.Female, breed)
        {

        }

        // Methods

        public override string ToString()
        {
            return base.ToString() + " - Breed: " + this.Breed;
        }
    }
}
