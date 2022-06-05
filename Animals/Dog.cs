namespace Generics.Animals;

public class Dog : Mammal
{
    public string Wool { get; }

    public Dog(string name, string milk, string wool)
        : base(name, milk)
    {
        Wool = wool;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} Run on four legs");
    }
}