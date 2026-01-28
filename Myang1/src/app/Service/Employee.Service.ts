 import { Injectable } from "@angular/core";
import { Employee } from "../Models/Employee";

 @Injectable({
    providedIn:'root'
 })
export class EmployeeService
{
       // EmployeeAddress():string
    // {
    //     return 'Pune';
    // }

// EmployeeAddress():Employee
//     {
//         let obj=new Employee();
//         obj.Age=21;
//         obj.Id=101;
//         obj.Name="Bhavya";
//         return obj;

//     }
EmployeeAddress():Employee[]
{
  let list:Employee[]=[];
  list.push({Id:102,Name:"Bahvaya",Age:21});
  list.push({Id:103,Name:"Aman",Age:22});
  list.push({Id:104,Name:"GAurav",Age:213});
  return list;
}

}