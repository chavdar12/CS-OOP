using System.Reflection;
using System.Text;

namespace Ex004;

public class Spy
{
    public static string StealFieldInfo(string className)
    {
        var typeOfClass = Type.GetType(className);
        var methods = typeOfClass?.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        var sb = new StringBuilder();

        foreach (var method in (methods ?? throw new ArgumentNullException()).Where(x => x.Name.StartsWith("get")))
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");

        foreach (var method in methods.Where(x => x.Name.StartsWith("set")))
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters()[0].ParameterType}");

        return sb.ToString().TrimEnd();
    }
}