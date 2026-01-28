// using System;
// // class father{
// //     public father(){
// //         Console.WriteLine("Iam default constructor of base class");
// //     }
// //  static father(){
// //         Console.WriteLine("Iam static constructor base class");
// //     }
// //      ConsoleCancelEventArgs father(){
// //         Console.WriteLine("Iam static constructor base class");
// //     }

// // }
// // class child:father{
// //     public child(){
// //         Console.WriteLine("Iam default constructor derived class");
        
// //     }  static child(){
// //         Console.WriteLine("Iam static constructor derived class");
// //     }
// //     public static void Main(){
// //         child a=new child();
// //     }
// // }
// class father{
//     public father(){
//         Console.WriteLine("Iam default constructor of base class");
//     }
//  public father(string str){
//         Console.WriteLine("Iam parm constructor base class");
//     }
// }
// class child:father{
//     public child(){
//         Console.WriteLine("Iam default constructor derived class");
        
//     }
//     public child(string str):base(str){
//             Console.WriteLine("Iam param constructor defaule class");
//     }
//     public static void Main(){
//         // child a=new child();
//          child a=new child("kli");
//     }}