// using System;
// class LOOP{
//     static void Main(){
//         int i=10;
//         while (i>=0)
//         {
//             Console.WriteLine(i);i--;
//         }

//     }
// }

// do-while loop
//  int i=10;
// do{ 
//     Console.WriteLine(i);
//     i--;
// }
// while(i>=0);
//  FOR LOOP
// for(int i=0;i<=20;i++){
//     Console.Write(i+" ");
// }

//  FOR EACH LOOP 
// int[] a={1,2,3,4,5};
// foreach(int i in a ){
//     Console.WriteLine(i);
// }

// using System;

// class Program {
//     static void Main() {
//         Console.Write("Enter size: ");
//         int size = Convert.ToInt32(Console.ReadLine());

//         int[] a = new int[size];

//         for (int i = 0; i < size; i++) {  // Fixed `i <= size` → `i < size`
//             Console.Write($"Enter element at index {i}: ");
//             a[i] = Convert.ToInt32(Console.ReadLine());  // Fixed wrong indexing
//         }

//         Console.WriteLine("Array elements:");
//         foreach (int element in a) {  // Fixed incorrect foreach usage
//             Console.WriteLine(element);
//         }
//     }
// }
