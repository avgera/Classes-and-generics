namespace Generics.People;

public class Person
{
    public string Name { get; }

    public int Age { get; }

    public float Height { get; }

    public float Weight { get; }

    public Person(string name, int age, float height, float weight)
    {
        Name = name;
        Age = age;
        Height = height;
        Weight = weight;
    }

    public void Print()
    {
        Console.WriteLine($"{Name} is {Age} years old. Height is {Height}, weight is {Weight}");
    }
}

public class Person<TId> : Person
{
    public TId Id { get; }

    public Person(TId id, string name)
        : this(id, name, 0, 0, 0)
    {
    }

    public Person(TId id, string name, int age, float height, float weight)
        : base(name, age, height, weight)
    {
        Id = id;
    }
}
