namespace _004;

public class Citizen : IIdentifiable
{
    public Citizen(string name, int age, string id)
    {
        Name = name;
        Age = age;
        Id = id;
    }

    private string Name { get; set; }
    private int Age { get; set; }
    public string Id { get; set; }
}