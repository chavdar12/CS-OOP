namespace _002;

public static class StartUp
{
    public static void Main(string[] args)
    {
        var person = new Person(null, -1);

        var isValidEntity = Validator.IsValid(person);

        Console.WriteLine(isValidEntity);
    }
}