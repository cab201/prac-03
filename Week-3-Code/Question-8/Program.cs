namespace Question_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string EXIT_KEY = "Q";

            Console.WriteLine
                ("Please enter a number, or Q to stop:");
            string input = Console.ReadLine();
            List<double> listOfDoubles = new List<double>();

            // Keep asking, until the user terminates
            // by entering Q
            while(input != EXIT_KEY)
            {
                double number;
                // Keep asking, until we get a number
                while (!double.TryParse(input, out number))
                {
                    Console.WriteLine
                        ("Must be a number:");
                    input = Console.ReadLine();
                }
                listOfDoubles.Add(number);

                Console.WriteLine
                    ("Please enter a number, or Q to stop:");
                input = Console.ReadLine();
            }

            // Ask user to remove an element until the list is empty
            while (listOfDoubles.Count > 0)
            {
                double number;
                Console.Write
                    ("Please enter a number to remove from: ");
                // Print out the list of number
                foreach (double num in listOfDoubles)
                {
                    Console.Write("{0} ", num);
                }

                // Ask the user for the number to remove
                input = Console.ReadLine();
                while (!double.TryParse(input, out number))
                {
                    Console.WriteLine("Must be a number:");
                    input = Console.ReadLine();
                }

                // Try to remove the number from the list
                if (listOfDoubles.IndexOf(number) > -1)
                {
                    // Remove of the number is in the list
                    listOfDoubles.Remove(number);
                } else
                {
                    Console.WriteLine("The requested number {0} is not in list.",
                        number);
                }
            }
        }
    }
}