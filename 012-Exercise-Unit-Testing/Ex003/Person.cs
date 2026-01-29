namespace Ex003;

public class Person
{
    public Person(long id, string userName)
    {
        Id = id;
        UserName = userName;
    }

    public string UserName { get; private set; }

    public long Id { get; private set; }
}