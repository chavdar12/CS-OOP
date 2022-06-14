using _001;

namespace _002;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var puppy = new Puppy();
        Animal.Eat();
        Dog.Bark();
        Puppy.Weep();
    }
}