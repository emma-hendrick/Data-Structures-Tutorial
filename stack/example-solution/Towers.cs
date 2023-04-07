namespace tower_of_hanoi;

internal class Towers
{
        private Stack<int>[] _towers = {new Stack<int>(), new Stack<int>(), new Stack<int>()};
        private List<int> _startingValues = new List<int>(){5, 4, 3, 2, 1};

        public Towers()
        {
                _towers[0].PushList(_startingValues);
        }

        public bool MovePiece(int startingTower, int endingTower)
        {
                if (startingTower == endingTower) 
                {
                        Console.WriteLine("Towers cannot be the same!");
                        return false;
                }

                if (startingTower < 0 || startingTower > 2 || endingTower < 0 || endingTower > 2) 
                {
                        Console.WriteLine("Invalid tower selection!");
                        return false;
                }
                
                if (_towers[startingTower].IsEmpty())
                {
                        Console.WriteLine("Invalid starting tower!");
                        return false;
                }

                if (!(_towers[endingTower].IsEmpty()) &&_towers[startingTower].Peek() >= _towers[endingTower].Peek())
                {
                        Console.WriteLine("Invalid move!");
                        return false;
                }

                _towers[endingTower].Push(_towers[startingTower].Pop());

                return true;
        }

        public bool IsWin()
        {
                return _towers[0].IsEmpty() && _towers[1].IsEmpty();
        }

        public void Draw()
        {
                int height = _startingValues.Count();

                Console.WriteLine();
                Console.WriteLine("          |                    |                    |          ");
                for (int i = height - 1; i >= 0; i --)
                {
                        foreach (Stack<int> tower in _towers)
                        {
                                string towerString = "";

                                int width = (tower.Count() <= i) ? 0: tower.Nth(i) * 2 + 1;
                                towerString = towerString.PadLeft(width, '-');
                                towerString = towerString.PadLeft(((21 - width) / 2) + width, ' ');
                                towerString = towerString.PadRight(21, ' ');

                                Console.Write(towerString);
                        }
                        Console.WriteLine();
                        Console.WriteLine("          |                    |                    |          ");
                }
                Console.WriteLine();
        }
}