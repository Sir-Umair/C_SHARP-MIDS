// // using System;
// // class A{
// //     protected int a=43;int b=76;
// //     public void show(){
// //         Console.WriteLine($"A={a+b}");
// //     }
// //    public void show(int a,int b){
// //         Console.WriteLine($"A={a+b}");
// //     }
// // }
// // class B{}
// // class program{
// //     static void Main(){
// //     A obj =new A();obj.show(87,76);
  
// //     obj.show();
// //     }
// // //  it is compile time polymerphison
// // }

// // Runtime polymerphison
// using System;
// class A {
//     public virtual void show() {
//         Console.WriteLine("a is here");
//     }
// }

// class B : A {
//     public override void show() {
//         base.show();  // Calls A's show() first
//         Console.WriteLine("b is here");
//     }
// }

// class Program {
//     static void Main() {
//         A obj = new B();  // Base class reference to derived class object
//         obj.show();  // Calls B's show(), which also calls A's show()
//           // Calls B's show() again
//     }
// }
