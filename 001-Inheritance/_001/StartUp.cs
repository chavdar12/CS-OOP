namespace _001;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var dog = new Dog();
        Dog.Bark();
        Dog.Bark();
        Animal.Eat();
    }
}