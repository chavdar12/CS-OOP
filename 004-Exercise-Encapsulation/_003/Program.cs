namespace _003;

public static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var InputPeople = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            var InputProducts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);


            var people =
                (from currentPerson in InputPeople
                    select currentPerson.Split('=')
                    into values
                    let name = values[0]
                    let money = decimal.Parse(values[1])
                    select new Person(name, money)).ToDictionary(person => person.Name);

            var products =
                (from currentProduct in InputProducts
                    select currentProduct.Split('=')
                    into values
                    let name = values[0]
                    let cost = decimal.Parse(values[1])
                    select new Product(name, cost)).ToDictionary(product => product.Name);

            var command = Console.ReadLine();

            while (command != "END")
            {
                var purchase = command.Split();
                var person = people[purchase[0]];
                var product = products[purchase[1]];

                if (person.Money - product.Cost < 0)
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    command = Console.ReadLine();
                    continue;
                }

                person.AddProduct(product);
                Console.WriteLine($"{person.Name} bought {product.Name}");

                command = Console.ReadLine();
            }

            foreach (var person in people)
            {
                var productMessage = person.Value.Products.Count == 0
                    ? "Nothing bought"
                    : string.Join(", ", person.Value.Products.Select(x => x.Name));
                Console.WriteLine($"{person.Key} - {productMessage}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}