namespace _005;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class AuthorAttribute : Attribute
{
    public AuthorAttribute(string name)
    {
        Name = name;
    }

    private string Name { get; set; }
}