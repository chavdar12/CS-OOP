using _004.Animals;
using _004.Animals.Birds;
using _004.Animals.Mammals;
using _004.Food;

namespace _004;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var command = Console.ReadLine();
        var farm = new List<Animal>();
        Food.Food food = null;

        while (command != "End")
        {
            var animalInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var foodInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var animalType = animalInfo[0];
            var name = animalInfo[1];
            var weight = double.Parse(animalInfo[2]);

            switch (animalType)
            {
                case nameof(Cat):
                case nameof(Tiger):
                {
                    var habitat = animalInfo[3];
                    var breed = animalInfo[4];
                    if (animalType == nameof(Cat))
                        farm.Add(new Cat(name, weight, habitat, breed));
                    else
                        farm.Add(new Tiger(name, weight, habitat, breed));
                    break;
                }
                case nameof(Owl) or nameof(Hen):
                {
                    var wingSize = double.Parse(animalInfo[3]);
                    if (animalType == nameof(Owl))
                        farm.Add(new Owl(name, weight, wingSize));
                    else
                        farm.Add(new Hen(name, weight, wingSize));
                    break;
                }
                case nameof(Dog):
                case nameof(Mouse):
                {
                    var habitat = animalInfo[3];
                    if (animalType == nameof(Dog))
                        farm.Add(new Dog(name, weight, habitat));
                    else
                        farm.Add(new Mouse(name, weight, habitat));
                    break;
                }
            }

            var foodType = foodInfo[0];
            var quantity = int.Parse(foodInfo[1]);

            food = foodType switch
            {
                "Fruit" => new Fruit(quantity),
                "Meat" => new Meat(quantity),
                "Seeds" => new Seeds(quantity),
                "Vegetable" => new Vegetable(quantity),
                _ => food
            };

            try
            {
                var currentAnimal = farm.Find(x => x.Name == name);
                Console.WriteLine(currentAnimal.ProduceSound());
                currentAnimal.Eat(food);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            command = Console.ReadLine();
        }

        farm.ForEach(Console.WriteLine);
    }
}