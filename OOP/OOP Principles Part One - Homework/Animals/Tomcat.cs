namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string breed)
            :base(name,age,Gender.Male,breed)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " - Breed: " + this.Breed;
        }
    }
}
