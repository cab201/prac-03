namespace Question_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> countryFees =
                new Dictionary<string, int>()
                {
                    { "UK", 100 },
                    { "USA", 300 },
                    { "France", 200 },
                    { "Chile", 500 },
                    { "China", 1000 }
                };

            countryFees.Add("Egypt", 600);
            Console.WriteLine("The fee of UK is {0}",
                countryFees["UK"]);

            Console.WriteLine("Enter a country");
            foreach (string key in countryFees.Keys)
            {
                // key is the name of each country
                Console.Write("{0}, ", key);
            }
            string queryCountry = Console.ReadLine();

            if (countryFees.ContainsKey(queryCountry))
            {
                Console.WriteLine("The fee of {0} is {1}",
                    queryCountry, countryFees[queryCountry]);
            } else
            {
                Console.WriteLine("{0} is not defined", queryCountry);
            }

        }
    }
}