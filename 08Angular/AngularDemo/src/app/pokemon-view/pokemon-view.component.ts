import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pokemon-view',
  // template: '<p>pokemon-view inline template</p>',
  templateUrl: './pokemon-view.component.html',
  styleUrls: ['./pokemon-view.component.css']
})
export class PokemonViewComponent implements OnInit {

  constructor() { }

  num : number = 0;
  aMethod() : void {
    console.log('a method in pokemon view', this.num);
  }
  ngOnInit(): void {
    //get data, do some other initial set up behavior
    this.aMethod();
  }

}
