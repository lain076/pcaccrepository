import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-appareil',
  templateUrl: './appareil.component.html',
  styleUrls: ['./appareil.component.scss']
})
export class AppareilComponent implements OnInit {

  appareilName = 'machine à laver';
  appareilStatus = 'éteint';

  constructor() { }

  ngOnInit() {
  }

  getStatus(){
    return this.appareilStatus;
  }
}
