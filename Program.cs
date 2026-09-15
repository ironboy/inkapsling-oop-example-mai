Person[] people = [
    new Person("Anna", 28),
    new Person("Bertil", 40),
    new Person("123", -10)
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

people[0].Present();
people[2].Present();