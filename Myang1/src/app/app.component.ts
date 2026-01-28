import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MahiComponent } from './Mahi.component';
import { AmanComponent } from './aman/aman.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,MahiComponent],
  templateUrl:'./app.component.html'
  
})
export class AppComponent {
  title = 'Myang1';
}
