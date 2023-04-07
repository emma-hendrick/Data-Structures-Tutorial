namespace graphing;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Expected Output: Andrew, The Rappler, Steven");
        
        Graph<string> network = new Graph<string>();

        network.Insert("Bob");
        network.Insert("Andrew");
        network.Insert("The Rappler");
        network.Insert("Steven");

        network.Connect("Bob", "Andrew");
        network.Remove("Bob");

        network.Print();
    }
}