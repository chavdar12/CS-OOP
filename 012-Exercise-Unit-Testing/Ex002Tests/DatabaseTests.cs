using Ex002;

namespace Ex002Tests;

[TestFixture]
public class DatabaseTests
{
    [SetUp]
    public void Setup()
    {
        dataBase = new Database(AllowedCapacity);
    }

    private const int AllowedCapacity = 16;
    private Database dataBase;

    private void FillCollection(int iterations)
    {
        for (var i = 0; i < iterations; i++) dataBase.Add(i);
    }

    [Test]
    public void VerifyCollectionSize()
    {
        FillCollection(AllowedCapacity - 1);
        Assert.That(dataBase.Count, Is.EqualTo(AllowedCapacity), "The method isn't working right!");
    }

    [Test]
    public void VerifyAddMethod()
    {
        FillCollection(AllowedCapacity - 1);
        Assert.Throws<InvalidOperationException>(() => dataBase.Add(1));
    }

    [Test]
    public void VerifyRemoveMethod()
    {
        var expectResult = dataBase.Count - 1;
        dataBase.Remove();
        Assert.That(dataBase.Count, Is.EqualTo(expectResult), "The method isn't working right!");
    }

    [Test]
    public void CollectionThrowsExceptionWhenGoingOverTheCapacity()
    {
        var error = Assert.Throws<InvalidOperationException>(() => FillCollection(AllowedCapacity));
        Assert.That(error?.Message, Is.EqualTo("Array's capacity must be exactly 16 integers!"));
    }

    [Test]
    public void CollectionThrowsExceptionWhenEmpty()
    {
        dataBase = new Database();
        var error = Assert.Throws<InvalidOperationException>(() => dataBase.Remove());
        Assert.That(error?.Message, Is.EqualTo("The collection is empty!"));
    }

    [Test]
    public void VerifyFetchMethod()
    {
        var collection = dataBase.Fetch();
        Assert.That(collection, Has.Length.EqualTo(dataBase.Count), "The collections aren't equal!");
    }
}