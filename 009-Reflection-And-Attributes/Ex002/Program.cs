using Ex002;

try
{
    var className = typeof(Hacker).FullName;
    var result = Spy.AnalyzeAccessModifiers(className);
    Console.WriteLine(result);
}
catch (ArgumentNullException)
{
    Console.WriteLine("Value cannot be null!");
}