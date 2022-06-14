using System.Reflection;

namespace _002;

public static class Validator
{
    public static bool IsValid(object obj)
    {
        var properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic |
                                                     BindingFlags.Instance | BindingFlags.Static);

        return !(from property in properties
            let attributes = property.GetCustomAttributes()
                .Where(a => a.GetType().IsSubclassOf(typeof(MyValidationAttribute)))
                .Cast<MyValidationAttribute>()
                .ToArray()
            where attributes.Any(attribute => !attribute.IsValid(property.GetValue(obj)))
            select property).Any();
    }
}