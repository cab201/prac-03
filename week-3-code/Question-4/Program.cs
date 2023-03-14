namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 4.	Write a program called ArrayDoubleSort. 
             * It should accept 10 doubles which are unsorted. 
             * It should run Array.Sort to sort the values 
             * and print out the sorted array. It should 
             * then output the sorted array using a ForEach 
             * loop. 
             * */
            double[] randomArray = new double[]
            {
                6.0, 2.3, 4.5, 7.2, 0.1, 
                9.9, 5.5, 4.7, 3.8, 2.2
            };

            // Display the unsorted array with a for loop
            Console.WriteLine("The unsorted array is:");
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.Write("{0}, ", randomArray[i]);
            }

            // Sort the array, and display it
            Array.Sort(randomArray);
            Console.WriteLine("\nThe sorted array is:");
            foreach (double number in randomArray)
            {
                Console.Write("{0}, ", number);
            }
        }
    }
}