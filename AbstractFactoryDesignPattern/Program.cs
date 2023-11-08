// The client code can work with any concrete factory class.
using AbstractFactoryDesignPattern.Client;
using AbstractFactoryDesignPattern.Factory.ConcreteFactories;

Console.WriteLine("Client: Testing client code with the first factory type...");
Client.NewFactory(new FactoryDell());
Console.WriteLine();

Console.WriteLine("Client: Testing the same client code with the second factory type...");
Client.NewFactory(new FactoryHP());
Console.WriteLine();