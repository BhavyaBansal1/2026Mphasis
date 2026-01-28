// // interface inotification
// // {
// //     public void notify(); // by default functionsignature is abstract`

// // }
// // public class Emailnotification:inotification{
// //     public void notify(){
// //         Console.WriteLine("notification by email");
// //     }
// // }
// // public class smsnotification:inotification{
// //     void inotification.notify(){
// //         Console.WriteLine("notification by sms");
// //     }
// // }

// // class notificationfactory{
    
// //     public inotification createnotification(string type){
// //     if (type =="email"){
// //         return new Emailnotification();
// //     }
// //     else if(type== "sms"){
// //         return new smsnotification();
// //     }
// //     else{
// //         return null;

// //     }        
// //     }
// // }

// // class FactoryMethod{
// //     public static void Main(){
// //         notificationfactory obj=new notificationfactory();
// //         inotification msg=obj.createnotification("email");
// //         //  inotification msg=obj.createnotification("sms");
// //      msg.notify();


// //     }
// // }
// // // ------------------------------------------
// // // Builder
// // build complex objects step by step

// class Meal{
//     public string Food { get; set; }
//     public string Drink { get; set; }

//     public void showmeal(){
//         Console.WriteLine("food"+ Food);
//         Console.WriteLine("drink"+Drink);
//     }
// }
// class MealBuilder{
//     private Meal m=new Meal();
//     public MealBuilder AddFood(string food){
//         m.Food=food;
//         return this;
//     }
//     public MealBuilder AddDrink(string drink){
//         m.Drink=drink;
//         return this;
//     }
//     public Meal Build(){
//         return m;
//     }
// }

// public class ready{
//     public static void Main(){
//         Meal m=new MealBuilder().
//         AddDrink("yes").
//         AddFood("rice").
//         Build();
//         m.showmeal();

//     }
// }















