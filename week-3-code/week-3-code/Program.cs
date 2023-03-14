namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of 5 doubles
            double[] myArrayOfDoubles = new double[]
            {
                1.0, 2.0, 3.0, 4.0, 5.0
            };

            // Iterate through the indices and display
            // the element at each index
            for (int index = 0; 
                index < myArrayOfDoubles.Length;
                index++)
            {
                Console.WriteLine(myArrayOfDoubles[index]);
            }
        }
    }
}