using Ex003;

namespace ExerciseEncapsulationTests;

public class Ex003Tests
{
    [Test]
    public void AddProductSpendsMoney()
    {
        var person = new Person("Peter", 11);

        person.AddProduct(new Product("Bread", 10));

        Assert.That(person.Money, Is.EqualTo(1));
        Assert.That(person.Products.Select(p => p.Name), Is.EqualTo(new[] { "Bread" }));
    }

    [Test]
    public void NegativeMoneyThrows()
    {
        Assert.That(Assert.Throws<ArgumentException>(() => new Person("Peter", -1)).Message,
            Is.EqualTo("Money cannot be negative"));
    }

    [Test]
    public void ProgramRunsShoppingSpree()
    {
        var output = ConsoleRunner.Run(typeof(Person).Assembly,
            "Peter=11;George=4\nBread=10;Milk=2\nPeter Bread\nGeorge Milk\nGeorge Milk\nPeter Milk\nEND\n");

        Assert.That(output, Is.EqualTo(
            "Peter bought Bread\nGeorge bought Milk\nGeorge bought Milk\nPeter can't afford Milk\n" +
            "Peter - Bread\nGeorge - Milk, Milk"));
    }

    [Test]
    public void ProgramPrintsNothingBought()
    {
        Assert.That(ConsoleRunner.Run(typeof(Person).Assembly, "Mimi=0\nKafence=2\nEND\n"),
            Is.EqualTo("Mimi - Nothing bought"));
    }
}
