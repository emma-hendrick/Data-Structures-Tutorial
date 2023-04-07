namespace mailing_list;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Set<string> mailing_list = new Set<string>();

        while (true)
        {

            Console.WriteLine();
            Console.WriteLine("1: Add user to mailing list");
            Console.WriteLine("2: Check if user is in mailing list");
            Console.WriteLine("3: Remove user from mailing list");
            Console.WriteLine("4: Print mailing list");
            Console.WriteLine("5: Exit");
            Console.WriteLine("Enter Command: ");
            string? command = Console.ReadLine();

            if (command == "5")
            {
                break;
            }

            string? email = "";

            // We don't need the email if the user just wants to print the mailing list
            if (command != "4")
            {
                Console.WriteLine("Enter Email: ");
                email = Console.ReadLine();

                while (email == null)
                {
                    email = Console.ReadLine();
                }
            }

            // Execute the command
            switch (command) 
            {
                case "1":
                    mailing_list.Add(email);
                    break;
                case "2":
                    Console.WriteLine(mailing_list.Member(email) ? "User was found in mailing list": "User not found");
                    break;
                case "3":
                    mailing_list.Remove(email);
                    break;
                case "4":
                    mailing_list.ForEach(Console.WriteLine);
                    break;
                default:
                    Console.WriteLine("Unrecognized Command");
                    break;
            }

        }

    }
}