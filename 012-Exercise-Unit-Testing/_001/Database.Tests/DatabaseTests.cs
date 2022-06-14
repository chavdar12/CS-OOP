using NUnit.Framework;
using System;

namespace Database.Tests;

[TestFixture]
public class DatabaseTests
{
    private const int AllowedCapacity = 16;
    private Database dataBase;

    private void FillCollection(int iterations)
    {
        for (var i = 0; i < iterations; i++) dataBase.Add(i);
    }

    [SetUp]
    public void Setup()
    {
        dataBase = new Database(AllowedCapacity);
    }

    [Test]
    public void VerifyCollectionSize()
    {
        FillCollection(AllowedCapacity - 1);
        Assert.AreEqual(AllowedCapacity, dataBase.Count, "The method isn't working right!");
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
        Assert.AreEqual(expectResult, dataBase.Count, "The method isn't working right!");
    }

    [Test]
    public void CollectionThrowsExceptionWhenGoingOverTheCapacity()
    {
        var error = Assert.Throws<InvalidOperationException>(() => FillCollection(AllowedCapacity));
        Assert.AreEqual("Array's capacity must be exactly 16 integers!", error.Message);
    }

    [Test]
    public void CollectionThrowsExceptionWhenEmpty()
    {
        dataBase = new Database();
        var error = Assert.Throws<InvalidOperationException>(() => dataBase.Remove());
        Assert.AreEqual("The collection is empty!", error.Message);
    }

    [Test]
    public void VerifyFetchMethod()
    {
        var collection = dataBase.Fetch();
        Assert.AreEqual(dataBase.Count, collection.Length, "The collections aren't equal!");
    }
}