class Person
{
    private string name;

    // a private field - note small start letter "age"
    private int;

    // The constructor assigns through the property, so the setter runs
    // (and validates) already when the object is created.
    public Person(string name, int age)
    {
        this.name = name;
        Age = age;
    }

    // the property - the public, controlled door "Age"
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 130)
            {
                Console.WriteLine("Ogiltig ålder, ignoreras.");
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
