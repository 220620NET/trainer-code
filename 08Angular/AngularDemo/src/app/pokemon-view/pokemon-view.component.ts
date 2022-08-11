import { Component, OnDestroy, OnInit } from '@angular/core';
import { AuthService } from '../services/auth-service/auth.service';
import { PokeApiService } from '../services/poke-api-service/poke-api.service';
import { PokeTrainer } from '../models/poketrainer';
import { Pokemon } from '../models/pokemon';

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

  pokemons : Pokemon[] = [{name: '', level: 0, trainerId: 0}]

  withdraw(pokeId : number | undefined) {
    if(pokeId) {
      if(confirm('would you really like to withdraw this pokemon?')){
        this.api.withdrawPokemon(pokeId).subscribe((res) => {
          alert('here is your pokemon!' + res.name);
          if(this.currentUser.id) {
            this.api.getPokemonByTrainerId(this.currentUser.id).subscribe((res) => {
              this.pokemons = res;
            })
          }
        })
      }
    }
  }

  ngOnInit(): void {
    //get data, do some other initial set up behavior
    //get pokemon data according to the current user
    this.currentUser = this.auth.getCurrentUser();
    if(this.currentUser.id) {
      this.api.getPokemonByTrainerId(this.currentUser.id).subscribe((res) => {
        this.pokemons = res as Pokemon[];
        console.log(res);
      });
    }
  }

  ngOnDestroy() : void {
    //clean up code here
  }

}
