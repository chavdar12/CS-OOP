using System.Reflection;
using System.Text;

namespace _003;

public class Spy
{
    public static string RevealPrivateMethods(string className)
    {
        var classType = Type.GetType(className);
        var sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {className}")
            .AppendLine($"Base Class: {classType?.BaseType?.Name}");

        classType?.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
            .ToList()
            .ForEach(m => sb.AppendLine($"{m.Name}"));

        return sb.ToString().TrimEnd();
    }
}