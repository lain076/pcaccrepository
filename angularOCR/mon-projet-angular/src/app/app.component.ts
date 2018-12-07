import { Component } from '@angular/core';

@Component({
  selector: 'app-root', /* nom UNIQUE donné au component */
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  isAuth = false;
  constructor() {
    setTimeout(
      () => {
        this.isAuth = true;
      },4000
    );


  }
}
