using BenchmarkDotNet.Attributes;
//BenchmarkRunner.Run<SomeClass>();

[MemoryDiagnoser]
public class SomeClass
{
    private const int _iterations = 1000000;
    private const int _breakValue = 600;

    public void Draw<TClass>()
    {
        Console.WriteLine(typeof(TClass));
    }

    [Benchmark]
    public void ForTry()
    {
        for (int i = 0; i < _iterations; i++)
        {
            try
            {
                DoJob(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                break;
            }
        }
        Console.WriteLine();
    }

    [Benchmark]
    public void TryFor()
    {
        try
        {
            for (int i = 0; i < _iterations; i++)
            {
                DoJob(i);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine();
    }

    private static void DoJob(int i)
    {
        Console.Write($"{i} ");

        if (i == _breakValue)
        {
            int j = i / 0;
        }
    }
}
