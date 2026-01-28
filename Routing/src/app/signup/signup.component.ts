import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormGroupName, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import {Router} from '@angular/router'
import { AccountService } from '../Services/Account.Service';

@Component({
  selector: 'app-signup',
  standalone: true,
  imports: [CommonModule,FormsModule,ReactiveFormsModule],
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.css',
  providers:[AccountService]//IOc
})
export class SignupComponent
 {
  fb:FormGroup;
  constructor(private myRouter:Router,private mybuild:FormBuilder,private obj:AccountService)//Di
  {
    this.fb=this.mybuild.group({
      username:['',Validators.required],
      Password:['',Validators.required],
      email:['',Validators.required]
    })
  }
onSubmit():void
  {
  let data=this.fb.value;
 this.obj.createAcount(data).subscribe(data=>{
console.log(data);
 },error=>{
console.log(error);
 }
)
   
    this.myRouter.navigate(['/login']);
  }

}
