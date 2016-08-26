namespace PersonCreator
{
    public class PersonFactory
    {
        public void CreatePerson(int age)
        {
            Person person = new Person();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Pesho";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Dochka";
                person.Gender = Gender.Female;
            }
        }
    }
}