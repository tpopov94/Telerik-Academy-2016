namespace Animals
{

    public class Tomcat : Cat
    {
        // Constructors

        public Tomcat(string name, int age, string breed)
            :base(name,age,Gender.Male,breed)
        {

        }

        // Methods

        public override string ToString()
        {
            return base.ToString() + " - Breed: " + this.Breed;
        }
    }
}
