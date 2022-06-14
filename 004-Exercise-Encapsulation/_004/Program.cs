namespace _004;

public static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var pizzaInfo = Console.ReadLine().Split();
            var doughInfo = Console.ReadLine().Split();

            var pizzaName = pizzaInfo[1];
            var doughType = doughInfo[1];
            var bakingTechnique = doughInfo[2];
            var doughWeight = double.Parse(doughInfo[3]);

            var dough = new Dough(doughType, bakingTechnique, doughWeight);
            var pizza = new Pizza(pizzaName, dough);


            var toppingType = Console.ReadLine();

            while (toppingType != "END")
            {
                var toppingInfo = toppingType.Split();
                var type = toppingInfo[1];
                var weight = double.Parse(toppingInfo[2]);

                var topping = new Topping(type, weight);
                pizza.AddTopping(topping);

                toppingType = Console.ReadLine();
            }

            Console.WriteLine($"{pizza.Name} - {pizza.CalculateTotalCalories():F2} Calories.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}