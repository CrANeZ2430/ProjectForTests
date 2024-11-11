class Program
{
    public static void Main()
    {
        var events = new Events();
        var generics = new Generics();
        var character = new Character<int>(4);
        var polymorphism = new Polymorphysm();

        events.Method();

        generics.Print(7);
        generics.Print("Hello!");
        generics.warrior.PrintValue();

        character.PrintValue();

        polymorphism.PolMethod();

        Console.ReadLine();
    }
}