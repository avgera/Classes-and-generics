namespace Generics.Animals;

public class Whale : Mammal
{
    public Whale(string name, string milk)
        : base(name, milk)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} swimm");
    }
}
