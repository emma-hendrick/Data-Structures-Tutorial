namespace tower_of_hanoi;

internal class Game
{
    private Stack<int[]> _moves = new Stack<int[]>();
    private Towers _towers = new Towers();

    public void Play()
    {
        Console.WriteLine("Welcome to Tower of Hanoi!");
        Console.WriteLine("When you reach the movement selection phase, you may instead enter z in order to undo a move.");
        Console.WriteLine("You may also enter q at this phase to quit.");

        while (true) 
        {
            _towers.Draw();

            if (_towers.IsWin())
            {
                Console.WriteLine("Congratulations, you win!");
                Console.WriteLine("Play again (y/n)? ");
                string? playAgain = Console.ReadLine();
                    
                if (playAgain == "y")
                {
                    _towers = new Towers();
                    Play();
                    break;
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine("Move a piece from tower: ");
            string? response = Console.ReadLine();

            if (response == "z")
            {
                UndoMove();
                continue;
            }
            else if (response == "q")
            {
                UndoMove();
                break;
            }

            bool successStarting = int.TryParse(response, out int startingTower);

            Console.WriteLine("To tower: ");
            response = Console.ReadLine();

            if (response == "z")
            {
                UndoMove();
                continue;
            }
            else if (response == "q")
            {
                UndoMove();
                break;
            }

            bool successEnding = int.TryParse(response, out int endingTower);
                
            if (!(successStarting && successEnding))
            {
                Console.WriteLine("Please enter valid integers for movement!");
            }
            else 
            {
                Console.WriteLine("Attempting Move: " + startingTower + " -> " + endingTower);
                bool success = DoMove(startingTower - 1, endingTower - 1);

                if (!success) 
                {
                    Console.WriteLine("Move failed, please try again.");
                }
            }
        }
    }

    public bool DoMove(int startingTower, int endingTower)
    {
        bool success = _towers.MovePiece(startingTower, endingTower);

        int[] move = {startingTower, endingTower};
        if (success) _moves.Push(move);

        return success;
    }

    public void UndoMove()
    {
        if (_moves.IsEmpty())
        {
            return;
        }

        int[] move = _moves.Pop();
        _towers.MovePiece(move[1], move[0]);

    }
}