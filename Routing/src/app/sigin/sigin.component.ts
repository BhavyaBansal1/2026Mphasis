import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormGroupName, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import {Router} from '@angular/router'
import { AccountService } from '../Services/Account.Service';

@Component({
  selector: 'app-sigin',
  standalone: true,
  imports: [CommonModule,FormsModule,ReactiveFormsModule],
  templateUrl: './sigin.component.html',
  styleUrl: './sigin.component.css',
  providers:[AccountService]
})
export class SiginComponent {

   fb1:FormGroup;
   constructor(private myRouter:Router, private mybuild:FormBuilder,private obj:AccountService)//Di
   {
     this.fb1=this.mybuild.group({

       Password:['',Validators.required],
      email:['',Validators.required]
     })
   }

  onSubmit():void
  {
   let data=this.fb1.value;
 this.obj.Login(data).subscribe(data=>{
console.log(data);
 },error=>{
console.log(error);
 }
)
   
    this.myRouter.navigate(['/Home']);
  }

}
