using ClassLibrary1;

public class Program
{
    static void Main()
    {
        var christopher = new Person("Christopher", 30);
        var nathen = new Person("Nathen", 40);
        var freddy = new Person("Freddy", 25);
        var erin = new Person("Erin", 35);
        var amelia = new Person("Amelia", 27);

        var dog1 = new Dog("Buddy", 2, "Brown");
        var dog2 = new Dog("Max", 4, "Black");
        var dog3 = new Dog("Charlie", 3, "Brown");
        var dog4 = new Dog("Rocky", 5, "White");
        var dog5 = new Dog("Bailey", 1, "White");
        var dog6 = new Dog("Lucy", 6, "Brown");

        christopher.Dog.Add(dog1);
        christopher.Dog.Add(dog2);
        nathen.Dog.Add(dog3);
        freddy.Dog.Add(dog4);
        freddy.Dog.Add(dog5);
        erin.Dog.Add(dog6);

        Db.People.Add(christopher);
        Db.People.Add(nathen);
        Db.People.Add(freddy);
        Db.People.Add(erin);
        Db.People.Add(amelia);

        Db.Dogs.Add(dog1);
        Db.Dogs.Add(dog2);
        Db.Dogs.Add(dog3);
        Db.Dogs.Add(dog4);
        Db.Dogs.Add(dog5);
        Db.Dogs.Add(dog6);


        var personsStartingWithR = Db.People
            .Where(p => p.FirstName.StartsWith("R"))
            .OrderByDescending(p => p.Age)
            .Select(p => p.FirstName);

        Console.WriteLine("Persons starting with 'R', ordered by Age - DESCENDING ORDER:");
        Console.WriteLine(string.Join(", ", personsStartingWithR));

        var brownDogsOlderThan3 = Db.Dogs
            .Where(d => d.Color == "Brown" && d.Age > 3)
            .OrderBy(d => d.Age)
            .Select(d => d.Name);

        Console.WriteLine("Brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER:");
        Console.WriteLine(string.Join(", ", brownDogsOlderThan3));

        var whiteDogsFromPeople = Db.People
            .Where(p => new[] { "Christopher", "Freddy", "Erin", "Amelia" }.Contains(p.FirstName))
            .SelectMany(p => p.Dog)
            .Where(d => d.Color == "White")
            .OrderBy(d => d.Name)
            .Select(d => d.Name);

        Console.WriteLine("White dogs names from Christopher, Freddy, Erin, and Amelia, ordered by Name - ASCENDING ORDER:");
        Console.WriteLine(string.Join(", ", whiteDogsFromPeople));
    }
}