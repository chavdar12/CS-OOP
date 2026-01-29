using Ex002;

var person = new Person(null, -1);

var isValidEntity = Validator.IsValid(person);

Console.WriteLine(isValidEntity);