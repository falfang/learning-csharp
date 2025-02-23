using SingletonSample;

Console.WriteLine("Start");

Singleton obj1 = Singleton.GetSingleton();
Singleton obj2 = Singleton.GetSingleton();

if (obj1 == obj2)
{
    Console.WriteLine("obj1 is the same as obj2");
}
else
{
    Console.WriteLine("obj1 is not same as obj2");
}

Console.WriteLine("End");