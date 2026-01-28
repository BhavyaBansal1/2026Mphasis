// using System.Collections;

// // //     //generic class a,genric method using genrics
// // //     //<>
// // // //genric class
// // //     public class Coustomer<T>{
// // //         T ctr;
    
// // //     public Coustomer(T data){
// // //         this.ctr=data;
// // //     }
// // //     public void show(){
// // //         Console.WriteLine(ctr);

// // //     }}
// // //     public class Bhavya{
// // //     public static void Main(){
// // //         Coustomer <int> obj=new Coustomer<int>(10);
// // //         obj.show();
// // //          Coustomer <string> obj1=new Coustomer<string>("pune");
// // //         obj1.show();
       
// // //     }
// // // }

// // //Genric method
// // class Coustomer{
// //     // public void Transaction<T>(T ctr){
// //     //     Console.WriteLine(ctr);
// //     // }
// //         public void Transaction<T,C>(T ctr,C ctr1){
// //         Console.WriteLine(ctr+" "+ctr1);
// //     }
// //     public static void Main(){
// //         Coustomer obj=new Coustomer();
// //         // obj.Transaction<int>(10);
// //         //    obj.Transaction<string>("10p");

// //         obj.Transaction<int,string>(10,"Pune");
// //     }
// // }
// //Genric constraints
// //  class Coustomer<T> where T:class{
// //     T ctr;
// //     public Coustomer(T t){
// //         this.ctr=t;
// //     }
// //     public void showdata(){
// //         Console.WriteLine(ctr);
// //     }
// //     }
// //     class  sai{
// //         public static void Main(){
// //             Coustomer <string> obj=new Coustomer<string>("10");// for T:class only string
// //                  Coustomer <int> obj1=new Coustomer<int>(10);// for T:struct only int
// //             obj.showdata();
// //               obj1.showdata();
// //         }
// //     }


// //-- for t:new()
// class Coustomer <T> where T:new(){
//     public T showData(){
//         return new T();
//     }
// }
// class sai1{

//     public sai1(){

//     }
//     public void study(){
//         Console.WriteLine("study from sai1");
//     }

// }
//  class  sai{
//         public static void Main(){
//             // Coustomer <string> obj=new Coustomer<string>("10");// for T:class only string
//             //      Coustomer <int> obj1=new Coustomer<int>(10);// for T:struct only int
//             Coustomer<sai1> obj=new Coustomer<sai1>();// we pass class name with only default constructor only
//             var result=obj.showData();
//             result.study();
//         }
//     }