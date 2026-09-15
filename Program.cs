Person[] people = [
    new Person("Anna", 28),
    new Person("Bertil", 40),
    new Person("123", -10),
    new Person(null, 5)
];

//people[0].Present();
//people[1].Present();

/* 
This won't work if Name and Age are private

people[0].Name = "123";
people[0].Age = -10;

Console.WriteLine(people[0].Name);
Console.WriteLine(people[0].Age);
*/

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