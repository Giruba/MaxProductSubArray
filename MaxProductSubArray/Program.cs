using System;

namespace MaxProductSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum product subarray!");
            Console.WriteLine("-------------------------");

            Console.WriteLine();
            PrintMaximumProductInSubArray();
            
            Console.ReadLine();
        }

        private static void PrintMaximumProductInSubArray() {

            Console.WriteLine("Enter the number or elements in the array");
            try
            {
                int numberElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements in the array" +
                    " separated by space, comma or semi-colon");
                String[] elements = Console.ReadLine().Split(' ', ',', ';');
                int[] array = new int[numberElements];
                for (int index = 0; index < numberElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
                _PrintMaximumProduct(array);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is " +
                    ""+exception.Message);
            }
        }

        private static void _PrintMaximumProduct(int[] array) {

            int minVal = array[0];
            int maxVal = array[0];
            int maxProduct = array[0];

            for (int index = 1; index < array.Length; index++) {
                if (array[index] < 0) {
                    int temp = minVal;
                    minVal = maxVal;
                    maxVal = temp;
                }

                minVal = Math.Min(minVal, array[index]*minVal);
                maxVal = Math.Max(maxVal, array[index]*maxVal);


                maxProduct = Math.Max(maxProduct, maxVal);
            }

            Console.WriteLine("The maximum product sub-array " +
                " in the array is"+maxProduct);
        }
    }
}
