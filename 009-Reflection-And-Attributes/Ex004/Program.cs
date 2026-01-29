using Ex004;

try
{
    var className = typeof(Hacker).FullName;
    var result = Spy.StealFieldInfo(className);
    Console.WriteLine(result);
}
catch (ArgumentNullException)
{
    Console.WriteLine("Value cannot be null!");
}