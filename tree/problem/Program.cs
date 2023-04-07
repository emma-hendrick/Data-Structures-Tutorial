namespace millions;
internal class Program
{
    private static void Main(string[] args)
    {

        BST<int> nums = new BST<int>();

        // Creates a lopsided BST
        nums.Insert(15);
        nums.Insert(41);
        nums.Insert(234);
        nums.Insert(422);
        nums.Insert(611);
        nums.Insert(835);
        nums.Insert(928);

        // Optimizes the BST
        nums = nums.Balance();

        // Print each number in the BST
        nums.Traverse((num) => Console.WriteLine(num));

        // Do some searching
        Console.Write("41 is in the BST: ");
        Console.WriteLine(nums.Search(41));
        Console.Write("99 is in the BST: ");
        Console.WriteLine(nums.Search(99));

    }
}