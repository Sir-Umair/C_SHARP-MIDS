// using System;

// namespace ArrayExample
// {
//     class Program
//     {
//         static void Main()
//         {
//             int ROWS, COLS;

//             Console.Write("Enter number of rows: ");
//             ROWS = Convert.ToInt32(Console.ReadLine());

//             Console.Write("Enter number of columns: ");
//             COLS = Convert.ToInt32(Console.ReadLine());

//             int[,] a = new int[ROWS, COLS];

//             for (int i = 0; i < ROWS; i++)
//             {
//                 for (int j = 0; j < COLS; j++)
//                 {
//                     Console.Write($"Enter element at [{i}, {j}]: ");
//                     a[i, j] = Convert.ToInt32(Console.ReadLine());
//                 }
//             }

//             Console.WriteLine("\nThe entered 2D array is:");
//             for (int i = 0; i < ROWS; i++)
//             {
//                 for (int j = 0; j < COLS; j++)
//                 {
//                     Console.Write($" {a[i, j] }");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

//1-D ARRAY EXAMPLE
using System;
namespace array{
    class array{
        static void Main(){
            int size;
            Console.Write("ENTER SIZE OF ARRAY: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            // Taking input for the array
            for(int i = 0; i < size; i++){  // ✅ FIXED: i < size instead of i <= size
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Printing the array
            Console.WriteLine("\nArray elements are:");
            foreach(int num in arr){   // ✅ FIXED: Using foreach loop to print array elements
                Console.Write(num + " ");
            }
        }
    }
}
