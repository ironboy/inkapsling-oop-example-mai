Person[] people = [
    new ("Anna", 28),
    new ("Bertil", 40),
    new ("Anna",20),
    //new ("123", -10),
    //new (null, 5)
];

Console.WriteLine(people[2].Name);

static void PersonTests(Person[] people)
{

    //people[0].Present();
    //people[1].Present();

    // This won't work if Name and Age are private
    //people[0].Name = "123";
    //people[0].Age = -10;

    Console.WriteLine(people[0].Name);
    Console.WriteLine(people[0].Age);

    foreach (Person person in people)
    {
        person.Present();
    }

    Console.WriteLine(people[0].Name);
    // this will warn and not set a new name
    // because the setter refuses names more than 50 characters long.
    people[0].Name = "alksjddjadlköajsdjklöasdjkasldköjasjdklöasjkldkljasdlkadjsajklsddaljskösdoiöjdasoijasdoijadsiojadsijoadsoijadsijoadsiojadsoijadsiojasdiojdasjio";
    Console.WriteLine(people[0].Name);
    // this will warn and not set a new name
    people[0].Name = "";
    Console.WriteLine(people[0].Name);
    // this will change the name
    people[0].Name = "Hej och hopp 123!";
    Console.WriteLine(people[0].Name);

}


static void CarTests()
{

    Car skruttan = new("Volvo", "V70", "smutsgrå");

    Console.WriteLine(skruttan.Make);
    Console.WriteLine(skruttan.Model);

    // Can't do this since Make and Model are read only
    // skruttan.Make = "Porsche";
    //skruttan.Model = "Carrera";

    // Can't do this since the Color setter is private
    // skruttan.Color = "glänsande guld";

    Console.WriteLine(skruttan.Color);


    // The WashMe me calls the setter for Color
    // that's ok since WashMe is a method inside the class
    skruttan.WashMe();

    Console.WriteLine(skruttan.Color);

}

// PersonTests(people);
// CarTests();