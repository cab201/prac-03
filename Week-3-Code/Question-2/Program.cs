namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit;

            // Asks the user to enter the limit, until we get
            // a positive, whole number
            Console.WriteLine("Enter the limit: ");
            string input = Console.ReadLine();
            while (!(int.TryParse(input, out limit) 
                && limit > 0))
            {
                Console.WriteLine
                    ("The limit must be a positive whole number");
                input = Console.ReadLine();
            }

            int[] arrayOfInts = new int[limit];

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine
                    ($"Enter number at position {i}: ");
                input = Console.ReadLine();

                // Ask for input, until we get a whole number (int)
                int number;
                while(!int.TryParse(input, out number))
                {
                    Console.WriteLine("Please enter a whole number");
                    input = Console.ReadLine();
                }

                // Set element in array to the number entered by user
                arrayOfInts[i] = number;
            }

            // Display the elements:
            foreach (int num in arrayOfInts)
            {
                Console.Write("{0}, ", num);
            }

            // Calculate and display the total
            int cumulativeSum = 0;
            foreach (int num in arrayOfInts)
            {
                // Equivalent to cumulativeSum = cumulativeSum + num;
                cumulativeSum += num;
            }
            Console.WriteLine("The total is {0}", 
                cumulativeSum);

            // Calculate and display the average
            Console.WriteLine("The average is {0}", 
                (double) cumulativeSum / limit);
        }
    }
}