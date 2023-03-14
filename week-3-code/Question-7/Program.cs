namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 7.	Write a program called ListLimit. 
             * This should accept a limit from the user. 
             * The program should then accept a set of integers, 
             * up to the limit. When the program has finished it 
             * should:
                1.	Show each of the integers
                2.	Display the total 
                3.	Display the and the average.
            */
            Console.WriteLine("Enter the limit of the list (must be positive)");
            string userInput = Console.ReadLine();
            int limit;
            // Repeatedly ask the user to re-enter input
            // if they enter invalid inputs
            while (!(int.TryParse(userInput, out limit) 
                && limit > 0))
            {
                Console.WriteLine("Limit must be positive:");
                userInput = Console.ReadLine();
            }

            List<int> listOfInts = new List<int>(limit);
            Console.WriteLine("Created a list of size {0}", limit);
            int total = 0;
            // Ask the user to enter {limit} number
            for (int i = 0; i < limit; i++)
            {
                Console.Write("Enter number {0}: ", i);
                userInput = Console.ReadLine();
                int number;
                // Ask until we get an integer
                while (!int.TryParse(userInput, out number))
                {
                    Console.WriteLine("Please enter a whole number:");
                    userInput = Console.ReadLine();
                }

                listOfInts.Add(number);
                total = total + number;
            }

            // Show the integers
            foreach (int number in listOfInts)
            {
                Console.Write("{0}, ", number);
            }

            // Display the total and the average
            Console.WriteLine("\nThe total is {0}", total);
            Console.WriteLine("The average is {0}", (double) total / limit);
        }
    }
}