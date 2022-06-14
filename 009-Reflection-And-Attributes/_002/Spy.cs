using System.Reflection;
using System.Text;

namespace _002;

public class Spy
{
    public static string AnalyzeAccessModifiers(string classForInvestigation)
    {
        var classType = Type.GetType(classForInvestigation);
        var classFields = classType?.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        var classPublicMethods = classType?.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        var classNonPublicMethods = classType?.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var sb = new StringBuilder();

        foreach (var field in classFields ?? throw new ArgumentNullException())
            sb.AppendLine($"{field.Name} must be private!");

        foreach (var method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            sb.AppendLine($"{method.Name} have to be public!");

        foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            sb.AppendLine($"{method.Name} have to be private!");

        return sb.ToString().TrimEnd();
    }
}