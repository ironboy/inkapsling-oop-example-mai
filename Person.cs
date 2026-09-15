class Person
{
    // private fields - note small start letters "name", "age"
    private string name = "Jane Doe";
    private int age;

    // The constructor assigns through the property, so the setter runs
    // (and validates) already when the object is created.
    public Person(string? name, int age)
    {
        Name = name!;
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
            // TODO: we could check other things too like 
            // the characters needs to be letters rather than
            // symobols or digits
            name = value;

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
