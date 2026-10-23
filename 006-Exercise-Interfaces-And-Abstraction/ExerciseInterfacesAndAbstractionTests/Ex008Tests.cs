using Ex008;

namespace ExerciseInterfacesAndAbstractionTests;

public class Ex008Tests
{
    [Test]
    public void AddRemoveCollectionRemovesLastSlotEvenWithDuplicates()
    {
        var collection = new AddRemoveCollection();
        foreach (var item in new[] { "a", "b", "a" }) collection.Add(item);

        Assert.That(collection.Remove(), Is.EqualTo("a"));
        Assert.That(collection.Remove(), Is.EqualTo("b"));
    }

    [Test]
    public void MyListRemovesFirstAndTracksUsed()
    {
        var list = new MyList();
        list.Add("a");
        list.Add("b");

        Assert.That(list.Remove(), Is.EqualTo("b"));
        Assert.That(list.Used, Is.EqualTo(1));
    }

    [Test]
    public void ProgramPrintsIndexesAndRemovals()
    {
        Assert.That(ConsoleRunner.Run(typeof(MyList).Assembly, "a b a\n2\n"),
            Is.EqualTo("0 1 2 \n0 0 0 \n0 0 0 \na b \na b"));
    }
}
