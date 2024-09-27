using Module1.Task2.ClassLibrary;

if (args.Length > 0)
{
    Console.WriteLine(Greeter.GetGreeting(args[0]));
}
else
{
    Console.WriteLine("Username argument is missing.");
}