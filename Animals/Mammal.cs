namespace Generics.Animals;

public abstract class Mammal
{
    public string Milk { get; }

    public string Name { get; }

    protected Mammal(string name, string milk)
    {
        Name = name;
        Milk = milk;
    }

    public abstract void Move();

    public void PrintMilk()
    {
        Console.WriteLine($"{Name}: {Milk}");
    }
}
