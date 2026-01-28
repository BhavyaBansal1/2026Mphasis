import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EmployeeService } from './Service/Employee.Service';
import { AmanComponent } from './aman/aman.component';
import { Employee } from './Models/Employee';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'mahi',
  standalone: true,
  imports: [RouterOutlet,AmanComponent,CommonModule],
  templateUrl:'./mahi.component.html',
  //providers:[EmployeeService]

  
})
export class MahiComponent {
  title = 'Myang1';
    //emp?:Employee;
//   name:any;
  list:Employee[]=[];
  constructor(private e:EmployeeService)
  {

  }
  Address():void
  {
  
    this.list=this.e.EmployeeAddress()

   }
}
