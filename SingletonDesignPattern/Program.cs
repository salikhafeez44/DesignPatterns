

using SingletonDesignPattern;


var differentInstance1 = new ServiceProvider();
var differentInstance2 = new ServiceProvider();

for (int i = 0; i < 10; i++)
{
    if (!differentInstance1.Equals(differentInstance2))
    {
        Console.Write($"{differentInstance1.GetNextServiceProvider()}, " +
                      $"{differentInstance2.GetNextServiceProvider()}, ");
    }
}
Console.WriteLine("END");


var singleInstance1 = AddSingleton<ServiceProvider>.GetInstance;
var singleInstance2 = AddSingleton<ServiceProvider>.GetInstance;
for (int i = 0; i < 10; i++)
{
    if (singleInstance1.Equals(singleInstance2))
    {
        Console.Write($"{singleInstance1.GetNextServiceProvider()}, " +
                      $"{singleInstance2.GetNextServiceProvider()}, ");
    }
}
Console.WriteLine("END");
