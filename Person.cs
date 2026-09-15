class Person
{
    // private fields - note small start letters "name", "age"
    private string name = "Jane Doe";
    private int age;

    // If we want to use properties (getters/setters)
    // when the object is constructed/instantiated
    // we need a traditional constructor
    // (rather than a primary constructor)
    public Person(string? name, int age)
    {
        // This will run the setter for Name
        Name = name!;
        // This will run the setter for Age
        Age = age;
    }

    // property for "Name" (public controlled "door")
    public string Name
    {
        get { return name; }
        set
        {
            if (value == null)
            {
                Console.WriteLine("Name can not be null");
                return;
            }
            if (value.Length < 1)
            {
                Console.WriteLine("Name cannot be an empty string");
                return;
            }
            if (value.Length > 50)
            {
                Console.WriteLine("A name can be max 50 characters");
                return;
            }
            // All -> Using the All LINQ method to check that all characters
            // in the string are letters, spaces or hyphens
            if (!value.All(c => char.IsLetter(c) || c == ' ' || c == '-'))
            {
                Console.WriteLine("A name should only contain letters and spaces and hyphens");
                return;
            }
            // Any -> Using then Any LINQ method to check that at least one (any)
            // characters is a letter
            if (!value.Any(c => char.IsLetter(c)))
            {
                Console.WriteLine("A name should have at least one letter!");
            }
            // Trim - a string method that removes spaces at the start and end
            // of strings
            name = value.Trim();
        }
    }

    // property for "Age" (public controlled "door")
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 130)
            {
                Console.WriteLine("Invalid age (Must be 0-130.)");
                return;
            }
            age = value;
        }
    }

    public void Present()
    {
        Console.WriteLine($"Hej, jag heter {name} och är {Age} år.");
    }
}
