import { Component, Injector } from '@angular/core';
import { EmployeeService } from '../Service/Employee.Service';
import { Employee } from '../Models/Employee';
import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-aman',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './aman.component.html',
  styleUrl: './aman.component.css'
})
export class AmanComponent 
{
  emp:Employee=new Employee()//creating an object of employee class
  IsDisabled:boolean=true;

 showdata():void
 {
  alert(this.emp.Name);
 } 

}