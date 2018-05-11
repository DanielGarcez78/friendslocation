import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'fl-map',
  templateUrl: './map.component.html'
})
export class MapComponent implements OnInit {

  constructor() { }

  eixoX : number[] = []
  eixoY : number[] = []
   

  ngOnInit() {

    for (let index = -90; index <= 90; index++) {
      this.eixoX.push(index)
      this.eixoY.push(index)
    }

  }

}
