namespace Question_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * UK	100
                USA	300

                France	200

                Chile	500

                China	1000

                Egypt	600

            */
            Dictionary<string, int> countryFees = new Dictionary<string, int>()
            {
                { "UK", 100 },
                { "USA", 300 },
                { "France", 200 },
                { "Chile", 500 },
                { "China", 1000 },
                { "Egypt", 600 },
            };

            // Get they key of "UK"
            int feeOfUK = countryFees["UK"];
            Console.WriteLine("The fee for UK is {0}", feeOfUK);

            Console.WriteLine("Enter the country name:");
            string userInput = Console.ReadLine();
            // Access the element using the user's defined key
            if (countryFees.ContainsKey(userInput))
            {
                Console.WriteLine("The fee for {0} is {1}", 
                    userInput, countryFees[userInput]);
            } else
            {
                Console.WriteLine("Country not found: {0}", userInput);
            }
        }
    }
}