using System.Reflection;

namespace _006;

public class Tracker
{
    public static void PrintMethodsByAuthor()
    {
        var classType = typeof(StartUp);
        var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

        foreach (var method in methods)
            if (method.CustomAttributes.Any(a => a.AttributeType == typeof(AuthorAttribute)))
            {
                var attributes = method.GetCustomAttributes(false);
                foreach (AuthorAttribute attribute in attributes)
                    Console.WriteLine($"{method.Name} is written by {attribute.Name}");
            }
    }
}