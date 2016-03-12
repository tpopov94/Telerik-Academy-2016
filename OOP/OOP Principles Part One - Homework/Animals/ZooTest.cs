/*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
 * All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. 
 * Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
 * Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).*/

namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class ZooTest
    {
        static void Main()
        {
            // Uncomment if you want to use the ISound method 

            //var dog = new Dog("Pesho", 5, Gender.Something, "Street Finest");
            //Console.WriteLine(dog.ToString());
            //dog.MakeSound();

            //var kitty = new Kitten("Oi kotio", 1, "Sivo");
            //Console.WriteLine(kitty.ToString());
            //kitty.MakeSound();

            //var frog = new Frog("Lupi", 2, Gender.Something, "Philautus chotta");
            //frog.MakeSound();

            var catList = new List<Cat>
            {
                new Cat("Kotaran", 3, Gender.Male, "Siamese"),
                new Tomcat("Tom the cat", 4, "Persian"),
                new Kitten("Oi kotio", 1, "Shorthair"),
                new Cat("Maca", 13, Gender.Something,"Street Finest"),
                new Tomcat("Dinko", 3, "Siberian"),
                new Cat("Lucifer", 13, Gender.Something,"Scotish fold")
            };

            Console.WriteLine("Cats average age: {0:F2}", Animal.AnimalAverageAge(catList)); // Using Animal class static method

            var dogList = new List<Dog>
            {
                new Dog("Pesho", 15, Gender.Something, "Street Finest"),
                new Dog("Balkanka", 5, Gender.Female, "Siberian Husky"),
                new Dog("Petrohan", 7, Gender.Male, "Retriever"),
                new Dog("Sheitana", 2, Gender.Female, "German Shepherd"),
                new Dog("Dobrinka",17,Gender.Female,"Poodle")
            };

            Console.WriteLine("Dogs average age: {0:F2}", Animal.AnimalAverageAge(dogList)); // Using Animal class static method

            var frogList = new List<Frog>
            {
                new Frog("Veneta Raikova",70,Gender.Female,"Philautus chotta"),
                new Frog("Nikoleta Lozanova", 100,Gender.Something,"Philautus amboli"),
                new Frog("Drisko",10,Gender.Male,"Philautus marki"),
                new Frog("Sashka Vaseva",17,Gender.Female,"Philautus sushili")
            };

            Console.WriteLine("Frogs average age: {0:F2}", Animal.AnimalAverageAge(frogList)); // Using Animal class static method
        }
    }
}
