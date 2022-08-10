import { Component, OnDestroy, OnInit } from '@angular/core';
import { AuthService } from '../services/auth-service/auth.service';
import { PokeApiService } from '../services/poke-api-service/poke-api.service';
import { PokeTrainer } from '../models/poketrainer';

@Component({
  selector: 'app-pokemon-view',
  templateUrl: './pokemon-view.component.html',
  styleUrls: ['./pokemon-view.component.css']
})
export class PokemonViewComponent implements OnInit, OnDestroy {

  constructor(private auth: AuthService, private api:PokeApiService) { }

  currentUser : PokeTrainer = {
    name : ''
  };
  ngOnInit(): void {
    //get data, do some other initial set up behavior
    //get pokemon data according to the current user
    this.currentUser = this.auth.getCurrentUser();
    console.log(this.currentUser);
    if(this.currentUser.id) {
      this.api.getPokemonByTrainerId(this.currentUser.id).subscribe((res) => {
        console.log(res);
      });
    }
  }

  ngOnDestroy() : void {
    //clean up code here
  }

}
