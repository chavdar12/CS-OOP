namespace _003;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var dog = new Dog();
        Animal.Eat();
        Dog.Bark();

        var cat = new Cat();
        Animal.Eat();
        Cat.Meow();
    }
}