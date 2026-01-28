import { Routes } from '@angular/router';
import { SiginComponent } from './sigin/sigin.component';
import { SignupComponent } from './signup/signup.component';
import { DashbordComponent } from './dashbord/dashbord.component';

export const routes: Routes = [
    {path:'createAccount',component:SignupComponent},
    {path:'login', component:SiginComponent},
    {path:'Home',component:DashbordComponent}
];

