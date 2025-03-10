// // using System;
// // using System.ComponentModel;
// // class A{
// //     public int a,b,c;
// //     public A(){
// //     Console.WriteLine("ENTER VALUE OF A: ");
// //     a=Convert.ToInt32(Console.ReadLine());
// //         Console.WriteLine("ENTER VALUE OF b: ");
// //         b=Convert.ToInt32(Console.ReadLine());
// //     }
    
// //     public void Add(){
// //         Console.WriteLine($"SUM IS: {a+b}");
// //     }
// // }
// // class B:A
// // {
// //     public B():base()
// //     {
// //         c=a-b;
// //         Console.WriteLine($"sub is :{c}");
// //     }
// //     public void multiply(){
// //         Console.WriteLine($"PRODUCT IS : {a*b}");
// //     }
    
// // }
// // class program{
// //     static void Main(){
// //         B obj=new B();
// //         obj.Add();
// //         obj.multiply();
// //     }
// // }


// //  MUltilevel inheritence
// // using System;
// // class parent{
// //     public int a,b,c,d;
// //     public parent(){
// //         Console.WriteLine("ENTER VALUE OF A: ");
// //         a=Convert.ToInt32(Console.ReadLine());
// //         Console.WriteLine("ENTER VALUE OF b: ");
// //         b=Convert.ToInt32(Console.ReadLine());
// //     }
// //     public void add(){
// //         c=a+b;
// //         Console.WriteLine($"C is adding : {c}");
// //     }
// // }
// // class child:parent
// // {
// //     public void sub(){
// //         c=a-b;
// //         Console.WriteLine($"sub is:{c}");
// //     }
// // }
// // class grandchild:child{
// //     public grandchild():base(){
// //         d=98;
// //         Console.WriteLine($"d is :{d}");
// //     }

// // }
// // class program{
// //     static void Main(){
// //     grandchild obj=new grandchild();
// //     obj.add();
// //     obj.sub();
// //     }

// // }


// //  HIRACHICAL 
// using System;

// class Parent
// {
//     protected int a, b, c;

//     public Parent()
//     {
//         Console.Write("Enter value of A: ");
//         a = Convert.ToInt32(Console.ReadLine());
//     }

//     public void Show()
//     {
//         Console.WriteLine($"Value of A is: {a}");
//     }
// }

// class B : Parent
// {
//     public B()
//     {
//         Console.Write("Enter value of B: ");
//         b = Convert.ToInt32(Console.ReadLine());
//     }

//     public void Show2()
//     {
//         Console.WriteLine($"Value of B is: {b}");
//     }
// }

// class C : Parent
// {
//     public C(int F)
//     {
//         c = F;
//     }

//     public void Show3()
//     {
//         Console.WriteLine($"Value of C is: {c}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("\nCreating object of Class B:");
//         B obj1 = new B();
//         obj1.Show();
//         obj1.Show2();

//         Console.WriteLine("\nCreating object of Class C:");
//         C obj2 = new C(8);
//         obj2.Show();
//         obj2.Show3();
//     }
// }
