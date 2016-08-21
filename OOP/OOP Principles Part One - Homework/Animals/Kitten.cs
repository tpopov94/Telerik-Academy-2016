namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string breed)
            : base(name, age, Gender.Female, breed)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " - Breed: " + this.Breed;
        }
    }
}
