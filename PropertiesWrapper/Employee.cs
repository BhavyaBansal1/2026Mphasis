// using System;
// namespace day2{
//     public class Employee{
//         //wrappeer by property
//     //    public int Employeeage{get;set;} // private variable is created automatically knopwn as backing field so we just write property wraper
//     //    public string Employee_email{get;set;} // private variable is created automatically knopwn as backing field

//             private int age;
//             private string email;

//             public Employee(Employee o){
//                 this.age=o.age;
//                 this.email=o.email;//memeber wise copy
//             }
//             public Employee(){//default constructor as one is parameterized so default is must

//             }
//             public static void Main(){
//                 Employee obj=new Employee();
//                  obj.age=10;
//                 obj.email="c.com";
//                 Employee obj1=new Employee(obj);

//                obj1.email="bhvjbjhe";
//                 Console.WriteLine(obj1.email);
                
//             }


//     }
// }