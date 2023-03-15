namespace Week_3_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Write a program called ArrayDouble
            //which stores an array of 5 doubles and
            //prints them out. The numbers in the array
            //should be hard coded.
            //You should use an array and a for loop.

            double[] arrayOfDoubles = new double[5]
            {
                1.0, 2.0, 3.0, 4.0, 5.0
            };

            for (int index = 0;
                index < arrayOfDoubles.Length;
                index++)
            {
                Console.Write(arrayOfDoubles[index] + ", ");
            }
        }
    }
}