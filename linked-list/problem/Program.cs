namespace telephone;

internal class Program
{
    private static void Main(string[] args)
    {
        LinkedList<string> game = new LinkedList<string>();
        Random _rnd = new Random();
        string validCharacters = "abcdefghiklmnoprstuvwy ";

        string currentGuess = "";
        double replaceChance = 0.20;

        Console.WriteLine("Welcome to the wonderful game of telephone!");
        Console.WriteLine("I hope you enjoy your suffering!");
        Console.WriteLine("Anyways...");
        Console.WriteLine();
        Console.WriteLine("How many people will be playing?");
        string? userInput = Console.ReadLine();
        int playersLeft;
        int.TryParse(userInput, out playersLeft);

        while (playersLeft != 0)
        {
            Console.Clear();
            
            // MUTILATE THE GUESS!!!!!!
            string mutilatedGuess = "";
            foreach (char character in currentGuess)
            {
                if (_rnd.NextDouble() <= replaceChance)
                {
                    char randomChar = validCharacters[_rnd.Next(validCharacters.Length)];
                    mutilatedGuess += randomChar;
                }
                else
                {
                    mutilatedGuess += character;
                }
            }

            if (currentGuess != "") Console.WriteLine($"You hear the person before you whisper: {mutilatedGuess}\nWhat do you think they said?");
            else Console.WriteLine("What should the word be?");

            userInput = Console.ReadLine();
            currentGuess = userInput is not null? userInput: "";

            game.InsertTail(currentGuess);

            playersLeft --;
        }
        
        Console.Clear();
        game.Print();
    }
}