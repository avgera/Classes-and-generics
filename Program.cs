using Generics.People;

Person<int> tom = new(1, "Tom");
Person<int> kate = new(2, "Kate");

Person<int>[] people = new[]
{
    tom,
    kate
};

Person<int> jake = new(people.Max(p => p.Id) + 1, "Jake");

jake.Print();

Console.WriteLine($"{jake.Name}'s id is {jake.Id}");

Person<string> jakeOld = new("AB 123456", "Old Jake");

Console.WriteLine($"{jakeOld.Name}'s id is {jakeOld.Id}");


SomeClass c = new();

c.Draw<Person<int>>();
c.Draw<Person<string>>();
c.Draw<string>();
c.Draw<int>();


Console.WriteLine("=================== ForTry ======================");
c.ForTry();
Console.WriteLine("=================== TryFor ======================");
c.TryFor();

/*
Whale vasya = new("Vasya", "no milk");
Whale katya = new("Katya", "with milk");
Dog barbos = new("Barbos", "no milk", "long wool");

List<Mammal> mammals = new()
{
    vasya,
    katya,
    barbos
};

foreach (Mammal mammal in mammals)
{
    mammal.Move();
    mammal.PrintMilk();

    Dog? dog = mammal as Dog;
    if (dog is not null)
    {
        Console.WriteLine($"{dog.Name} has {dog.Wool}");
    }
}
*/

/*
Person denis = new("Denis", 14, 165, 62);
Person sasha = new("Sasha", 38, 160, 80);
Person artur = new("Artur", 15, 175, 60);

Person[] people = new[]
{
    denis,
    sasha,
    artur
};


denis.Print();
artur.Print();
*/
