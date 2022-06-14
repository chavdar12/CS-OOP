namespace _005;

public class Robot : IIdentifiable
{
    public Robot(string model, string id)
    {
        Model = model;
        Id = id;
    }

    private string Model { get; set; }
    public string Id { get; private set; }
}