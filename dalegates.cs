// using System;

// delegate void Calculation(int a, int b);

// class Program
// {
//     private void add(int a, int b)
//     {
//         Console.WriteLine($"Sum is: {a + b}");
//     }
//       private void sub(int a, int b)
//     {
//         Console.WriteLine($"sub is: {a - b}");
//     }
//       private void multiply(int a, int b)
//     {
//         Console.WriteLine($"product is: {a * b}");
//     }
//       private void divide(int a, int b)
//     {
//         Console.WriteLine($"divide is: {a / b}");
//     }

//     static void Main()
//     {
//          Program obj=new Program();
//         Calculation obje = new Calculation(obj.add);
//         obje(78, 67);
//         obje=obj.sub;
//         obje(7,89);
//         obje=obj.multiply;
//         obje(9,3);
//         obje=obj.divide;
//         obje(7,87); 
//     }
// }


using System;

delegate void Calculation(int a, int b);

class Program
{
    private static void add(int a, int b)
    {
        Console.WriteLine($"Sum is: {a + b}");
    }
      private static void sub(int a, int b)
    {
        Console.WriteLine($"sub is: {a - b}");
    }
      private static void multiply(int a, int b)
    {
        Console.WriteLine($"product is: {a * b}");
    }
      private static void divide(int a, int b)
    {
        Console.WriteLine($"divide is: {a / b}");
    }

    static void Main()
    {
         Calculation obje;
         obje=add;
        obje(78, 67);
        obje=sub;
        obje(7,89);
        obje=multiply;
        obje(9,3);
        obje=divide;
        obje(7,87); 
    }
} 