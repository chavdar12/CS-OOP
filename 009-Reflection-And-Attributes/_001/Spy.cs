using System.Reflection;
using System.Text;

namespace _001;

public class Spy
{
    public static string StealFieldInfo(string classForInvestigation, params string[] fieldsForInvestigation)
    {
        var typeClass = Type.GetType(classForInvestigation);
        var fields = typeClass?.GetFields(BindingFlags.Static | BindingFlags.Instance |
                                          BindingFlags.NonPublic | BindingFlags.Public);
        var classInstance = Activator.CreateInstance(typeClass ?? throw new ArgumentNullException(), new object[] { });

        var sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {classForInvestigation}");

        foreach (FieldInfo field in fields ?? Enumerable.Empty<object>())
            if (fieldsForInvestigation.Contains(field.Name))
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");

        return sb.ToString().TrimEnd();
    }
}