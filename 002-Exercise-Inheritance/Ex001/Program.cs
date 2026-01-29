using Ex001;

var name = Console.ReadLine();
var age = int.Parse(Console.ReadLine());

if (age < 0) return;

var person = age <= 15 ? new Child(name, age) : new Person(name, age);

Console.WriteLine(person);